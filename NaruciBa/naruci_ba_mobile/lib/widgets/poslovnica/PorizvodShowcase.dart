import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/models/Proizvod.dart';

class ProizvodShowcase extends StatefulWidget {
  final Proizvod proizvod;
  const ProizvodShowcase({Key? key, required this.proizvod}) : super(key: key);

  @override
  _ProizvodShowcaseState createState() => _ProizvodShowcaseState();
}

class _ProizvodShowcaseState extends State<ProizvodShowcase> {
  @override
  Widget build(BuildContext context) {
    return Row(
      mainAxisAlignment: MainAxisAlignment.spaceBetween,
      children: [
        widget.proizvod.slika != null
            ? Image(
                image: Image.memory(
                        Base64Decoder().convert(widget.proizvod.slika!))
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
            Text(widget.proizvod.naziv),
            Text(widget.proizvod.opis),
          ],
        ),
        Text("${widget.proizvod.cijena.toString()} KM"),
        Icon(Icons.add_circle_outline),
      ],
    );
  }
}
