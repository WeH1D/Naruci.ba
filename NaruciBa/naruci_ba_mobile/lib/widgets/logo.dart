import 'package:flutter/material.dart';

class Logo extends StatefulWidget {
  const Logo({Key? key, this.height = 80}) : super(key: key);
  final double height;
  @override
  _LogoState createState() => _LogoState();
}

class _LogoState extends State<Logo> {
  @override
  Widget build(BuildContext context) {
    return Container(
      height: widget.height,
      alignment: Alignment.center,
      child: Row(
        mainAxisAlignment: MainAxisAlignment.center,
        children: const [
          Image(image: AssetImage("assets/images/shopping-bag.png")),
          SizedBox(
            width: 10,
          ),
          Text(
            "Naruci.ba",
            style: TextStyle(
                color: Color.fromARGB(255, 64, 64, 64),
                fontWeight: FontWeight.bold,
                fontSize: 30),
          ),
        ],
      ),
    );
  }
}
