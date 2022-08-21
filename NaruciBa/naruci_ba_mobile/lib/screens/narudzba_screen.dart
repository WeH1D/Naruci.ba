import 'package:camera/camera.dart';
import 'package:flutter/material.dart';
import 'package:modal_progress_hud/modal_progress_hud.dart';
import 'package:naruci_ba_mobile/models/Narudzba.dart';
import 'package:naruci_ba_mobile/models/NarudzbaStatus.dart';
import 'package:naruci_ba_mobile/models/Poslovnica.dart';
import 'package:naruci_ba_mobile/models/TrgovackiLanac.dart';
import 'package:naruci_ba_mobile/models/app_config.dart';
import 'package:naruci_ba_mobile/providers/NarudzbaProvider.dart';
import 'package:naruci_ba_mobile/providers/NarudzbaStatus.dart';
import 'package:naruci_ba_mobile/providers/app_config_provider.dart';
import 'package:naruci_ba_mobile/providers/authentification_provider.dart';
import 'package:naruci_ba_mobile/providers/dostavljacProvider.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaProvider.dart';
import 'package:naruci_ba_mobile/providers/trgovackiLanacProvider.dart';
import 'package:naruci_ba_mobile/screens/TakePictureScreen.dart';
import 'package:naruci_ba_mobile/screens/mojeNarudzbe.dart';
import 'package:naruci_ba_mobile/screens/narudzba_info_screen.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';
import 'package:naruci_ba_mobile/widgets/NarudzbaTracker.dart';
import 'package:provider/src/provider.dart';
import 'package:signalr_netcore/hub_connection.dart';
import 'package:signalr_netcore/hub_connection_builder.dart';

class NarudzbaScreen extends StatefulWidget {
  const NarudzbaScreen(
      {Key? key, required this.narudzbaId, this.dostavljacView = false})
      : super(key: key);
  final int narudzbaId;
  final bool dostavljacView;

  @override
  State<NarudzbaScreen> createState() => _NarudzbaScreenState();
}

class _NarudzbaScreenState extends State<NarudzbaScreen> {
  late NarudzbaProvider _narudzbaProvider;
  late PoslovnicaProvider _poslovnicaProvider;
  late TrgovackiLanacProvider _trgovackiLanacProvider;
  late NarudzbaStatusProvider _narudzbaStatusProvider;
  late AuthentificationProvider _authentificationProvider;
  late DostavljacProvider _dostavljacProvider;
  late AppConfigProvider _configProvider;

  Narudzba? _narudzba;
  Poslovnica? _poslovnica;
  TrgovackiLanac? _trgovackiLanac;
  List<NarudzbaStatus>? _statusi = List.empty();
  String? _sljStatus;

  bool postojiRacun = false;

  late AppConfigProvider provider =
      Provider.of<AppConfigProvider>(context, listen: false);

  late HubConnection hubConnection;

  CameraDescription? firstCamera;

