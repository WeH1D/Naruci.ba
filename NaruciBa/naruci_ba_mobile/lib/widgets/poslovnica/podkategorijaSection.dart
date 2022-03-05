import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/CustomTypes/PodkategorijaForShow.dart';
import 'package:naruci_ba_mobile/widgets/poslovnica/PorizvodShowcase.dart';

class PodkategorijaSection extends StatefulWidget {
  final PodkategorijaForShow podkategorija;
  const PodkategorijaSection({Key? key, required this.podkategorija})
      : super(key: key);

  @override
  _PodkategorijaSectionState createState() => _PodkategorijaSectionState();
}

class _PodkategorijaSectionState extends State<PodkategorijaSection> {
  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        SizedBox(
          height: 5,
        ),
        Text(
          widget.podkategorija.podkategorijaNaziv,
          style: TextStyle(
            fontSize: 18,
          ),
        ),
        SizedBox(
          height: 5,
        ),
        ...widget.podkategorija.proizvodi.map<Widget>((proizvod) {
          return (ProizvodShowcase(
            proizvod: proizvod,
          ));
        })
      ],
    );
  }
}
