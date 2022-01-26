import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/widgets/poslovnica_card.dart';

class HomeScreen extends StatefulWidget {
  const HomeScreen({Key? key}) : super(key: key);

  @override
  _HomeScreenState createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
  @override
  Widget build(BuildContext context) {
    return Center(
        child: Padding(
      padding: const EdgeInsets.fromLTRB(25, 0, 25, 0),
      child: PoslovnicaCard(),
    ));
  }
}
