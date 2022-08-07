import 'package:flutter/cupertino.dart';
import 'package:naruci_ba_mobile/models/Korisnik.dart';
import 'package:naruci_ba_mobile/models/Podkategorija.dart';
import 'package:naruci_ba_mobile/providers/base_api_provider.dart';

class KorisnikProvider extends BaseAPIProvider<Korisnik> with ChangeNotifier {
  KorisnikProvider(BuildContext context) : super(context);

  int? _korisnikID;
  int? get korisnikID {
    return _korisnikID;
  }

  set korisnikID(value) {
    _korisnikID = value;
  }

  String? _imePrezime;
  String? get imePrezime {
    return _imePrezime;
  }

  set imePrezime(value) {
    _imePrezime = value;
  }

  String? _email;
  String? get email {
    return _email;
  }

  set email(value) {
    _email = value;
  }

  bool? _isDostavljac;
  bool? get isDostavljac {
    return _isDostavljac;
  }

  set isDostavljac(value) {
    _isDostavljac = value;
  }

  @override
  Future<String> basePath() async => (await getAppConfigProvider()).baseUrl;

  @override
  String resourceName() => "Korisnik";

  @override
  Korisnik convertFromJSON(json) {
    return Korisnik.fromJson(json);
  }
}
