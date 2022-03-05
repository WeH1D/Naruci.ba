import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/models/Poslovnica.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaProvider.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';
import 'package:naruci_ba_mobile/widgets/filters_top_card.dart';
import 'package:naruci_ba_mobile/widgets/poslovnica/poslovnica_card.dart';
import 'package:provider/src/provider.dart';

class HomeScreen extends StatefulWidget {
  static String routeName = "home";
  const HomeScreen({Key? key}) : super(key: key);

  @override
  _HomeScreenState createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
  late PoslovnicaProvider _poslovnicaProvider;
  List<Poslovnica> _poslovnice = List.empty();

  @override
  void initState() {
    super.initState();
    _poslovnicaProvider = context.read<PoslovnicaProvider>();
    initComponent();
  }

  void initComponent() async {
    var poslovnice = await _poslovnicaProvider.get();
    setState(() {
      _poslovnice = poslovnice;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MainTemplate(
      child: Column(
        children: [
          FiltersTopCard(),
          Padding(
            padding: const EdgeInsets.fromLTRB(25, 10, 25, 0),
            child: Container(
              height: MediaQuery.of(context).size.height / 5 * 3,
              child: ListView(children: [
                ..._poslovnice.map<Widget>((poslovnica) {
                  return PoslovnicaCard(
                    poslovnicaId: poslovnica.poslovnicaID.toString(),
                    nazivPoslovnice: poslovnica.poslovnicaID.toString(),
                    adresaPoslovnice: poslovnica.adresa,
                  );
                })
              ]),
            ),
          ),
        ],
      ),
    );
  }
}
