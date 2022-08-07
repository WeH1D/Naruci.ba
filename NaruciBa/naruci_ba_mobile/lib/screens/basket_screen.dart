import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:modal_progress_hud/modal_progress_hud.dart';
import 'package:naruci_ba_mobile/models/Klijent.dart';
import 'package:naruci_ba_mobile/models/NaruceniProizvod.dart';
import 'package:naruci_ba_mobile/models/Narudzba.dart';
import 'package:naruci_ba_mobile/models/Poslovnica.dart';
import 'package:naruci_ba_mobile/models/Proizvod.dart';
import 'package:naruci_ba_mobile/models/TrgovackiLanac.dart';
import 'package:naruci_ba_mobile/models/app_config.dart';
import 'package:naruci_ba_mobile/providers/KlijentProvider.dart';
import 'package:naruci_ba_mobile/providers/NaruceniProizvod.dart';
import 'package:naruci_ba_mobile/providers/NarudzbaProvider.dart';
import 'package:naruci_ba_mobile/providers/app_config_provider.dart';
import 'package:naruci_ba_mobile/providers/korisnikPorvider.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaProvider.dart';
import 'package:naruci_ba_mobile/providers/proizvodProvider.dart';
import 'package:naruci_ba_mobile/providers/trgovackiLanacProvider.dart';
import 'package:naruci_ba_mobile/screens/mojeNarudzbe.dart';
import 'package:naruci_ba_mobile/screens/placanje_screen.dart';
import 'package:naruci_ba_mobile/screens/proizvod_info.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';
import 'package:naruci_ba_mobile/widgets/poslovnica/PorizvodShowcase.dart';
import 'package:provider/src/provider.dart';
import 'package:signalr_netcore/hub_connection.dart';
import 'package:signalr_netcore/hub_connection_builder.dart';
import 'package:sliding_up_panel/sliding_up_panel.dart';

class Basket extends StatefulWidget {
  const Basket({Key? key}) : super(key: key);

  @override
  State<Basket> createState() => _Basket();
}

class _Basket extends State<Basket> {
  late NarudzbaProvider _narudzbaProvider;
  late KorisnikProvider _korisnikProvider;
  late KlijentProvider _klijenProvider;
  late NaruceniProizvodProvider _naruceniProizvodProvider;
  late ProizvodProvider _proizvodProvider;
  late PoslovnicaProvider _poslovnicaProvider;
  late TrgovackiLanacProvider _trgovackiLanacProvider;
  late AppConfigProvider _configProvider;

  late AppConfigProvider provider =
      Provider.of<AppConfigProvider>(context, listen: false);

  List<Proizvod> itemsInBasket = List.empty();
  List<NaruceniProizvod> proizvodiUNarudzbi = List.empty();

  Narudzba? _myBasket;
  Poslovnica? _poslovnica;
  TrgovackiLanac? _trgovackiLanac;

  late HubConnection hubConnection;

  bool isLoading = true;
  @override
  void initState() {
    super.initState();
    isLoading = false;
    _narudzbaProvider = context.read<NarudzbaProvider>();
    _korisnikProvider = context.read<KorisnikProvider>();
    _klijenProvider = context.read<KlijentProvider>();
    _naruceniProizvodProvider = context.read<NaruceniProizvodProvider>();
    _proizvodProvider = context.read<ProizvodProvider>();
    _poslovnicaProvider = context.read<PoslovnicaProvider>();
    _trgovackiLanacProvider = context.read<TrgovackiLanacProvider>();
    _configProvider = context.read<AppConfigProvider>();
    setHub();

    fetchBasket();
  }

  Future<void> setHub() async {
    setState(() {
      isLoading = true;
    });
    var config = await getAppConfigProvider();
    hubConnection = HubConnectionBuilder()
        .withUrl(config.signalRHubEndpoint)
        .withAutomaticReconnect()
        .build();
    await hubConnection.start();
    setState(() {
      isLoading = false;
    });
  }

  Future<AppConfig> getAppConfigProvider() async {
    if (provider == null) {
      var config = Provider.of<AppConfigProvider>(context, listen: false);
      provider = config;
    }
    return await provider.getConfig();
  }

