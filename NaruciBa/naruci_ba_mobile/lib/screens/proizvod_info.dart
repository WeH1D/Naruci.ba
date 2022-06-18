import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:naruci_ba_mobile/models/NaruceniProizvod.dart';
import 'package:naruci_ba_mobile/models/Narudzba.dart';
import 'package:naruci_ba_mobile/models/Poslovnica.dart';
import 'package:naruci_ba_mobile/models/Proizvod.dart';
import 'package:naruci_ba_mobile/providers/KlijentProvider.dart';
import 'package:naruci_ba_mobile/providers/NaruceniProizvod.dart';
import 'package:naruci_ba_mobile/providers/NarudzbaProvider.dart';
import 'package:naruci_ba_mobile/screens/basket_screen.dart';
import 'package:naruci_ba_mobile/screens/poslovnica_screen.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';
import 'package:provider/src/provider.dart';
import 'package:sliding_up_panel/sliding_up_panel.dart';

class ProizvodInfo extends StatefulWidget {
  final Proizvod proizvod;
  final bool navigateToBasket;

  const ProizvodInfo(
      {Key? key, required this.proizvod, required this.navigateToBasket})
      : super(key: key);

  @override
  State<ProizvodInfo> createState() => _ProizvodInfoState();
}

class _ProizvodInfoState extends State<ProizvodInfo> {
  late NarudzbaProvider _narudzbaProvider;
  late NaruceniProizvodProvider _naruceniProizvodProvider;
  late KlijentProvider _klijenProvider;
  double ukupnaCijena = 0;
  double _kolicina = 0;

  @override
  void initState() {
    super.initState();
    _naruceniProizvodProvider = context.read<NaruceniProizvodProvider>();
    _narudzbaProvider = context.read<NarudzbaProvider>();
    _klijenProvider = context.read<KlijentProvider>();
  }

  void addToBasket() async {
    List<Narudzba> basket = await _narudzbaProvider.get(searchParams: {
      "KlijentID": _klijenProvider.klijendID,
      "NarudzbaStatusID": 1
    });

    List<NaruceniProizvod> proizvodiUKorpi = await _naruceniProizvodProvider
        .get(searchParams: {"NarudzbaID": basket.first.narudzbaID});

    // Da li basket pripada ovoj poslovnici, ako NE, izbrisi proizvode i updateaj basket, ako DA dodaj proizvod
    if (basket.first.poslovnicaID == null ||
        basket.first.poslovnicaID == widget.proizvod.poslovnicaID) {
      Iterable<NaruceniProizvod> postojeciProizvod = proizvodiUKorpi
          .where((prod) => prod.proizvodID == widget.proizvod.proizvodID);

      if (basket.first.poslovnicaID == null) {
        await _narudzbaProvider.put(
            id: basket.first.narudzbaID,
            request: {"PoslovnicaID": widget.proizvod.poslovnicaID});
      }
      if (postojeciProizvod.isEmpty) {
        NaruceniProizvod naruceniProd =
            await _naruceniProizvodProvider.post(request: {
          "proizvodID": widget.proizvod.proizvodID,
          "narudzbaID": basket.first.narudzbaID,
          "kolicina": _kolicina,
          "ukupnaCijena": ukupnaCijena
        });
        print("Proizvod dodan u korpu");
        navigateNext();
      } else {
        NaruceniProizvod naruceniProd = await _naruceniProizvodProvider.put(
            id: proizvodiUKorpi
                .where((prod) => prod.proizvodID == widget.proizvod.proizvodID)
                .first
                .naruceniProizvodID,
            request: {"kolicina": _kolicina, "ukupnaCijena": ukupnaCijena});
        print("Updatean postojeci proizvod u korpi");
        navigateNext();
      }
    } else {
      bool action = await showDialog(
          context: context,
          builder: (context) {
            return AlertDialog(
              title: Text(
                "Dodajete proizvod iz poslovnice koja se ne podudara sa poslovnicom vase trenutne korpe. Ukoliko nastavite, postojeci proizvodi ce biti izbrisani iz korpe. Da li zelite nastaviti?",
              ),
              actions: [
                ElevatedButton(
                    onPressed: () => {
                          Navigator.pop(context, true),
                        },
                    child: Text("Da")),
                ElevatedButton(
                    onPressed: () => {
                          Navigator.pop(context, false),
                        },
                    child: Text("Ne"))
              ],
            );
          });
      if (action) {
        proizvodiUKorpi.forEach((prod) async {
          await _naruceniProizvodProvider.delete(id: prod.naruceniProizvodID);
        });
        await _narudzbaProvider.put(
            id: basket.first.narudzbaID,
            request: {"PoslovnicaID": widget.proizvod.poslovnicaID});
        NaruceniProizvod naruceniProd =
            await _naruceniProizvodProvider.post(request: {
          "proizvodID": widget.proizvod.proizvodID,
          "narudzbaID": basket.first.narudzbaID,
          "kolicina": _kolicina,
          "ukupnaCijena": ukupnaCijena
        });
        print("Proizvod dodan u korpu");
        navigateNext();
      }
    }
  }

