import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaProvider.dart';
import 'package:naruci_ba_mobile/screens/home_screen.dart';
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
  void login() {
    Navigator.push(
      context,
      MaterialPageRoute(
        builder: (context) => HomeScreen(),
      ),
    );
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
                    children: const [
                  TextSpan(
                      text: " Sign up here",
                      style: TextStyle(color: Color.fromARGB(255, 255, 83, 73)))
                ]))
          ],
        ),
      ),
    );
  }
}