  void fetchBasket() async {
    setState(() {
      isLoading = true;
    });
    List<Narudzba> basket = await _narudzbaProvider.get(searchParams: {
      "KlijentID": _klijenProvider.klijendID,
      "NarudzbaStatusID": 1
    });
    if (basket.isNotEmpty) {
      _myBasket = basket.first;
      await fetchProizvodiFromBasket();
      await setBasketInfo();
    }
    setState(() {
      isLoading = false;
    });
  }

  Future<void> fetchProizvodiFromBasket() async {
    setState(() {
      isLoading = true;
    });
    itemsInBasket = List.empty();
    proizvodiUNarudzbi = await _naruceniProizvodProvider
        .get(searchParams: {"NarudzbaID": _myBasket!.narudzbaID});
    proizvodiUNarudzbi.forEach((prod) async {
      var temp = await _proizvodProvider.getById(id: prod.proizvodID);
      setState(() {
        itemsInBasket = [...itemsInBasket, temp];
      });
    });
    setState(() {
      isLoading = false;
    });
  }

  Future<void> setBasketInfo() async {
    setState(() {
      isLoading = true;
    });
    if (_myBasket!.poslovnicaID != null) {
      Poslovnica poslovnica =
          await _poslovnicaProvider.getById(id: _myBasket!.poslovnicaID);
      TrgovackiLanac trgovackiLanac = await _trgovackiLanacProvider.getById(
          id: poslovnica.trgovackiLanacID);
      setState(() {
        _poslovnica = poslovnica;
        _trgovackiLanac = trgovackiLanac;
      });
    }
    setState(() {
      isLoading = false;
    });
  }

  void goToProizvod(Proizvod prod) {
    Navigator.pushReplacement(
      context,
      MaterialPageRoute(
        builder: (context) =>
            ProizvodInfo(proizvod: prod, navigateToBasket: true),
      ),
    );
  }

  Future<void> deleteProizvod(NaruceniProizvod prod) async {
    bool action = await showDialog(
        context: context,
        builder: (context) {
          return AlertDialog(
            title: Text(
              "Da li ste sigurni da zelite izbrisati proizvod iz korpe?",
            ),
            actions: [
              ElevatedButton(
                  onPressed: () => {
                        Navigator.pop(context, true),
                      },
                  child: Text("Da")),
              ElevatedButton(
                  onPressed: () => {
                        Navigator.pop(context, false),
                      },
                  child: Text("Ne"))
            ],
          );
        });
    if (action == true) {
      await _naruceniProizvodProvider.delete(id: prod.naruceniProizvodID);
      fetchBasket();
    }
  }

  Future<void> naruci() async {
    String action = await showDialog(
        context: context,
        builder: (context) {
          return AlertDialog(
            title: Text(
              "Koju metodu placanja zelite koristiti?",
            ),
            actions: [
              ElevatedButton(
                  onPressed: () => {
                        Navigator.pop(context, "preuzece"),
                      },
                  child: Text("Placanje pri preuzimanju")),
              ElevatedButton(
                  onPressed: () => {
                        Navigator.pop(context, "paypal"),
                      },
                  child: Text("PayPal"))
            ],
          );
        });
    if (action == "preuzece") {
      narudzbaSuccess();
    } else if (action == "paypal") {
      Navigator.push(
        context,
        MaterialPageRoute(
          builder: (context) => PlacanjeScreen(
              onFinish: (id) => {narudzbaSuccess()},
              narudzba: _myBasket!,
              items: itemsInBasket,
              orderedItems: proizvodiUNarudzbi),
        ),
      );
    }
  }

  narudzbaSuccess() async {
    setState(() {
      isLoading = true;
    });
    try {
      await _narudzbaProvider.put(id: _myBasket!.narudzbaID, request: {
        "NarudzbaStatusID": 2,
        "Datum": DateTime.now().toIso8601String()
      });
      setState(() {
        isLoading = false;
      });

      final result = await hubConnection.invoke("NarudzbaUpdateovana");

      final snackBar = SnackBar(
        content: Text("Narudzba uspjesna"),
        duration: Duration(seconds: 10),
        action: SnackBarAction(
          label: 'Close',
          onPressed: () {
            // Some code to undo the change.
          },
        ),
      );
      ScaffoldMessenger.of(context).showSnackBar(snackBar);

      Navigator.pushReplacement(
        context,
        MaterialPageRoute(builder: (context) => MojeNarudzbe()),
      );
    } catch (e) {
      final snackBar = SnackBar(
        content: Text(e.toString()),
        duration: Duration(seconds: 10),
        action: SnackBarAction(
          label: 'Close',
          onPressed: () {
            // Some code to undo the change.
          },
        ),
      );
      ScaffoldMessenger.of(context).showSnackBar(snackBar);
    }
  }

