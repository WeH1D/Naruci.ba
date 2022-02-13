import 'package:flutter/cupertino.dart';
import 'package:naruci_ba_mobile/models/Kategorija.dart';
import 'package:naruci_ba_mobile/models/Podkategorija.dart';
import 'package:naruci_ba_mobile/models/Proizvod.dart';
import 'package:naruci_ba_mobile/providers/base_api_provider.dart';

class ProizvodProvider extends BaseAPIProvider<Proizvod> with ChangeNotifier {
  ProizvodProvider(BuildContext context) : super(context);

  @override
  Future<String> basePath() async => (await getAppConfigProvider()).baseUrl;

  @override
  String resourceName() => "Proizvod";

  @override
  Proizvod convertFromJSON(json) {
    return Proizvod.fromJson(json);
  }
}
