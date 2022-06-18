import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/models/Narudzba.dart';
import 'package:naruci_ba_mobile/models/NarudzbaStatus.dart';
import 'package:naruci_ba_mobile/models/Poslovnica.dart';
import 'package:naruci_ba_mobile/models/TrgovackiLanac.dart';
import 'package:naruci_ba_mobile/models/app_config.dart';
import 'package:naruci_ba_mobile/providers/NarudzbaProvider.dart';
import 'package:naruci_ba_mobile/providers/NarudzbaStatus.dart';
import 'package:naruci_ba_mobile/providers/app_config_provider.dart';
import 'package:naruci_ba_mobile/providers/authentification_provider.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaProvider.dart';
import 'package:naruci_ba_mobile/providers/trgovackiLanacProvider.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';
import 'package:naruci_ba_mobile/widgets/NarudzbaTracker.dart';
import 'package:provider/src/provider.dart';
import 'package:signalr_netcore/hub_connection.dart';
import 'package:signalr_netcore/hub_connection_builder.dart';

class NarudzbaScreen extends StatefulWidget {
  const NarudzbaScreen({Key? key, required this.narudzbaId}) : super(key: key);
  final int narudzbaId;

  @override
  State<NarudzbaScreen> createState() => _NarudzbaScreenState();
}

class _NarudzbaScreenState extends State<NarudzbaScreen> {
  late NarudzbaProvider _narudzbaProvider;
  late PoslovnicaProvider _poslovnicaProvider;
  late TrgovackiLanacProvider _trgovackiLanacProvider;
  late NarudzbaStatusProvider _narudzbaStatusProvider;
  late AuthentificationProvider _authentificationProvider;
  late AppConfigProvider _configProvider;

  Narudzba? _narudzba;
  Poslovnica? _poslovnica;
  TrgovackiLanac? _trgovackiLanac;
  List<NarudzbaStatus>? _statusi = List.empty();

  late AppConfigProvider provider =
      Provider.of<AppConfigProvider>(context, listen: false);

  late HubConnection hubConnection;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _poslovnicaProvider = context.read<PoslovnicaProvider>();
    _narudzbaProvider = context.read<NarudzbaProvider>();
    _trgovackiLanacProvider = context.read<TrgovackiLanacProvider>();
    _narudzbaStatusProvider = context.read<NarudzbaStatusProvider>();
    _authentificationProvider = context.read<AuthentificationProvider>();
    _configProvider = context.read<AppConfigProvider>();
    setHub();
    setInfo();
  }

  Future<void> setHub() async {
    var config = await getAppConfigProvider();
    hubConnection =
        HubConnectionBuilder().withUrl(config.signalRHubEndpoint).build();
    hubConnection.on("NarudzbaUpdateovana", (List<Object>? arg) => setInfo());
    await hubConnection.start();
  }

  Future<AppConfig> getAppConfigProvider() async {
    if (provider == null) {
      var config = Provider.of<AppConfigProvider>(context, listen: false);
      provider = config;
    }
    return await provider.getConfig();
  }

  void setInfo() async {
    Narudzba narudzba = await _narudzbaProvider.getById(id: widget.narudzbaId);
    Poslovnica poslovnica =
        await _poslovnicaProvider.getById(id: narudzba.poslovnicaID);
    TrgovackiLanac trgovackiLanac =
        await _trgovackiLanacProvider.getById(id: poslovnica.trgovackiLanacID);
    List<NarudzbaStatus> statusi = await _narudzbaStatusProvider.get();
    setState(() {
      _narudzba = narudzba;
      _poslovnica = poslovnica;
      _trgovackiLanac = trgovackiLanac;
      _statusi = statusi;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MainTemplate(
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
                onPressed: () => {},
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
          Padding(
            padding: const EdgeInsets.fromLTRB(20, 10, 20, 10),
            child: ElevatedButton(
                onPressed: () => {},
                child: Text(
                  "Lokacija dostavljaca",
                  style: TextStyle(fontWeight: FontWeight.bold, fontSize: 18),
                ),
                style: ElevatedButton.styleFrom(
                  shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(30)),
                  fixedSize: Size(MediaQuery.of(context).size.width, 50),
                  primary: Color.fromARGB(255, 255, 83, 73),
                )),
          ),
        ],
      ),
    );
  }
}
