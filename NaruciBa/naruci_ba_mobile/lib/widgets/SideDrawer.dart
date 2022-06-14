import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/screens/basket_screen.dart';
import 'package:naruci_ba_mobile/screens/home_screen.dart';
import 'package:naruci_ba_mobile/screens/mojeNarudzbe.dart';

class SideDrawer extends StatefulWidget {
  const SideDrawer({Key? key}) : super(key: key);
  @override
  _SideDrawerState createState() => _SideDrawerState();
}

class _SideDrawerState extends State<SideDrawer> {
  void goToMojeNarudzbe() {
    Navigator.push(
      context,
      MaterialPageRoute(
        builder: (context) => MojeNarudzbe(),
      ),
    );
  }

  void goToHomeScreen() {
    Navigator.push(
      context,
      MaterialPageRoute(
        builder: (context) => HomeScreen(),
      ),
    );
  }

  void goToMojaKorpa() {
    Navigator.push(
      context,
      MaterialPageRoute(
        builder: (context) => Basket(),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Drawer(
        child: Padding(
      padding: const EdgeInsets.fromLTRB(30, 0, 30, 0),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          SizedBox(
            height: 100,
          ),
          Row(
            children: [
              Container(
                height: 80,
                width: 80,
                decoration: BoxDecoration(
                    color: Colors.grey,
                    borderRadius: BorderRadius.circular(50)),
              ),
              Padding(
                padding: const EdgeInsets.fromLTRB(10, 0, 10, 0),
                child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: const [
                      Text("Ime i prezime"),
                      Text("ime@gmail.com"),
                    ]),
              ),
            ],
          ),
          SizedBox(
            height: 50,
          ),
          GestureDetector(
              child: Text("Pocetni ekran"), onTap: () => {goToHomeScreen()}),
          SizedBox(
            height: 25,
          ),
          GestureDetector(
              child: Text("Moje narudzbe"), onTap: () => {goToMojeNarudzbe()}),
          SizedBox(
            height: 25,
          ),
          GestureDetector(
              child: Text("Moja korpa"), onTap: () => {goToMojaKorpa()}),
          SizedBox(
            height: 25,
          ),
          GestureDetector(child: Text("Moje informacije"), onTap: () => {}),
          SizedBox(
            height: 25,
          ),
          GestureDetector(child: Text("Kuponi"), onTap: () => {}),
          SizedBox(
            height: 25,
          ),
          GestureDetector(child: Text("Notifikacije"), onTap: () => {}),
          SizedBox(
            height: 25,
          ),
          GestureDetector(child: Text("Metode placanja"), onTap: () => {}),
          SizedBox(
            height: 25,
          ),
          GestureDetector(child: Text("O nama"), onTap: () => {}),
          SizedBox(
            height: 50,
          ),
          ElevatedButton(
              onPressed: () => {},
              child: Text(
                "Odjava",
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
    ));
  }
}
