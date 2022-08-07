import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:modal_progress_hud/modal_progress_hud.dart';
import 'package:naruci_ba_mobile/models/Grad.dart';
import 'package:naruci_ba_mobile/models/Korisnik.dart';
import 'package:naruci_ba_mobile/providers/authentification_provider.dart';
import 'package:naruci_ba_mobile/providers/gradProvider.dart';
import 'package:naruci_ba_mobile/providers/korisnikPorvider.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaProvider.dart';
import 'package:naruci_ba_mobile/screens/home_screen.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';
import 'package:naruci_ba_mobile/widgets/logo.dart';
import 'package:provider/src/provider.dart';

class MyInformationsScreen extends StatefulWidget {
  static String routeName = "myInformations";

  const MyInformationsScreen({Key? key}) : super(key: key);

  @override
  _MyInformationsScreenState createState() => _MyInformationsScreenState();
}

class _MyInformationsScreenState extends State<MyInformationsScreen> {
  late AuthentificationProvider _authentication;
  late KorisnikProvider _korisnikProvider;
  late GradProvider _gradProvider;
  TextEditingController imeController = TextEditingController();
  TextEditingController prezimeController = TextEditingController();
  TextEditingController emailController = TextEditingController();
  TextEditingController adresaController = TextEditingController();
  TextEditingController telefonController = TextEditingController();
  TextEditingController passwordController = TextEditingController();
  TextEditingController confirmPasswordController = TextEditingController();
  TextEditingController datumController = TextEditingController();
  TextEditingController gradController = TextEditingController();
  List<Grad>? _gradovi;
  Grad? _selectedGrad;
  DateTime selectedDate = DateTime.now();

  final formKey = GlobalKey<FormState>();
  bool ediInfo = false;

