import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/CustomTypes/KategorijaForShow.dart';
import 'package:naruci_ba_mobile/CustomTypes/PodkategorijaForShow.dart';
import 'package:naruci_ba_mobile/models/Kategorija.dart';
import 'package:naruci_ba_mobile/models/Podkategorija.dart';
import 'package:naruci_ba_mobile/models/Poslovnica.dart';
import 'package:naruci_ba_mobile/models/PoslovnicaKategorija.dart';
import 'package:naruci_ba_mobile/models/Proizvod.dart';
import 'package:naruci_ba_mobile/providers/kategorijaProvider.dart';
import 'package:naruci_ba_mobile/providers/podkategorijaProvider.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaKategorijaProvider.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaProvider.dart';
import 'package:naruci_ba_mobile/providers/proizvodProvider.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';
import 'package:naruci_ba_mobile/widgets/poslovnica/kategorijaDropdown.dart';
import 'package:provider/src/provider.dart';
import 'package:sliding_up_panel/sliding_up_panel.dart';

class PoslovnicaScreen extends StatefulWidget {
  static String routeName = "poslovnica";
  final String poslovnicaId;

  const PoslovnicaScreen({Key? key, required this.poslovnicaId})
      : super(key: key);

  @override
  _PoslovnicaState createState() => _PoslovnicaState();
}

class _PoslovnicaState extends State<PoslovnicaScreen> {
  bool init = true;
  late PoslovnicaProvider _poslovnicaProvider;
  late PodkategorijaProvider _podkategorijaProvider;
  late KategorijaProvider _kategorijaProvider;
  late ProizvodProvider _proizvodProvider;
  Poslovnica? poslovnica;
  List<Proizvod> proizvodi = List.empty();

  List<Podkategorija> podkategorijeUPoslovnici = List.empty();
  List<Kategorija> kategorijeUPoslovnici = List.empty();

  List<KateogrijaForShow> formatedKategorije = List.empty();

  void initComponent(String poslovnicaID) async {
    poslovnica = await _poslovnicaProvider.getById(id: poslovnicaID);
    proizvodi = await _proizvodProvider
        .get(searchParams: {"PoslovnicaID": poslovnica!.poslovnicaID});
    await setProizvodi();
  }

  @override
  void initState() {
    _poslovnicaProvider = context.read<PoslovnicaProvider>();
    _podkategorijaProvider = context.read<PodkategorijaProvider>();
    _kategorijaProvider = context.read<KategorijaProvider>();
    _proizvodProvider = context.read<ProizvodProvider>();
    initComponent(widget.poslovnicaId);
    super.initState();
  }

  Future setProizvodi() async {
    if (!init) {
      List<int> podkategorije = List.empty();
      proizvodi.forEach((proizvod) {
        podkategorije = [...podkategorije, proizvod.podkategorijaID!];
      });
      podkategorije = podkategorije.toSet().toList();

      await Future.forEach(podkategorije, (podkategorijaID) async {
        Podkategorija podkat =
            await _podkategorijaProvider.getById(id: podkategorijaID);
        podkategorijeUPoslovnici = [...podkategorijeUPoslovnici, podkat];
      });

      List<int> kategorije = List.empty();
      podkategorijeUPoslovnici.forEach((podkategorija) {
        kategorije = [...kategorije, podkategorija.kategorijaID];
      });
      kategorije = kategorije.toSet().toList();

      await Future.forEach(kategorije, (kategorijaID) async {
        Kategorija kat = await _kategorijaProvider.getById(id: kategorijaID);
        kategorijeUPoslovnici = [...kategorijeUPoslovnici, kat];
      });

      kategorijeUPoslovnici.forEach((kategorija) {
        var podkategorije = podkategorijeUPoslovnici
            .where((podkat) => podkat.kategorijaID == kategorija.kategorijaID);
        List<PodkategorijaForShow> formatedPodKategorije = List.empty();

        podkategorije.forEach((podkategorija) {
          var prods = proizvodi
              .where((proizvod) =>
                  proizvod.podkategorijaID == podkategorija.podkategorijaID)
              .toList();
          formatedPodKategorije = [
            ...formatedPodKategorije,
            PodkategorijaForShow(
                podkategorija.podkategorijaID, podkategorija.naziv, prods)
          ];
        });

        formatedKategorije = [
          ...formatedKategorije,
          KateogrijaForShow(
              kategorija.naziv, kategorija.kategorijaID, formatedPodKategorije)
        ];
      });
    }
    setState(() {
      init = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    poslovnica == null ? initComponent(widget.poslovnicaId) : null;
    return MainTemplate(
        child: SlidingUpPanel(
      defaultPanelState: PanelState.CLOSED,
      borderRadius: BorderRadius.only(
          topLeft: Radius.circular(30), topRight: Radius.circular(30)),
      minHeight: MediaQuery.of(context).size.height / 5 * 3,
      maxHeight: MediaQuery.of(context).size.height,
      padding: EdgeInsets.fromLTRB(20, 20, 20, 0),
      body: Container(
        child: Text(poslovnica != null ? poslovnica!.adresa : ""),
      ),
      panel: Container(
        child: Padding(
          padding: const EdgeInsets.fromLTRB(5, 10, 5, 0),
          child: Column(
            children: [
              Container(
                height: 4,
                width: 60,
                decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(30),
                    color: Color.fromARGB(200, 64, 64, 64)),
              ),
              SizedBox(
                height: 20,
              ),
              ...formatedKategorije.map<Widget>((kategorija) {
                return (KategorijaDropdown(
                  kategorija: kategorija,
                ));
              })
            ],
          ),
        ),
      ),
    ));
  }
}
