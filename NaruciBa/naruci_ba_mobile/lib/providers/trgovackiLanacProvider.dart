import 'package:flutter/cupertino.dart';
import 'package:naruci_ba_mobile/models/TrgovackiLanac.dart';
import 'package:naruci_ba_mobile/providers/base_api_provider.dart';

class TrgovackiLanacProvider extends BaseAPIProvider<TrgovackiLanac>
    with ChangeNotifier {
  TrgovackiLanacProvider(BuildContext context) : super(context);

  @override
  Future<String> basePath() async => (await getAppConfigProvider()).baseUrl;

  @override
  String resourceName() => "TrgovackiLanac";

  @override
  TrgovackiLanac convertFromJSON(json) {
    return TrgovackiLanac.fromJson(json);
  }
}
