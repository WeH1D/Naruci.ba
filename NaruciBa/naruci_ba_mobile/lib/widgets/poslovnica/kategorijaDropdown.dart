import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/CustomTypes/KategorijaForShow.dart';
import 'package:naruci_ba_mobile/widgets/poslovnica/podkategorijaSection.dart';

class KategorijaDropdown extends StatefulWidget {
  final KateogrijaForShow kategorija;
  const KategorijaDropdown({Key? key, required this.kategorija})
      : super(key: key);

  @override
  _KategorijaDropdownState createState() => _KategorijaDropdownState();
}

class _KategorijaDropdownState extends State<KategorijaDropdown> {
  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        ElevatedButton(
          style: ElevatedButton.styleFrom(
            minimumSize: Size(MediaQuery.of(context).size.width, 35),
            maximumSize: Size(MediaQuery.of(context).size.width, 35),
            primary: Color.fromARGB(255, 255, 255, 255),
            elevation: 0,
            alignment: Alignment.centerLeft,
            padding: EdgeInsets.all(0),
          ),
          onPressed: () {
            setState(() {
              widget.kategorija.isOpen = !widget.kategorija.isOpen;
            });
          },
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Text(
                widget.kategorija.kateogrijaNaziv,
                style: TextStyle(
                  color: Color.fromARGB(255, 0, 0, 0),
                  fontSize: 20,
                ),
              ),
              widget.kategorija.isOpen
                  ? Icon(
                      Icons.arrow_drop_down,
                      color: Color.fromARGB(255, 0, 0, 0),
                    )
                  : Icon(
                      Icons.arrow_drop_up,
                      color: Color.fromARGB(255, 0, 0, 0),
                    )
            ],
          ),
        ),
        Container(
          color: Color.fromARGB(100, 0, 0, 0),
          height: 1,
        ),
        Visibility(
            visible: widget.kategorija.isOpen,
            child: Column(
              children: [
                ...widget.kategorija.podkategorije.map<Widget>((podkategorija) {
                  return (PodkategorijaSection(
                    podkategorija: podkategorija,
                  ));
                })
              ],
            )),
      ],
    );
  }
}
