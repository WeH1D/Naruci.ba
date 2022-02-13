import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/screens/poslovnica_screen.dart';

class PoslovnicaCard extends StatefulWidget {
  final String poslovnicaId;
  final String nazivPoslovnice;
  final String adresaPoslovnice;
  const PoslovnicaCard(
      {Key? key,
      required this.poslovnicaId,
      required this.nazivPoslovnice,
      required this.adresaPoslovnice})
      : super(key: key);

  @override
  _PoslovnicaCardState createState() => _PoslovnicaCardState();
}

class _PoslovnicaCardState extends State<PoslovnicaCard> {
  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: () {
        Navigator.pushNamed(
          context,
          PoslovnicaScreen.routeName,
          arguments: PoslovnicaScreenArguments(
            widget.poslovnicaId,
          ),
        );
      },
      child: Card(
        shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(30)),
        elevation: 20,
        child: ClipPath(
          clipper: ShapeBorderClipper(
            shape:
                RoundedRectangleBorder(borderRadius: BorderRadius.circular(30)),
          ),
          child: SizedBox(
            height: 200,
            width: MediaQuery.of(context).size.width,
            child: Column(children: [
              Container(
                color: Color.fromARGB(255, 255, 255, 255),
                height: 130,
                child: Image(
                  image: AssetImage("assets/images/bingo.jpg"),
                  fit: BoxFit.fitWidth,
                ),
              ),
              Divider(
                thickness: 1,
                color: Color.fromARGB(200, 64, 64, 64),
              ),
              Padding(
                padding: const EdgeInsets.fromLTRB(23, 5, 23, 0),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          widget.nazivPoslovnice,
                          style: TextStyle(
                            fontWeight: FontWeight.bold,
                            color: Color.fromARGB(255, 64, 64, 64),
                            fontSize: 18,
                          ),
                        ),
                        Text(
                          widget.adresaPoslovnice,
                          style: TextStyle(
                            fontWeight: FontWeight.normal,
                            color: Color.fromARGB(255, 64, 64, 64),
                            fontSize: 13,
                          ),
                        ),
                      ],
                    ),
                    Text(
                      "4.3/5.0",
                      style: TextStyle(
                        fontWeight: FontWeight.bold,
                        color: Color.fromARGB(255, 64, 64, 64),
                        fontSize: 18,
                      ),
                    )
                  ],
                ),
              )
            ]),
          ),
        ),
      ),
    );
  }
}
