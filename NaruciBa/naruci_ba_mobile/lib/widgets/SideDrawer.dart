import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/models/Korisnik.dart';
import 'package:naruci_ba_mobile/providers/authentification_provider.dart';
import 'package:naruci_ba_mobile/providers/korisnikPorvider.dart';
import 'package:naruci_ba_mobile/screens/basket_screen.dart';
import 'package:naruci_ba_mobile/screens/home_screen.dart';
import 'package:naruci_ba_mobile/screens/home_screen_dostavljac.dart';
import 'package:naruci_ba_mobile/screens/login_screen.dart';
import 'package:naruci_ba_mobile/screens/mojeNarudzbe.dart';
import 'package:naruci_ba_mobile/screens/my_informations.dart';
import 'package:provider/src/provider.dart';

class SideDrawer extends StatefulWidget {
  const SideDrawer({Key? key}) : super(key: key);
  @override
  _SideDrawerState createState() => _SideDrawerState();
}

class _SideDrawerState extends State<SideDrawer> {
  late KorisnikProvider _korisnikProvider;
  late AuthentificationProvider _authentificationProvider;

  String? email;
  String? imePrezime;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _korisnikProvider = context.read<KorisnikProvider>();
    _authentificationProvider = context.read<AuthentificationProvider>();
    getKorisnik();
  }

  void getKorisnik() {
    setState(() {
      email = _korisnikProvider.email;
      imePrezime = _korisnikProvider.imePrezime;
    });
  }

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

  void goToMojeInformacije() {
    Navigator.push(
      context,
      MaterialPageRoute(
        builder: (context) => MyInformationsScreen(),
      ),
    );
  }

  void goToTrenutnaNarudzba() {
    Navigator.push(
      context,
      MaterialPageRoute(
        builder: (context) => MojeNarudzbe(),
      ),
    );
  }

  goToDostavljacHomeScreen() {
    Navigator.push(
      context,
      MaterialPageRoute(
        builder: (context) => HomeScreenDostavljac(),
      ),
    );
  }

  void odjava() {
    _authentificationProvider.logout();
    Navigator.pushAndRemoveUntil(
        context,
        MaterialPageRoute(
          builder: (context) => LoginScreen(),
        ),
        (Route<dynamic> route) => route is LoginScreen);
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
                    children: [
                      Text(imePrezime ?? " "),
                      SizedBox(
                        height: 10,
                      ),
                      Text(email ?? " "),
                    ]),
              ),
            ],
          ),
          SizedBox(
            height: 50,
          ),
          if (!_korisnikProvider.isDostavljac!)
            GestureDetector(
                child: Text("Pocetni ekran"), onTap: () => {goToHomeScreen()}),
          if (!_korisnikProvider.isDostavljac!)
            SizedBox(
              height: 25,
            ),
          GestureDetector(
              child: Text("Moje narudzbe"),
              onTap: () => {
                    if (_korisnikProvider.isDostavljac!)
                      {goToDostavljacHomeScreen()}
                    else
                      {goToMojeNarudzbe()}
                  }),
          SizedBox(
            height: 25,
          ),
          if (!_korisnikProvider.isDostavljac!)
            GestureDetector(
                child: Text("Moja korpa"), onTap: () => {goToMojaKorpa()}),
          if (!_korisnikProvider.isDostavljac!)
            SizedBox(
              height: 25,
            ),
          GestureDetector(
              child: Text("Moje informacije"),
              onTap: () => {goToMojeInformacije()}),
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
              onPressed: () => {odjava()},
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
