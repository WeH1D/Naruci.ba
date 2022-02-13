import 'package:flutter/cupertino.dart';
import 'package:naruci_ba_mobile/models/Kategorija.dart';
import 'package:naruci_ba_mobile/models/Podkategorija.dart';
import 'package:naruci_ba_mobile/providers/base_api_provider.dart';

class PodkategorijaProvider extends BaseAPIProvider<Podkategorija>
    with ChangeNotifier {
  PodkategorijaProvider(BuildContext context) : super(context);

  @override
  Future<String> basePath() async => (await getAppConfigProvider()).baseUrl;

  @override
  String resourceName() => "Podkategorija";

  @override
  Podkategorija convertFromJSON(json) {
    return Podkategorija.fromJson(json);
  }
}
