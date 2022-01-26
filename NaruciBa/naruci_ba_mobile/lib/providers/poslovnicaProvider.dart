import 'package:flutter/cupertino.dart';
import 'package:naruci_ba_mobile/models/Poslovnica.dart';
import 'package:naruci_ba_mobile/providers/base_api_provider.dart';

class PoslovnicaProvider extends BaseAPIProvider<Poslovnica>
    with ChangeNotifier {
  PoslovnicaProvider(BuildContext context) : super(context);

  @override
  Future<String> basePath() async => (await getAppConfigProvider()).baseUrl;

  @override
  String resourceName() => "Poslovnica";

  @override
  Poslovnica convertFromJSON(json) {
    return Poslovnica.fromJson(json);
  }
}
