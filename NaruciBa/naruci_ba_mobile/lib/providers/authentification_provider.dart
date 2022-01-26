import 'package:flutter/cupertino.dart';

class AuthentificationProvider with ChangeNotifier {
  BuildContext context;
  AuthentificationProvider(this.context);

  late String _accessToken;
  String get accessToken {
    return _accessToken;
  }

  late String _refreshToken;
  String get refreshToken {
    return _refreshToken;
  }
}
