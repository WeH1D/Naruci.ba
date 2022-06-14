import 'package:flutter/cupertino.dart';
import 'package:naruci_ba_mobile/models/NarudzbaStatus.dart';
import 'package:naruci_ba_mobile/providers/base_api_provider.dart';

class NarudzbaStatusProvider extends BaseAPIProvider<NarudzbaStatus>
    with ChangeNotifier {
  NarudzbaStatusProvider(BuildContext context) : super(context);

  @override
  Future<String> basePath() async => (await getAppConfigProvider()).baseUrl;

  @override
  String resourceName() => "NarudzbaStatus";

  @override
  NarudzbaStatus convertFromJSON(json) {
    return NarudzbaStatus.fromJson(json);
  }
}