  @override
  Widget build(BuildContext context) {
    return MainTemplate(
        child: ModalProgressHUD(
      inAsyncCall: isLoading,
      child: Padding(
        padding: const EdgeInsets.fromLTRB(30, 10, 30, 0),
        child: Column(
          mainAxisAlignment: MainAxisAlignment.spaceAround,
          children: [
            Column(children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: const [
                  Icon(
                    Icons.shopping_cart,
                    color: Color.fromARGB(255, 255, 83, 73),
                  ),
                  SizedBox(
                    width: 10,
                  ),
                  Text(
                    "Moja Korpa",
                    style: TextStyle(
                        fontSize: 30,
                        fontWeight: FontWeight.bold,
                        color: Color.fromARGB(255, 255, 83, 73)),
                  ),
                ],
              ),
              SizedBox(
                height: 20,
              ),
              Text(
                _trgovackiLanac?.naziv ?? "",
                style: TextStyle(fontSize: 20),
              ),
              Text(_poslovnica?.adresa ?? ""),
            ]),
            SingleChildScrollView(
              child: Center(
                child: Column(children: [
                  ...itemsInBasket.map<Widget>((prod) {
                    return Padding(
                      padding: const EdgeInsets.fromLTRB(0, 5, 0, 5),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          prod.slika != null
                              ? Image(
                                  image: Image.memory(
                                          Base64Decoder().convert(prod.slika!))
                                      .image,
                                  height: 50,
                                  width: 50,
                                  fit: BoxFit.contain,
                                )
                              : Container(
                                  height: 50,
                                  width: 50,
                                  color: Color.fromARGB(20, 0, 0, 0),
                                  child: Text("x"),
                                  alignment: Alignment.center,
                                ),
                          Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Text(
                                prod.naziv,
                                style: TextStyle(fontWeight: FontWeight.bold),
                              ),
                              Text(
                                  "${proizvodiUNarudzbi.where((_prod) => _prod.proizvodID == prod.proizvodID).first.ukupnaCijena.toString()} KM"),
                            ],
                          ),
                          Row(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Text(
                                proizvodiUNarudzbi
                                    .where((_prod) =>
                                        _prod.proizvodID == prod.proizvodID)
                                    .first
                                    .kolicina
                                    .toString(),
                                style: TextStyle(fontWeight: FontWeight.bold),
                              ),
                              SizedBox(
                                width: 10,
                              ),
                              prod.kg! ? Text("kg") : Text("kom"),
                              SizedBox(
                                width: 20,
                              ),
                              GestureDetector(
                                onTap: () => {goToProizvod(prod)},
                                child: Icon(
                                  Icons.edit,
                                  size: 20,
                                  color: Color.fromARGB(255, 255, 83, 73),
                                ),
                              ),
                              SizedBox(
                                width: 20,
                              ),
                              GestureDetector(
                                onTap: () => {
                                  deleteProizvod(proizvodiUNarudzbi
                                      .where((_prod) =>
                                          _prod.proizvodID == prod.proizvodID)
                                      .first)
                                },
                                child: Icon(
                                  Icons.delete,
                                  size: 20,
                                  color: Color.fromARGB(255, 255, 83, 73),
                                ),
                              ),
                            ],
                          ),
                        ],
                      ),
                    );
                  }),
                ]),
              ),
            ),
            Column(
              children: [
                Text(
                  "Ukupan iznos: ${_myBasket?.ukupanIznos ?? "0"} KM",
                  style: TextStyle(
                    fontSize: 20,
                    fontWeight: FontWeight.bold,
                  ),
                )
              ],
            ),
            ElevatedButton(
                onPressed: _myBasket != null && _myBasket!.poslovnicaID != null
                    ? () => {naruci()}
                    : null,
                child: Text(
                  "Naruci",
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
      ),
    ));
  }
}
