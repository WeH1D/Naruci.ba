import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:naruci_ba_mobile/models/Klijent.dart';
import 'package:naruci_ba_mobile/models/NaruceniProizvod.dart';
import 'package:naruci_ba_mobile/models/Narudzba.dart';
import 'package:naruci_ba_mobile/models/Proizvod.dart';
import 'package:naruci_ba_mobile/providers/KlijentProvider.dart';
import 'package:naruci_ba_mobile/providers/NaruceniProizvod.dart';
import 'package:naruci_ba_mobile/providers/NarudzbaProvider.dart';
import 'package:naruci_ba_mobile/providers/korisnikPorvider.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';
import 'package:provider/src/provider.dart';
import 'package:sliding_up_panel/sliding_up_panel.dart';

class Basket extends StatefulWidget {
  const Basket({Key? key}) : super(key: key);

  @override
  State<Basket> createState() => _Basket();
}

class _Basket extends State<Basket> {
  late NarudzbaProvider _narudzbaProvider;
  late KorisnikProvider _korisnikProvider;
  late KlijentProvider _klijenProvider;
  late NaruceniProizvodProvider _naruceniProizvodProvider;

  List<NaruceniProizvod> itemsInBasket = List.empty();

  Narudzba? _myBasket;

  @override
  void initState() {
    super.initState();
    _narudzbaProvider = context.read<NarudzbaProvider>();
    _korisnikProvider = context.read<KorisnikProvider>();
    _klijenProvider = context.read<KlijentProvider>();
    _naruceniProizvodProvider = context.read<NaruceniProizvodProvider>();
    fetchBasket();
  }

  void fetchBasket() async {
    List<Narudzba> basket = await _narudzbaProvider
        .get(searchParams: {"KlijentID": _klijenProvider.klijendID});
    if (basket.isNotEmpty) {
      _myBasket = basket.first;
      await fetchProizvodiFromBasket();
    }
  }

  Future<void> fetchProizvodiFromBasket() async {
    var proizvodi = await _naruceniProizvodProvider
        .get(searchParams: {"NarudzbaID": _myBasket!.narudzbaID});
    setState(() {
      itemsInBasket = proizvodi;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MainTemplate(
        child: SingleChildScrollView(
      child: Center(
        child: Column(children: [
          ...itemsInBasket.map<Widget>((prod) {
            return Text("${prod.naruceniProizvodID}");
          })
        ]),
      ),
    ));
  }
}