  bool isLoading = true;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    initCamera();
    isLoading = false;
    _poslovnicaProvider = context.read<PoslovnicaProvider>();
    _narudzbaProvider = context.read<NarudzbaProvider>();
    _trgovackiLanacProvider = context.read<TrgovackiLanacProvider>();
    _narudzbaStatusProvider = context.read<NarudzbaStatusProvider>();
    _authentificationProvider = context.read<AuthentificationProvider>();
    _dostavljacProvider = context.read<DostavljacProvider>();
    _configProvider = context.read<AppConfigProvider>();
    setHub();
    setInfo();
  }

  Future<void> initCamera() async {
    // Ensure that plugin services are initialized so that `availableCameras()`
// can be called before `runApp()`
    WidgetsFlutterBinding.ensureInitialized();

// Obtain a list of the available cameras on the device.
    final cameras = await availableCameras();

// Get a specific camera from the list of available cameras.
    firstCamera = cameras.first;
  }

  uslikajRacun() {
    Navigator.push(
      context,
      MaterialPageRoute(
        builder: (context) => TakePictureScreen(
          camera: firstCamera!,
          narudzbaId: widget.narudzbaId,
        ),
      ),
    );
  }

  Future<void> setHub() async {
    setState(() {
      isLoading = true;
    });
    var config = await getAppConfigProvider();
    hubConnection = HubConnectionBuilder()
        .withUrl(config.signalRHubEndpoint)
        .withAutomaticReconnect()
        .build();
    hubConnection.on("NarudzbaUpdateovana", (List<Object>? arg) => setInfo());
    await hubConnection.start();
    setState(() {
      isLoading = false;
    });
  }

  Future<AppConfig> getAppConfigProvider() async {
    if (provider == null) {
      var config = Provider.of<AppConfigProvider>(context, listen: false);
      provider = config;
    }
    return await provider.getConfig();
  }

  void setInfo() async {
    setState(() {
      isLoading = true;
    });
    Narudzba narudzba = await _narudzbaProvider.getById(id: widget.narudzbaId);
    Poslovnica poslovnica =
        await _poslovnicaProvider.getById(id: narudzba.poslovnicaID);
    TrgovackiLanac trgovackiLanac =
        await _trgovackiLanacProvider.getById(id: poslovnica.trgovackiLanacID);
    List<NarudzbaStatus> statusi = await _narudzbaStatusProvider.get();
    setState(() {
      if (narudzba.slikaRacuna != null && narudzba.slikaRacuna != "") {
        postojiRacun = true;
      }
      isLoading = false;
      _statusi = statusi;
      Iterable<NarudzbaStatus>? tempStauts = _statusi?.where((st) =>
          st.narudzbaStatusID ==
          (_narudzba?.narudzbaStatusID != null
              ? (_narudzba!.narudzbaStatusID == 6
                  ? 6
                  : _narudzba!.narudzbaStatusID! + 1)
              : 0));
      _narudzba = narudzba;
      _poslovnica = poslovnica;
      _trgovackiLanac = trgovackiLanac;
      _sljStatus = tempStauts != null && tempStauts.isNotEmpty
          ? tempStauts.first.naziv
          : "";
    });
  }

  void openMoreInfo() {
    Navigator.push(
      context,
      MaterialPageRoute(
        builder: (context) => NarudzbaInfoScreen(
          narudzbaId: widget.narudzbaId,
        ),
      ),
    );
  }

  void setToNextStatus() async {
    setState(() {
      isLoading = true;
    });
    await _narudzbaProvider.put(
        id: widget.narudzbaId,
        request: {"NarudzbaStatusID": (_narudzba!.narudzbaStatusID! + 1)});
    if (_narudzba!.narudzbaStatusID! + 1 == 6) {
      await _dostavljacProvider
          .put(id: _narudzba!.dostavljacID!, request: {"dostavljacStatus": 1});
    }
    setInfo();
    await hubConnection.invoke("NarudzbaUpdateovana");
    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MainTemplate(
      child: ModalProgressHUD(
        inAsyncCall: isLoading,
        child: Column(
          children: [
            SizedBox(
              height: 20,
            ),
            Text(
              _trgovackiLanac?.naziv ?? "",
              style: TextStyle(fontSize: 25, fontWeight: FontWeight.bold),
            ),
            SizedBox(
              height: 5,
            ),
            Text(
              _poslovnica?.adresa ?? "",
              style: TextStyle(fontSize: 15),
            ),
            SizedBox(
              height: 5,
            ),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Text("${_narudzba?.datum?.day.toString() ?? ""}."),
                Text("${_narudzba?.datum?.month.toString() ?? ""}."),
                Text(_narudzba?.datum?.year.toString() ?? ""),
              ],
            ),
            Padding(
              padding: EdgeInsets.fromLTRB(30, 20, 30, 20),
              child: Column(
                children: [
                  ..._statusi!.map<Widget>((status) {
                    return status.narudzbaStatusID < 7
                        ? NarudzbaTracker(
                            status: status.naziv,
                            isActive: _narudzba!.narudzbaStatusID! <
                                status.narudzbaStatusID,
                            isLast: status.narudzbaStatusID < 6)
                        : Container();
                  })
                ],
              ),
            ),
            Padding(
              padding: const EdgeInsets.fromLTRB(20, 10, 20, 10),
              child: ElevatedButton(
                  onPressed: () => {openMoreInfo()},
                  child: Text(
                    "Vise informacija",
                    style: TextStyle(fontWeight: FontWeight.bold, fontSize: 18),
                  ),
                  style: ElevatedButton.styleFrom(
                    shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(30)),
                    fixedSize: Size(MediaQuery.of(context).size.width, 50),
                    primary: Color.fromARGB(255, 255, 83, 73),
                  )),
            ),
            widget.dostavljacView
                ? _narudzba?.narudzbaStatusID != 6
                    ? Column(
                        children: [
                          Padding(
                            padding: const EdgeInsets.fromLTRB(20, 10, 20, 10),
                            child: ElevatedButton(
                                onPressed: postojiRacun
                                    ? null
                                    : () => {uslikajRacun()},
                                child: Text(
                                  "Uslikaj racun",
                                  style: TextStyle(
                                      fontWeight: FontWeight.bold,
                                      fontSize: 18),
                                ),
                                style: ElevatedButton.styleFrom(
                                  shape: RoundedRectangleBorder(
                                      borderRadius: BorderRadius.circular(30)),
                                  fixedSize: Size(
                                      MediaQuery.of(context).size.width, 50),
                                  primary: Color.fromARGB(255, 255, 83, 73),
                                )),
                          ),
                          Padding(
                            padding: const EdgeInsets.fromLTRB(20, 10, 20, 10),
                            child: ElevatedButton(
                                onPressed: () => {setToNextStatus()},
                                child: Text(
                                  "Postavi na status $_sljStatus",
                                  style: TextStyle(
                                      fontWeight: FontWeight.bold,
                                      fontSize: 18),
                                ),
                                style: ElevatedButton.styleFrom(
                                  shape: RoundedRectangleBorder(
                                      borderRadius: BorderRadius.circular(30)),
                                  fixedSize: Size(
                                      MediaQuery.of(context).size.width, 50),
                                  primary: Color.fromARGB(255, 255, 83, 73),
                                )),
                          ),
                        ],
                      )
                    : Container()
                : Container()
          ],
        ),
      ),
    );
  }
}
