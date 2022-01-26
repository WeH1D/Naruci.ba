import 'package:flutter/material.dart';

class PoslovnicaCard extends StatefulWidget {
  const PoslovnicaCard({Key? key}) : super(key: key);

  @override
  _PoslovnicaCardState createState() => _PoslovnicaCardState();
}

class _PoslovnicaCardState extends State<PoslovnicaCard> {
  @override
  Widget build(BuildContext context) {
    return Card(
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
                        "Ime poslovnice",
                        style: TextStyle(
                          fontWeight: FontWeight.bold,
                          color: Color.fromARGB(255, 64, 64, 64),
                          fontSize: 18,
                        ),
                      ),
                      Text(
                        "Adresa poslovnice bb",
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
    );
  }
}
