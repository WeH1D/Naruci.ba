import 'package:flutter/cupertino.dart';
import 'package:naruci_ba_mobile/models/NaruceniProizvod.dart';
import 'package:naruci_ba_mobile/providers/base_api_provider.dart';

class NaruceniProizvodProvider extends BaseAPIProvider<NaruceniProizvod>
    with ChangeNotifier {
  NaruceniProizvodProvider(BuildContext context) : super(context);

  @override
  Future<String> basePath() async => (await getAppConfigProvider()).baseUrl;

  @override
  String resourceName() => "NaruceniProizvod";

  @override
  NaruceniProizvod convertFromJSON(json) {
    return NaruceniProizvod.fromJson(json);
  }
}
