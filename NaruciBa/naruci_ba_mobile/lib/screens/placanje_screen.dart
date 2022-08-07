import 'dart:core';
import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/models/Grad.dart';
import 'package:naruci_ba_mobile/models/Korisnik.dart';
import 'package:naruci_ba_mobile/models/NaruceniProizvod.dart';
import 'package:naruci_ba_mobile/models/Narudzba.dart';
import 'package:naruci_ba_mobile/models/Proizvod.dart';
import 'package:naruci_ba_mobile/providers/gradProvider.dart';
import 'package:naruci_ba_mobile/providers/korisnikPorvider.dart';
import 'package:naruci_ba_mobile/services/paypal_service.dart';
import 'package:provider/src/provider.dart';
import 'package:webview_flutter/webview_flutter.dart';

class PlacanjeScreen extends StatefulWidget {
  final Function onFinish;
  final Narudzba narudzba;
  final List<Proizvod> items;
  final List<NaruceniProizvod> orderedItems;

  const PlacanjeScreen(
      {required this.onFinish,
      required this.narudzba,
      required this.items,
      required this.orderedItems,
      Key? key})
      : super(key: key);

  @override
  State<StatefulWidget> createState() {
    return PlacanjeScreenState();
  }
}

class PlacanjeScreenState extends State<PlacanjeScreen> {
  GlobalKey<ScaffoldState> _scaffoldKey = GlobalKey<ScaffoldState>();
  String? checkoutUrl;
  String? executeUrl;
  String? accessToken;
  PaypalServices services = PaypalServices();
  late KorisnikProvider _korisnikProvider;
  late GradProvider _gradProvider;

  Korisnik? _korisnik;
  Grad? _grad;

  // you can change default currency according to your need
  Map<dynamic, dynamic> defaultCurrency = {
    "symbol": "EUR",
    "decimalDigits": 2,
    "symbolBeforeTheNumber": true,
    "currency": "EUR"
  };

  bool isEnableShipping = false;
  bool isEnableAddress = false;

  String returnURL = 'return.example.com';
  String cancelURL = 'cancel.example.com';

  @override
  void initState() {
    super.initState();

    _korisnikProvider = context.read<KorisnikProvider>();
    _gradProvider = context.read<GradProvider>();

    fetchKorisnik();
    Future.delayed(Duration.zero, () async {
      try {
        accessToken = await services.getAccessToken();

        final transactions = getOrderParams();
        final res =
            await services.createPaypalPayment(transactions, accessToken);
        if (res != null) {
          setState(() {
            checkoutUrl = res["approvalUrl"];
            executeUrl = res["executeUrl"];
          });
        }
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
    });
  }

  Map<String, dynamic> getOrderParams() {
    List items = widget.items
        .map((prod) => {
              "name": prod.naziv,
              "quantity": widget.orderedItems
                  .where((a) => a.proizvodID == prod.proizvodID)
                  .first
                  .kolicina,
              "price": prod.cijena,
              "currency": defaultCurrency["currency"]
            })
        .toList();

    // checkout invoice details
    String totalAmount = widget.narudzba.ukupanIznos.toString();
    String subTotalAmount = widget.narudzba.ukupanIznos.toString();
    String shippingCost = '0';
    int shippingDiscountCost = 0;
    String userFirstName = _korisnik!.ime;
    String userLastName = _korisnik!.prezime;
    String addressCity = _grad!.naziv;
    String addressStreet = _korisnik!.adresa;
    // String addressZipCode = '110014';
    String addressCountry = 'Bosnia and Herzegovina';
    String addressPhoneNumber = _korisnik!.telefon;

    Map<String, dynamic> temp = {
      "intent": "sale",
      "payer": {"payment_method": "paypal"},
      "transactions": [
        {
          "amount": {
            "total": totalAmount,
            "currency": defaultCurrency["currency"],
            "details": {
              "subtotal": subTotalAmount,
              "shipping": shippingCost,
              "shipping_discount": ((-1.0) * shippingDiscountCost).toString()
            }
          },
          "description": "The payment transaction description.",
          "payment_options": {
            "allowed_payment_method": "INSTANT_FUNDING_SOURCE"
          },
          "item_list": {
            "items": items,
            if (isEnableShipping && isEnableAddress)
              "shipping_address": {
                "recipient_name": userFirstName + " " + userLastName,
                "line1": addressStreet,
                "line2": "",
                "city": addressCity,
                "country_code": addressCountry,
                // "postal_code": addressZipCode,
                "phone": addressPhoneNumber
              },
          }
        }
      ],
      "note_to_payer": "Contact us for any questions on your order.",
      "redirect_urls": {"return_url": returnURL, "cancel_url": cancelURL}
    };
    return temp;
  }

  fetchKorisnik() async {
    _korisnik =
        await _korisnikProvider.getById(id: _korisnikProvider.korisnikID);
    _grad = await _gradProvider.getById(id: _korisnik!.gradID);
  }

  @override
  Widget build(BuildContext context) {
    print(checkoutUrl);

    if (checkoutUrl != null) {
      return Scaffold(
        appBar: AppBar(
          backgroundColor: Theme.of(context).backgroundColor,
          leading: GestureDetector(
            child: Icon(Icons.arrow_back_ios),
            onTap: () => Navigator.pop(context),
          ),
        ),
        body: WebView(
          initialUrl: checkoutUrl,
          javascriptMode: JavascriptMode.unrestricted,
          navigationDelegate: (NavigationRequest request) {
            if (request.url.contains(returnURL)) {
              final uri = Uri.parse(request.url);
              final payerID = uri.queryParameters['PayerID'];
              if (payerID != null) {
                services
                    .executePayment(
                        Uri.parse(executeUrl!), payerID, accessToken)
                    .then((id) {
                  widget.onFinish(id);
                  Navigator.of(context).pop();
                });
              } else {
                Navigator.of(context).pop();
              }
              Navigator.of(context).pop();
            }
            if (request.url.contains(cancelURL)) {
              Navigator.of(context).pop();
            }
            return NavigationDecision.navigate;
          },
        ),
      );
    } else {
      return Scaffold(
        key: _scaffoldKey,
        appBar: AppBar(
          leading: IconButton(
              icon: Icon(Icons.arrow_back),
              onPressed: () {
                Navigator.of(context).pop();
              }),
          backgroundColor: Colors.black12,
          elevation: 0.0,
        ),
        body: Center(child: Container(child: CircularProgressIndicator())),
      );
    }
  }
}
