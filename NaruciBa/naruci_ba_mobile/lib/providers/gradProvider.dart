import 'package:flutter/cupertino.dart';
import 'package:naruci_ba_mobile/models/Grad.dart';
import 'package:naruci_ba_mobile/providers/base_api_provider.dart';

class GradProvider extends BaseAPIProvider<Grad> with ChangeNotifier {
  GradProvider(BuildContext context) : super(context);

  @override
  Future<String> basePath() async => (await getAppConfigProvider()).baseUrl;

  @override
  String resourceName() => "Grad";

  @override
  Grad convertFromJSON(json) {
    return Grad.fromJson(json);
  }
}
