import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/models/NaruceniProizvod.dart';
import 'package:naruci_ba_mobile/models/Narudzba.dart';
import 'package:naruci_ba_mobile/models/Poslovnica.dart';
import 'package:naruci_ba_mobile/models/Proizvod.dart';
import 'package:naruci_ba_mobile/models/TrgovackiLanac.dart';
import 'package:naruci_ba_mobile/providers/NaruceniProizvod.dart';
import 'package:naruci_ba_mobile/providers/NarudzbaProvider.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaProvider.dart';
import 'package:naruci_ba_mobile/providers/proizvodProvider.dart';
import 'package:naruci_ba_mobile/providers/trgovackiLanacProvider.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';
import 'package:provider/src/provider.dart';

class NarudzbaInfoScreen extends StatefulWidget {
  const NarudzbaInfoScreen({Key? key, required this.narudzbaId})
      : super(key: key);
  final int narudzbaId;

  @override
  State<NarudzbaInfoScreen> createState() => _NarudzbaInfoScreenState();
}

class _NarudzbaInfoScreenState extends State<NarudzbaInfoScreen> {
  late NarudzbaProvider _narudzbaProvider;
  late PoslovnicaProvider _poslovnicaProvider;
  late TrgovackiLanacProvider _trgovackiLanacProvider;
  late NaruceniProizvodProvider _naruceniProizvodProvider;
  late ProizvodProvider _proizvodProvider;

  Narudzba? _narudzba;
  Poslovnica? _poslovnica;
  TrgovackiLanac? _trgovackiLanac;

  List<Proizvod> itemsInBasket = List.empty();
  List<NaruceniProizvod> proizvodiUNarudzbi = List.empty();

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _poslovnicaProvider = context.read<PoslovnicaProvider>();
    _narudzbaProvider = context.read<NarudzbaProvider>();
    _trgovackiLanacProvider = context.read<TrgovackiLanacProvider>();
    _naruceniProizvodProvider = context.read<NaruceniProizvodProvider>();
    _proizvodProvider = context.read<ProizvodProvider>();
    getNarudzbaInfo();
    setProizvodi();
  }

  void getNarudzbaInfo() async {
    Narudzba narudzba = await _narudzbaProvider.getById(id: widget.narudzbaId);
    Poslovnica poslovnica =
        await _poslovnicaProvider.getById(id: narudzba.poslovnicaID);
    TrgovackiLanac trgovackiLanac =
        await _trgovackiLanacProvider.getById(id: poslovnica.trgovackiLanacID);

    setState(() {
      _poslovnica = poslovnica;
      _trgovackiLanac = trgovackiLanac;
      _narudzba = narudzba;
    });
  }

  void setProizvodi() async {
    proizvodiUNarudzbi = await _naruceniProizvodProvider
        .get(searchParams: {"NarudzbaID": widget.narudzbaId});
    proizvodiUNarudzbi.forEach((prod) async {
      var temp = await _proizvodProvider.getById(id: prod.proizvodID);
      setState(() {
        itemsInBasket = [...itemsInBasket, temp];
      });
    });
  }

  @override
  Widget build(BuildContext context) {
    return MainTemplate(
        child: SingleChildScrollView(
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
          SizedBox(
            height: 20,
          ),
          ...itemsInBasket.map<Widget>((prod) {
            return Padding(
              padding: const EdgeInsets.fromLTRB(20, 5, 20, 5),
              child: Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  prod.slika != null
                      ? Image(
                          image:
                              Image.memory(Base64Decoder().convert(prod.slika!))
                                  .image,
                          height: 50,
                          width: 50,
                          fit: BoxFit.contain,
                        )
                      : Container(
                          height: 50,
                          width: 50,
                          color: Color.fromARGB(20, 0, 0, 0),
                          child: Text("x"),
                          alignment: Alignment.center,
                        ),
                  Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(
                        prod.naziv,
                        style: TextStyle(fontWeight: FontWeight.bold),
                      ),
                      Text(
                          "${proizvodiUNarudzbi.where((_prod) => _prod.proizvodID == prod.proizvodID).first.ukupnaCijena.toString()} KM"),
                    ],
                  ),
                  Row(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(
                        proizvodiUNarudzbi
                            .where(
                                (_prod) => _prod.proizvodID == prod.proizvodID)
                            .first
                            .kolicina
                            .toString(),
                        style: TextStyle(fontWeight: FontWeight.bold),
                      ),
                      SizedBox(
                        width: 10,
                      ),
                      prod.kg! ? Text("kg") : Text("kom"),
                      SizedBox(
                        width: 20,
                      ),
                    ],
                  ),
                ],
              ),
            );
          }),
        ],
      ),
    ));
  }
}