  Korisnik? _korisnik;

  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    isLoading = false;
    _authentication = context.read<AuthentificationProvider>();
    _korisnikProvider = context.read<KorisnikProvider>();
    _gradProvider = context.read<GradProvider>();
    fetchInfo();
  }

  fetchInfo() async {
    setState(() {
      isLoading = true;
    });
    List<Grad> data = await _gradProvider.get();
    _korisnik =
        await _korisnikProvider.getById(id: _korisnikProvider.korisnikID);
    setState(() {
      isLoading = false;
      _gradovi = data;
      if (_korisnik != null) {
        imeController.text = _korisnik!.ime;
        prezimeController.text = _korisnik!.prezime;
        emailController.text = _korisnik!.email;
        datumController.text = _korisnik!.datumRodenja.toString();
        adresaController.text = _korisnik!.adresa;
        telefonController.text = _korisnik!.telefon;
        _selectedGrad =
            _gradovi!.firstWhere((grad) => grad.gradID == _korisnik!.gradID);
      }
    });
  }

  _selectDate(BuildContext context) async {
    DateTime? picked = await showDatePicker(
        context: context,
        initialDate: selectedDate,
        firstDate: DateTime(1950),
        lastDate: DateTime(2100));
    if (picked != null && picked != selectedDate) {
      setState(() {
        selectedDate = picked;
        var date =
            "${picked.toLocal().day}/${picked.toLocal().month}/${picked.toLocal().year}";
        datumController.text = date;
      });
    }
  }

  updateKorisnik() async {
    setState(() {
      isLoading = true;
    });
    var request = {
      "ime": imeController.text,
      "prezime": prezimeController.text,
      "adresa": adresaController.text,
      "email": emailController.text,
      "telefon": telefonController.text,
      "datumRodenja": selectedDate.toIso8601String(),
      "datumIzmjene": DateTime.now().toIso8601String(),
      "gradID": _selectedGrad!.gradID
    };
    var updatedKorisnik = await _korisnikProvider.put(
        id: _korisnik!.korisnikID, request: request);

    _korisnikProvider.korisnikID = updatedKorisnik.korisnikID;
    _korisnikProvider.imePrezime =
        updatedKorisnik.ime + " " + updatedKorisnik.prezime;
    _korisnikProvider.email = updatedKorisnik.email;

    setState(() {
      isLoading = false;
    });

    await fetchInfo();

    setState(() {
      ediInfo = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MainTemplate(
      child: ModalProgressHUD(
        inAsyncCall: isLoading,
        child: SingleChildScrollView(
          child: Center(
            child: Padding(
              padding: EdgeInsets.fromLTRB(50, 0, 50, 0),
              child: Form(
                key: formKey,
                child: !ediInfo
                    ? Column(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [
                          SizedBox(
                            height: 40,
                          ),
                          Row(
                            children: [
                              Text(
                                "Ime: ",
                                style: TextStyle(fontWeight: FontWeight.bold),
                              ),
                              Text(_korisnik != null ? _korisnik!.ime : "")
                            ],
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          Row(
                            children: [
                              Text(
                                "Prezime: ",
                                style: TextStyle(fontWeight: FontWeight.bold),
                              ),
                              Text(_korisnik != null ? _korisnik!.prezime : "")
                            ],
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          Row(
                            children: [
                              Text(
                                "Email: ",
                                style: TextStyle(fontWeight: FontWeight.bold),
                              ),
                              Text(_korisnik != null ? _korisnik!.email : "")
                            ],
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          Row(
                            children: [
                              Text(
                                "Datum rodenja: ",
                                style: TextStyle(fontWeight: FontWeight.bold),
                              ),
                              Text(_korisnik != null
                                  ? _korisnik!.datumRodenja!.day.toString() +
                                      "/" +
                                      _korisnik!.datumRodenja!.month
                                          .toString() +
                                      "/" +
                                      _korisnik!.datumRodenja!.year.toString()
                                  : ""),
                            ],
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          Row(
                            children: [
                              Text(
                                "Grad: ",
                                style: TextStyle(fontWeight: FontWeight.bold),
                              ),
                              Text(_korisnik != null
                                  ? _gradovi!
                                      .firstWhere((grad) =>
                                          grad.gradID == _korisnik!.gradID)
                                      .naziv
                                  : "")
                            ],
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          Row(
                            children: [
                              Text(
                                "Address: ",
                                style: TextStyle(fontWeight: FontWeight.bold),
                              ),
                              Text(_korisnik != null ? _korisnik!.adresa : "")
                            ],
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          Row(
                            children: [
                              Text(
                                "Telefon: ",
                                style: TextStyle(fontWeight: FontWeight.bold),
                              ),
                              Text(_korisnik != null ? _korisnik!.telefon : "")
                            ],
                          ),
                          SizedBox(
                            height: 50,
                          ),
                          ElevatedButton(
                              onPressed: () => {
                                    setState(() {
                                      ediInfo = true;
                                    })
                                  },
                              child: Text(
                                "Edit",
                                style: TextStyle(fontWeight: FontWeight.bold),
                              ),
                              style: ElevatedButton.styleFrom(
                                  fixedSize: Size(
                                      MediaQuery.of(context).size.width, 40),
                                  primary: Color.fromARGB(255, 255, 83, 73))),
                        ],
                      )
                    : Column(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [
                          SizedBox(
                            height: 10,
                          ),
                          TextFormField(
                            validator: (value) {
                              if (value == null || value.isEmpty) {
                                return "Polje mora biti popunjeno";
                              } else {
                                return null;
                              }
                            },
                            controller: imeController,
                            decoration: InputDecoration(
                                hintText: "Ime",
                                border: OutlineInputBorder(
                                    borderRadius:
                                        BorderRadius.all(Radius.circular(10))),
                                contentPadding: EdgeInsets.all(10),
                                hintStyle: TextStyle(
                                    color: Color.fromARGB(120, 64, 64, 64))),
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          TextFormField(
                            controller: prezimeController,
                            validator: (value) {
                              if (value == null || value.isEmpty) {
                                return "Polje mora biti popunjeno";
                              } else {
                                return null;
                              }
                            },
                            decoration: InputDecoration(
                                hintText: "Prezime",
                                border: OutlineInputBorder(
                                    borderRadius:
                                        BorderRadius.all(Radius.circular(10))),
                                contentPadding: EdgeInsets.all(10),
                                hintStyle: TextStyle(
                                    color: Color.fromARGB(120, 64, 64, 64))),
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          TextFormField(
                            controller: emailController,
                            validator: (value) {
                              if (value == null || value.isEmpty) {
                                return "Polje mora biti popunjeno";
                              } else if (!RegExp(r'^[^@]+@[^@]+\.[^@]+$')
                                  .hasMatch(value)) {
                                return "Upisite validan Email";
                              } else {
                                return null;
                              }
                            },
                            decoration: InputDecoration(
                                hintText: "Email",
                                border: OutlineInputBorder(
                                    borderRadius:
                                        BorderRadius.all(Radius.circular(10))),
                                contentPadding: EdgeInsets.all(10),
                                hintStyle: TextStyle(
                                    color: Color.fromARGB(120, 64, 64, 64))),
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          TextFormField(
                            controller: passwordController,
                            validator: (value) {
                              if (value == null || value.isEmpty) {
                                return "Polje mora biti popunjeno";
                              } else if (passwordController.text !=
                                  confirmPasswordController.text) {
                                return "Passwordi se ne podudaraju";
                              } else {
                                return null;
                              }
                            },
                            obscureText: true,
                            decoration: InputDecoration(
                                hintText: "Password",
                                border: OutlineInputBorder(
                                    borderRadius:
                                        BorderRadius.all(Radius.circular(10))),
                                contentPadding: EdgeInsets.all(10),
                                hintStyle: TextStyle(
                                    color: Color.fromARGB(120, 64, 64, 64))),
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          TextFormField(
                            controller: confirmPasswordController,
                            validator: (value) {
                              if (value == null || value.isEmpty) {
                                return "Polje mora biti popunjeno";
                              } else if (passwordController.text !=
                                  confirmPasswordController.text) {
                                return "Passwordi se ne podudaraju";
                              } else {
                                return null;
                              }
                            },
                            obscureText: true,
                            decoration: InputDecoration(
                                hintText: "Confirm Password",
                                border: OutlineInputBorder(
                                    borderRadius:
                                        BorderRadius.all(Radius.circular(10))),
                                contentPadding: EdgeInsets.all(10),
                                hintStyle: TextStyle(
                                    color: Color.fromARGB(120, 64, 64, 64))),
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          GestureDetector(
                            onTap: () => _selectDate(context),
                            child: AbsorbPointer(
                              child: TextFormField(
                                controller: datumController,
                                validator: (value) {
                                  if (value == null || value.isEmpty) {
                                    return "Polje mora biti popunjeno";
                                  } else {
                                    return null;
                                  }
                                },
                                decoration: InputDecoration(
                                    hintText: "Date of birth",
                                    border: OutlineInputBorder(
                                        borderRadius: BorderRadius.all(
                                            Radius.circular(10))),
                                    contentPadding: EdgeInsets.all(10),
                                    hintStyle: TextStyle(
                                        color:
                                            Color.fromARGB(120, 64, 64, 64))),
                              ),
                            ),
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          Container(
                            width: double.infinity,
                            padding: EdgeInsets.fromLTRB(10, 0, 10, 0),
                            decoration: BoxDecoration(
                                border:
                                    Border.all(width: 1, color: Colors.grey),
                                borderRadius:
                                    BorderRadius.all((Radius.circular(10)))),
                            child: DropdownButtonFormField(
                                value: _selectedGrad?.naziv,
                                validator: (value) {
                                  if (value == null) {
                                    return "Polje mora biti popunjeno";
                                  } else {
                                    return null;
                                  }
                                },
                                items: _gradovi?.map<DropdownMenuItem<String>>(
                                    (Grad grad) {
                                  return DropdownMenuItem<String>(
                                    value: grad.naziv,
                                    child: Text(
                                      grad.naziv,
                                      style: TextStyle(color: Colors.black),
                                    ),
                                  );
                                }).toList(),
                                isExpanded: true,
                                hint: Text(
                                  "Grad",
                                  style: TextStyle(
                                      color: Colors.grey,
                                      fontSize: 14,
                                      fontWeight: FontWeight.w500),
                                ),
                                onChanged: (data) => setState(() {
                                      _selectedGrad = _gradovi?.firstWhere(
                                          (element) => element.naziv == data);
                                    })),
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          TextFormField(
                            controller: adresaController,
                            validator: (value) {
                              if (value == null || value.isEmpty) {
                                return "Polje mora biti popunjeno";
                              } else {
                                return null;
                              }
                            },
                            decoration: InputDecoration(
                                hintText: "Address",
                                border: OutlineInputBorder(
                                    borderRadius:
                                        BorderRadius.all(Radius.circular(10))),
                                contentPadding: EdgeInsets.all(10),
                                hintStyle: TextStyle(
                                    color: Color.fromARGB(120, 64, 64, 64))),
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          TextFormField(
                            controller: telefonController,
                            keyboardType: TextInputType.phone,
                            validator: (value) {
                              if (value == null || value.isEmpty) {
                                return "Polje mora biti popunjeno";
                              } else {
                                return null;
                              }
                            },
                            decoration: InputDecoration(
                                hintText: "Telefon",
                                border: OutlineInputBorder(
                                    borderRadius:
                                        BorderRadius.all(Radius.circular(10))),
                                contentPadding: EdgeInsets.all(10),
                                hintStyle: TextStyle(
                                    color: Color.fromARGB(120, 64, 64, 64))),
                          ),
                          SizedBox(
                            height: 10,
                          ),
                          ElevatedButton(
                              onPressed: () => {updateKorisnik()},
                              child: Text(
                                "Save",
                                style: TextStyle(fontWeight: FontWeight.bold),
                              ),
                              style: ElevatedButton.styleFrom(
                                  fixedSize: Size(
                                      MediaQuery.of(context).size.width, 40),
                                  primary: Color.fromARGB(255, 255, 83, 73))),
                          ElevatedButton(
                              onPressed: () => {
                                    setState(() {
                                      ediInfo = false;
                                    })
                                  },
                              child: Text(
                                "Cancel",
                                style: TextStyle(fontWeight: FontWeight.bold),
                              ),
                              style: ElevatedButton.styleFrom(
                                  fixedSize: Size(
                                      MediaQuery.of(context).size.width, 40),
                                  primary: Color.fromARGB(255, 255, 83, 73))),
                        ],
                      ),
              ),
            ),
          ),
        ),
      ),
    );
  }
}
