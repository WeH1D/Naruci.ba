import 'package:flutter/material.dart';
import 'package:modal_progress_hud/modal_progress_hud.dart';
import 'package:naruci_ba_mobile/models/Narudzba.dart';
import 'package:naruci_ba_mobile/models/NarudzbaStatus.dart';
import 'package:naruci_ba_mobile/models/Poslovnica.dart';
import 'package:naruci_ba_mobile/models/TrgovackiLanac.dart';
import 'package:naruci_ba_mobile/providers/KlijentProvider.dart';
import 'package:naruci_ba_mobile/providers/NarudzbaProvider.dart';
import 'package:naruci_ba_mobile/providers/NarudzbaStatus.dart';
import 'package:naruci_ba_mobile/providers/dostavljacProvider.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaProvider.dart';
import 'package:naruci_ba_mobile/providers/trgovackiLanacProvider.dart';
import 'package:naruci_ba_mobile/screens/narudzba_screen.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';
import 'package:provider/src/provider.dart';

class Status {
  int narudzbaId;
  String statusNaziv;
  String psolovnicaAdresa;
  String trgovackiLanac;
  Status(this.narudzbaId, this.statusNaziv, this.psolovnicaAdresa,
      this.trgovackiLanac);
}

class MojeNarudzbe extends StatefulWidget {
  final bool isDostavljac;
  const MojeNarudzbe({Key? key, this.isDostavljac = false}) : super(key: key);

  @override
  State<MojeNarudzbe> createState() => _MojeNarudzbeState();
}

class _MojeNarudzbeState extends State<MojeNarudzbe> {
  late NarudzbaProvider _narudzbaProvider;
  late KlijentProvider _klijentProvider;
  late DostavljacProvider _dostavljacProvider;
  late NarudzbaStatusProvider _statusProvider;
  late PoslovnicaProvider _poslovnicaProvider;
  late TrgovackiLanacProvider _trgovackiLanacprovider;

  List<Narudzba> _narudzbe = List.empty();
  List<Status> statusi = List.empty();

  bool isLoading = true;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    isLoading = false;
    _narudzbaProvider = context.read<NarudzbaProvider>();
    _klijentProvider = context.read<KlijentProvider>();
    _statusProvider = context.read<NarudzbaStatusProvider>();
    _poslovnicaProvider = context.read<PoslovnicaProvider>();
    _trgovackiLanacprovider = context.read<TrgovackiLanacProvider>();
    _dostavljacProvider = context.read<DostavljacProvider>();
    getNarudzbe();
  }

  void getNarudzbe() async {
    setState(() {
      isLoading = true;
    });
    List<Narudzba> narudzbe = await _narudzbaProvider
        .get(searchParams: {"KlijentID": _klijentProvider.klijendID});
    for (var narudzba in narudzbe) {
      NarudzbaStatus status =
          await _statusProvider.getById(id: narudzba.narudzbaStatusID);
      Poslovnica poslovnica =
          await _poslovnicaProvider.getById(id: narudzba.poslovnicaID);
      TrgovackiLanac trgovackiLanac = await _trgovackiLanacprovider.getById(
          id: poslovnica.trgovackiLanacID);
      statusi = [
        ...statusi,
        Status(narudzba.narudzbaID, status.naziv, poslovnica.adresa,
            trgovackiLanac.naziv)
      ];
    }
    setState(() {
      _narudzbe = narudzbe;
      isLoading = false;
    });
  }

  void goToNarudzbaScreen(int narudzbaId) {
    Navigator.push(
      context,
      MaterialPageRoute(
          builder: (context) => NarudzbaScreen(
                narudzbaId: narudzbaId,
              )),
    );
  }

  @override
  Widget build(BuildContext context) {
    return MainTemplate(
      child: ModalProgressHUD(
        inAsyncCall: isLoading,
        child: SingleChildScrollView(
          child: Column(
            children: [
              Padding(
                padding: const EdgeInsets.fromLTRB(0, 20, 0, 20),
                child: Text("Moje narudzbe",
                    style: TextStyle(
                        fontSize: 20,
                        fontWeight: FontWeight.bold,
                        color: Color.fromARGB(255, 255, 83, 73))),
              ),
              ..._narudzbe.map<Widget>((narudzba) {
                return GestureDetector(
                  onTap: () => {goToNarudzbaScreen(narudzba.narudzbaID)},
                  child: Padding(
                    padding: const EdgeInsets.fromLTRB(10, 20, 10, 20),
                    child: Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Text(
                                statusi.isNotEmpty
                                    ? statusi
                                        .where((status) =>
                                            narudzba.narudzbaID ==
                                            status.narudzbaId)
                                        .first
                                        .statusNaziv
                                    : "",
                                style: TextStyle(
                                    fontWeight: FontWeight.bold,
                                    fontSize: 20,
                                    color: Color.fromARGB(255, 255, 83, 73))),
                            Row(
                              children: [
                                Text(
                                  "${narudzba.datum?.day}.",
                                  style: TextStyle(
                                      fontWeight: FontWeight.bold,
                                      fontSize: 15),
                                ),
                                Text("${narudzba.datum?.month}.",
                                    style: TextStyle(
                                        fontWeight: FontWeight.bold,
                                        fontSize: 15)),
                                Text("${narudzba.datum?.year}",
                                    style: TextStyle(
                                        fontWeight: FontWeight.bold,
                                        fontSize: 15)),
                              ],
                            ),
                            Row(
                              children: [
                                Text("${narudzba.datum?.hour}:"),
                                Text("${narudzba.datum?.minute}")
                              ],
                            )
                          ],
                        ),
                        Row(
                          children: [
                            Column(
                              crossAxisAlignment: CrossAxisAlignment.end,
                              children: [
                                Text(
                                  statusi.isNotEmpty
                                      ? statusi
                                              .where((status) =>
                                                  narudzba.narudzbaID ==
                                                  status.narudzbaId)
                                              .first
                                              .trgovackiLanac ??
                                          ""
                                      : "",
                                  style: TextStyle(fontSize: 15),
                                ),
                                Text(
                                  statusi.isNotEmpty
                                      ? statusi
                                              .where((status) =>
                                                  narudzba.narudzbaID ==
                                                  status.narudzbaId)
                                              .first
                                              .psolovnicaAdresa ??
                                          ""
                                      : "",
                                  style: TextStyle(fontSize: 15),
                                ),
                                Text(
                                  "${narudzba.ukupanIznos}KM",
                                  style: TextStyle(
                                      fontWeight: FontWeight.bold,
                                      fontSize: 15),
                                ),
                              ],
                            ),
                            SizedBox(width: 20),
                            Icon(
                              Icons.chevron_right,
                              color: Color.fromARGB(255, 255, 83, 73),
                            ),
                          ],
                        ),
                      ],
                    ),
                  ),
                );
              }),
            ],
          ),
        ),
      ),
    );
  }
}
