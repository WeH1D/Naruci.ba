import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/models/Poslovnica.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaProvider.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';
import 'package:provider/src/provider.dart';
import 'package:sliding_up_panel/sliding_up_panel.dart';

class PoslovnicaScreenArguments {
  final String poslovnicaID;

  PoslovnicaScreenArguments(this.poslovnicaID);
}

class PoslovnicaScreen extends StatefulWidget {
  static String routeName = "poslovnica";

  const PoslovnicaScreen({Key? key}) : super(key: key);

  @override
  _PoslovnicaState createState() => _PoslovnicaState();
}

class _PoslovnicaState extends State<PoslovnicaScreen> {
  late PoslovnicaProvider _poslovnicaProvider;
  late String poslovnicaId;
  Poslovnica? poslovnica;

  void initComponent(String poslovnicaID) async {
    poslovnica = await _poslovnicaProvider.getById(id: poslovnicaID);
    print(poslovnica);
    setState(() {});
  }

  @override
  void initState() {
    super.initState();
    _poslovnicaProvider = context.read<PoslovnicaProvider>();
  }

  @override
  Widget build(BuildContext context) {
    final args =
        ModalRoute.of(context)!.settings.arguments as PoslovnicaScreenArguments;
    poslovnica == null ? initComponent(args.poslovnicaID) : null;
    return MainTemplate(
        child: SlidingUpPanel(
      defaultPanelState: PanelState.CLOSED,
      borderRadius: BorderRadius.only(
          topLeft: Radius.circular(30), topRight: Radius.circular(30)),
      minHeight: MediaQuery.of(context).size.height / 5 * 3,
      maxHeight: MediaQuery.of(context).size.height,
      padding: EdgeInsets.fromLTRB(20, 20, 20, 0),
      body: Container(
        child: Text(poslovnica != null ? poslovnica!.adresa : ""),
      ),
      panel: Container(
        child: Column(
          children: [
            Container(
              height: 4,
              width: 60,
              decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(30),
                  color: Color.fromARGB(200, 64, 64, 64)),
            )
          ],
        ),
      ),
    ));
  }
}
