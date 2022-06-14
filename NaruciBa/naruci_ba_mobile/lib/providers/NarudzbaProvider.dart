import 'package:flutter/cupertino.dart';
import 'package:naruci_ba_mobile/models/Narudzba.dart';
import 'package:naruci_ba_mobile/providers/base_api_provider.dart';

class NarudzbaProvider extends BaseAPIProvider<Narudzba> with ChangeNotifier {
  NarudzbaProvider(BuildContext context) : super(context);

  @override
  Future<String> basePath() async => (await getAppConfigProvider()).baseUrl;

  @override
  String resourceName() => "Narudzba";

  @override
  Narudzba convertFromJSON(json) {
    return Narudzba.fromJson(json);
  }
}
