import 'package:flutter/gestures.dart';
import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/models/Dostavljac.dart';
import 'package:naruci_ba_mobile/models/Klijent.dart';
import 'package:naruci_ba_mobile/models/Korisnik.dart';
import 'package:naruci_ba_mobile/providers/KlijentProvider.dart';
import 'package:naruci_ba_mobile/providers/authentification_provider.dart';
import 'package:naruci_ba_mobile/providers/dostavljacProvider.dart';
import 'package:naruci_ba_mobile/providers/korisnikPorvider.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaProvider.dart';
import 'package:naruci_ba_mobile/screens/home_screen.dart';
import 'package:naruci_ba_mobile/screens/home_screen_dostavljac.dart';
import 'package:naruci_ba_mobile/screens/register_screen.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';
import 'package:naruci_ba_mobile/widgets/logo.dart';
import 'package:provider/src/provider.dart';

class LoginScreen extends StatefulWidget {
  static String routeName = "login";

  const LoginScreen({Key? key}) : super(key: key);

  @override
  _LoginScreenState createState() => _LoginScreenState();
}

class _LoginScreenState extends State<LoginScreen> {
  late AuthentificationProvider _authentication;
  late KorisnikProvider _korisnik;
  late KlijentProvider _klijent;
  late DostavljacProvider _dostavljac;
  TextEditingController usernameController = TextEditingController();
  TextEditingController passwordController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _authentication = context.read<AuthentificationProvider>();
    _korisnik = context.read<KorisnikProvider>();
    _klijent = context.read<KlijentProvider>();
    _dostavljac = context.read<DostavljacProvider>();
  }

  Future<void> login() async {
    bool login = await _authentication.login(
        usernameController.text, passwordController.text);
    if (login) {
      List<Korisnik> korisnik =
          await _korisnik.get(searchParams: {"Email": usernameController.text});
      _korisnik.korisnikID = korisnik.first.korisnikID;
      _korisnik.email = _korisnik.email;
      _korisnik.imePrezime = _korisnik.imePrezime;
      List<Klijent> klijent = await _klijent
          .get(searchParams: {"KorisnikID": korisnik.first.korisnikID});
      List<Dostavljac> dostavljac = await _dostavljac
          .get(searchParams: {"KorisnikID": korisnik.first.korisnikID});
      if (klijent.isNotEmpty) {
        _klijent.klijendID = klijent.first.klijentID;
        Navigator.push(
          context,
          MaterialPageRoute(
            builder: (context) => HomeScreen(),
          ),
        );
      } else if (dostavljac.isNotEmpty) {
        _dostavljac.dostavljacID = dostavljac.first.dostavljacID;
        Navigator.push(
          context,
          MaterialPageRoute(
            builder: (context) => HomeScreenDostavljac(),
          ),
        );
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    return Center(
      child: Padding(
        padding: EdgeInsets.fromLTRB(50, 0, 50, 0),
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Logo(),
            SizedBox(
              height: 40,
            ),
            TextField(
              controller: usernameController,
              decoration: InputDecoration(
                  hintText: "Email address",
                  border: OutlineInputBorder(
                      borderRadius: BorderRadius.all(Radius.circular(10))),
                  contentPadding: EdgeInsets.all(10),
                  hintStyle: TextStyle(color: Color.fromARGB(120, 64, 64, 64))),
            ),
            SizedBox(
              height: 10,
            ),
            TextField(
              controller: passwordController,
              decoration: InputDecoration(
                  hintText: "Password",
                  border: OutlineInputBorder(
                      borderRadius: BorderRadius.all(Radius.circular(10))),
                  contentPadding: EdgeInsets.all(10),
                  hintStyle: TextStyle(color: Color.fromARGB(120, 64, 64, 64))),
            ),
            SizedBox(
              height: 20,
            ),
            ElevatedButton(
                onPressed: () => login(),
                child: Text(
                  "Login",
                  style: TextStyle(fontWeight: FontWeight.bold),
                ),
                style: ElevatedButton.styleFrom(
                    fixedSize: Size(MediaQuery.of(context).size.width, 40),
                    primary: Color.fromARGB(255, 255, 83, 73))),
            SizedBox(
              height: 20,
            ),
            Row(
              children: const [
                Expanded(
                    child: Divider(
                  thickness: 2,
                )),
                Text(
                  " OR ",
                  style: TextStyle(color: Color.fromARGB(255, 64, 64, 64)),
                ),
                Expanded(
                    child: Divider(
                  thickness: 2,
                )),
              ],
            ),
            SizedBox(
              height: 20,
            ),
            RichText(
                text: TextSpan(
                    text: "Not a user yet?",
                    style: TextStyle(color: Color.fromARGB(150, 64, 64, 64)),
                    children: [
                  TextSpan(
                      text: " Sign up here",
                      style: TextStyle(color: Color.fromARGB(255, 255, 83, 73)),
                      recognizer: TapGestureRecognizer()
                        ..onTap = () {
                          Navigator.push(
                            context,
                            MaterialPageRoute(
                              builder: (context) => RegisterScreen(),
                            ),
                          );
                        })
                ]))
          ],
        ),
      ),
    );
  }
}