  void navigateNext() {
    if (widget.navigateToBasket) {
      Navigator.pushReplacement(
        context,
        MaterialPageRoute(builder: (context) => Basket()),
      );
    } else {
      Navigator.pop(context);
    }
  }

  @override
  Widget build(BuildContext context) {
    return MainTemplate(
        child: SlidingUpPanel(
      defaultPanelState: PanelState.CLOSED,
      borderRadius: BorderRadius.only(
          topLeft: Radius.circular(30), topRight: Radius.circular(30)),
      minHeight: MediaQuery.of(context).size.height / 5 * 3.1,
      maxHeight: MediaQuery.of(context).size.height / 5 * 3.1,
      padding: EdgeInsets.fromLTRB(20, 20, 20, 0),
      body: Column(
        children: [
          widget.proizvod.slika != null
              ? Image(
                  alignment: Alignment.topCenter,
                  image: Image.memory(
                          Base64Decoder().convert(widget.proizvod.slika!))
                      .image,
                  height: MediaQuery.of(context).size.height / 5 * 1.5,
                  width: MediaQuery.of(context).size.width,
                  fit: BoxFit.contain,
                )
              : Container(),
        ],
      ),
      panel: Container(
        child: Padding(
          padding: const EdgeInsets.fromLTRB(5, 10, 5, 0),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            children: [
              Text(
                widget.proizvod.naziv,
                style: TextStyle(fontSize: 30, fontWeight: FontWeight.bold),
              ),
              Text(
                widget.proizvod.opis,
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Text("Kolicina: "),
                  SizedBox(
                    width: 20,
                  ),
                  SizedBox(
                    width: 50,
                    child: TextField(
                      keyboardType: TextInputType.number,
                      onChanged: (kolicina) {
                        setState(() {
                          if (kolicina != null && kolicina != "") {
                            _kolicina = double.tryParse(kolicina)!;
                            ukupnaCijena = double.tryParse(kolicina)! *
                                widget.proizvod.cijena!;
                          } else {
                            ukupnaCijena = 0;
                          }
                        });
                      },
                      inputFormatters: [
                        widget.proizvod.kg!
                            ? FilteringTextInputFormatter.deny("")
                            : FilteringTextInputFormatter.digitsOnly
                      ],
                      textAlign: TextAlign.center,
                      decoration: InputDecoration(
                          hintText: "0",
                          border: OutlineInputBorder(
                              borderRadius:
                                  BorderRadius.all(Radius.circular(10))),
                          contentPadding: EdgeInsets.all(10),
                          hintStyle: TextStyle(
                              color: Color.fromARGB(120, 64, 64, 64))),
                    ),
                  ),
                  SizedBox(
                    width: 20,
                  ),
                  widget.proizvod.kg! ? Text("kg") : Text("komada")
                ],
              ),
              Text(
                "$ukupnaCijena KM",
                style: TextStyle(fontSize: 20, fontWeight: FontWeight.bold),
              ),
              ElevatedButton(
                  onPressed: () => {addToBasket()},
                  child: Text(
                    "Dodaj u korpu",
                    style: TextStyle(fontWeight: FontWeight.bold, fontSize: 18),
                  ),
                  style: ElevatedButton.styleFrom(
                    shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(30)),
                    fixedSize: Size(MediaQuery.of(context).size.width, 50),
                    primary: Color.fromARGB(255, 255, 83, 73),
                  )),
            ],
          ),
        ),
      ),
    ));
  }
}
