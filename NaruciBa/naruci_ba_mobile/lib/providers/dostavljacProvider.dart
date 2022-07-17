import 'package:flutter/cupertino.dart';
import 'package:naruci_ba_mobile/models/Dostavljac.dart';
import 'package:naruci_ba_mobile/models/Klijent.dart';
import 'package:naruci_ba_mobile/providers/base_api_provider.dart';

class DostavljacProvider extends BaseAPIProvider<Dostavljac>
    with ChangeNotifier {
  DostavljacProvider(BuildContext context) : super(context);

  int? _dostavljacID;
  int? get dostavljacID {
    return _dostavljacID;
  }

  set dostavljacID(value) {
    _dostavljacID = value;
  }

  @override
  Future<String> basePath() async => (await getAppConfigProvider()).baseUrl;

  @override
  String resourceName() => "Dostavljac";

  @override
  Dostavljac convertFromJSON(json) {
    return Dostavljac.fromJson(json);
  }
}
