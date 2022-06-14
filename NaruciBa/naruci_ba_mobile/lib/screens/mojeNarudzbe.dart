import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';

class MojeNarudzbe extends StatefulWidget {
  const MojeNarudzbe({Key? key}) : super(key: key);

  @override
  State<MojeNarudzbe> createState() => _MojeNarudzbeState();
}

class _MojeNarudzbeState extends State<MojeNarudzbe> {
  @override
  Widget build(BuildContext context) {
    return MainTemplate(
      child: Text("Moje narudzbe"),
    );
  }
}
