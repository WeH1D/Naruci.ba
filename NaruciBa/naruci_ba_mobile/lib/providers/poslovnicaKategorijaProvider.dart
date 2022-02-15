import 'package:flutter/cupertino.dart';
import 'package:naruci_ba_mobile/models/Kategorija.dart';
import 'package:naruci_ba_mobile/models/PoslovnicaKategorija.dart';
import 'package:naruci_ba_mobile/providers/base_api_provider.dart';

class PoslovnicaKategorijaProvider extends BaseAPIProvider<PoslovnicaKategorija>
    with ChangeNotifier {
  PoslovnicaKategorijaProvider(BuildContext context) : super(context);

  @override
  Future<String> basePath() async => (await getAppConfigProvider()).baseUrl;

  @override
  String resourceName() => "PoslovnicaKategorija";

  @override
  PoslovnicaKategorija convertFromJSON(json) {
    return PoslovnicaKategorija.fromJson(json);
  }
}
