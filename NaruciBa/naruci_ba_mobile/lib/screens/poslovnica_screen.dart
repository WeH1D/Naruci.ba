import 'package:flutter/material.dart';
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
  late PoslovnicaProvider _poslovnicaProvider;
  late PodkategorijaProvider _podkategorijaProvider;
  late PoslovnicaKategorijaProvider _poslovnicaKategorijaProvider;
  late ProizvodProvider _proizvodProvider;
  Poslovnica? poslovnica;
  List<Podkategorija> podkategorije = List.empty();
  List<PoslovnicaKategorija> kategorije = List.empty();
  List<Proizvod> proizvodi = List.empty();

  void initComponent(String poslovnicaID) async {
    poslovnica = await _poslovnicaProvider.getById(id: poslovnicaID);
    podkategorije = await _podkategorijaProvider.get();
    proizvodi = await _proizvodProvider
        .get(searchParams: {"PoslovnicaID": poslovnica!.poslovnicaID});
    kategorije = await _poslovnicaKategorijaProvider
        .get(searchParams: {"PoslovnicaID": poslovnica!.poslovnicaID});
    await setProizvodi();
    setState(() {});
  }

  @override
  void initState() {
    super.initState();
    _poslovnicaProvider = context.read<PoslovnicaProvider>();
    _podkategorijaProvider = context.read<PodkategorijaProvider>();
    _poslovnicaKategorijaProvider =
        context.read<PoslovnicaKategorijaProvider>();
    _proizvodProvider = context.read<ProizvodProvider>();
    initComponent(widget.poslovnicaId);
  }

  Future setProizvodi() async {}

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
              ...kategorije.map<Widget>((podkategorija) {
                return (ElevatedButton(
                    child: Text(podkategorija.kategorijaID.toString()),
                    style: ElevatedButton.styleFrom(
                        fixedSize: Size(MediaQuery.of(context).size.width, 20)),
                    onPressed: () => {}));
              })
            ],
          ),
        ),
      ),
    ));
  }
}
