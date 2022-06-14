import 'package:flutter/cupertino.dart';
import 'package:naruci_ba_mobile/models/Klijent.dart';
import 'package:naruci_ba_mobile/providers/base_api_provider.dart';

class KlijentProvider extends BaseAPIProvider<Klijent> with ChangeNotifier {
  KlijentProvider(BuildContext context) : super(context);

  int? _klijentID;
  int? get klijendID {
    return _klijentID;
  }

  set klijendID(value) {
    _klijentID = value;
  }

  @override
  Future<String> basePath() async => (await getAppConfigProvider()).baseUrl;

  @override
  String resourceName() => "Klijent";

  @override
  Klijent convertFromJSON(json) {
    return Klijent.fromJson(json);
  }
}
