import 'package:flutter/material.dart';
import 'package:modal_progress_hud/modal_progress_hud.dart';
import 'package:naruci_ba_mobile/models/Poslovnica.dart';
import 'package:naruci_ba_mobile/models/TrgovackiLanac.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaProvider.dart';
import 'package:naruci_ba_mobile/providers/trgovackiLanacProvider.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';
import 'package:naruci_ba_mobile/widgets/poslovnica/poslovnica_card.dart';
import 'package:provider/src/provider.dart';

class poslovniceImena {
  int poslovnicaId;
  int trgovackiLanacId;
  String naziv;
  String slika;

  poslovniceImena(
      this.poslovnicaId, this.trgovackiLanacId, this.naziv, this.slika);
}

class HomeScreen extends StatefulWidget {
  static String routeName = "home";
  const HomeScreen({Key? key}) : super(key: key);

  @override
  _HomeScreenState createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
  late PoslovnicaProvider _poslovnicaProvider;
  late TrgovackiLanacProvider _trgovackiLanacProvider;
  List<Poslovnica> _allPoslovnice = List.empty();
  List<Poslovnica> _filteredPoslovnice = List.empty();
  List<poslovniceImena> _poslovniceImena = List.empty();

  final GlobalKey _listKey = GlobalKey();

  bool showFiltered = false;

  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    isLoading = false;
    _poslovnicaProvider = context.read<PoslovnicaProvider>();
    _trgovackiLanacProvider = context.read<TrgovackiLanacProvider>();
    initComponent();
  }

  void initComponent() async {
    setState(() {
      isLoading = true;
    });
    List<Poslovnica> poslovnice = await _poslovnicaProvider.get();

    for (var poslovnica in poslovnice) {
      TrgovackiLanac lanac = await _trgovackiLanacProvider.getById(
          id: poslovnica.trgovackiLanacID);
      _poslovniceImena = [
        ..._poslovniceImena,
        poslovniceImena(poslovnica.poslovnicaID, lanac.trgovackiLanacID,
            lanac.naziv, lanac.slika)
      ];
    }

    setState(() {
      _allPoslovnice = poslovnice;
      isLoading = false;
    });
  }

  void filterPoslovnice(value) {
    _listKey.currentState?.dispose();
    var filteredPoslovniceImena = _poslovniceImena
        .where((pos) =>
            pos.naziv.toLowerCase().contains(value.toString().toLowerCase()))
        .toList();

    List<int> poslovniceIds = List.empty();
    for (var element in filteredPoslovniceImena) {
      poslovniceIds = [...poslovniceIds, element.poslovnicaId];
    }

    setState(() {
      _filteredPoslovnice = _allPoslovnice
          .where((pos) => poslovniceIds.contains(pos.poslovnicaID))
          .toList();
      if (value != null && value != "") {
        showFiltered = true;
      } else {
        showFiltered = false;
      }
    });
  }

  @override
  Widget build(BuildContext context) {
    return MainTemplate(
      child: ModalProgressHUD(
        inAsyncCall: isLoading,
        child: Column(
          children: [
            Container(
              height: 80,
              width: MediaQuery.of(context).size.width,
              decoration: BoxDecoration(
                  color: Color.fromARGB(255, 255, 83, 73),
                  borderRadius: BorderRadius.only(
                      bottomLeft: Radius.circular(20),
                      bottomRight: Radius.circular(20))),
              child: Padding(
                padding: const EdgeInsets.fromLTRB(30, 10, 30, 10),
                child: Column(
                  children: [
                    Row(
                      children: [
                        Container(
                          width: MediaQuery.of(context).size.width / 1.2,
                          child: TextField(
                            onSubmitted: (value) => {filterPoslovnice(value)},
                            decoration: InputDecoration(
                              filled: true,
                              fillColor: Colors.white,
                              hintText: "Search",
                              border: OutlineInputBorder(
                                  borderRadius:
                                      BorderRadius.all(Radius.circular(10)),
                                  borderSide: BorderSide(
                                    color: Colors.white,
                                  )),
                              contentPadding: EdgeInsets.all(10),
                            ),
                          ),
                        ),
                      ],
                    ),
                  ],
                ),
              ),
            ),
            Padding(
              padding: const EdgeInsets.fromLTRB(25, 10, 25, 0),
              child: Container(
                  height: MediaQuery.of(context).size.height / 5 * 3.7,
                  child: showFiltered
                      ? ListView(children: [
                          ..._filteredPoslovnice.map<Widget>((poslovnica) {
                            return PoslovnicaCard(
                              poslovnicaId: poslovnica.poslovnicaID.toString(),
                              nazivPoslovnice: _poslovniceImena
                                  .firstWhere((e) =>
                                      e.poslovnicaId == poslovnica.poslovnicaID)
                                  .naziv,
                              adresaPoslovnice: poslovnica.adresa,
                              slika: _poslovniceImena
                                  .firstWhere((e) =>
                                      e.poslovnicaId == poslovnica.poslovnicaID)
                                  .slika,
                            );
                          })
                        ])
                      : ListView(
                          children: [
                            ..._allPoslovnice.map<Widget>((poslovnica) {
                              return PoslovnicaCard(
                                poslovnicaId:
                                    poslovnica.poslovnicaID.toString(),
                                nazivPoslovnice: _poslovniceImena
                                    .firstWhere((e) =>
                                        e.poslovnicaId ==
                                        poslovnica.poslovnicaID)
                                    .naziv,
                                adresaPoslovnice: poslovnica.adresa,
                                slika: _poslovniceImena
                                    .firstWhere((e) =>
                                        e.poslovnicaId ==
                                        poslovnica.poslovnicaID)
                                    .slika,
                              );
                            })
                          ],
                        )),
            ),
          ],
        ),
      ),
    );
  }
}
