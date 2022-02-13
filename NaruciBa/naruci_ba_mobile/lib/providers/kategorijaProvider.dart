import 'package:flutter/cupertino.dart';
import 'package:naruci_ba_mobile/models/Kategorija.dart';
import 'package:naruci_ba_mobile/providers/base_api_provider.dart';

class KategorijaProvider extends BaseAPIProvider<Kategorija>
    with ChangeNotifier {
  KategorijaProvider(BuildContext context) : super(context);

  @override
  Future<String> basePath() async => (await getAppConfigProvider()).baseUrl;

  @override
  String resourceName() => "Kategorija";

  @override
  Kategorija convertFromJSON(json) {
    return Kategorija.fromJson(json);
  }
}
