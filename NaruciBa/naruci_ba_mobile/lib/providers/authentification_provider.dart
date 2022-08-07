import 'dart:convert';

import 'package:flutter/cupertino.dart';
import 'package:flutter_appauth/flutter_appauth.dart';
import 'package:naruci_ba_mobile/models/app_config.dart';
import 'package:naruci_ba_mobile/providers/app_config_provider.dart';
import 'package:provider/provider.dart';
import 'package:http/http.dart' as http;

class AuthentificationProvider with ChangeNotifier {
  BuildContext context;
  AuthentificationProvider(this.context);

  late AppConfigProvider provider =
      Provider.of<AppConfigProvider>(context, listen: false);

  final FlutterAppAuth _appauth = FlutterAppAuth();

  String? _accessToken;
  String? get accessToken {
    return _accessToken;
  }

  String? _refreshToken;
  String? get refreshToken {
    return _refreshToken;
  }

  // late String _user;
  // String get user {
  //   return _user;
  // }

  DateTime? _accessTokenExpirationDateTime;
  DateTime? get accessTokenExpirationDateTime {
    return _accessTokenExpirationDateTime;
  }

  bool _gettingNewToken = false;
  bool get gettingNewToken {
    return _gettingNewToken;
  }

  Future<AppConfig> getAppConfigProvider() async {
    if (provider == null) {
      var config = Provider.of<AppConfigProvider>(context, listen: false);
      provider = config;
    }
    return await provider.getConfig();
  }

  getNewToken() async {
    _gettingNewToken = true;
    var config = await getAppConfigProvider();
    var clientId = config.clientId;
    var clientSecret = config.clientSecret;
    var tokenEndpoint = config.tokenEndpoint;
    final http.Response resultToken =
        await http.post(Uri.parse(tokenEndpoint), body: {
      "refresh_token": _refreshToken,
      "client_id": clientId,
      "client_secret": clientSecret,
      "scope": "MobileAppScope openid offline_access",
      "grant_type": "refresh_token",
    }).then((response) {
      print("RESPONSE $response");
      if (response.statusCode == 200) {
        print('Issued token: ${response.body}');
        final Map parsed = jsonDecode(response.body);
        _accessToken = parsed["access_token"];
        _refreshToken = parsed["refresh_token"];
        _accessTokenExpirationDateTime = DateTime.now();
        _accessTokenExpirationDateTime = _accessTokenExpirationDateTime
            ?.add(Duration(seconds: parsed["expires_in"] ?? 0));
      } else {
        _accessToken = "";
        _refreshToken = "";
        _accessTokenExpirationDateTime = DateTime.now();
      }
      return response;
    });
    _gettingNewToken = false;
  }

  login(String email, String password) async {
    _gettingNewToken = true;
    var config = await getAppConfigProvider();
    var clientId = config.clientId;
    var clientSecret = config.clientSecret;
    var tokenEndpoint = config.tokenEndpoint;
    final http.Response resultToken =
        await http.post(Uri.parse(tokenEndpoint), body: {
      "username": email,
      "password": password,
      "client_id": clientId,
      "client_secret": clientSecret,
      "scope": "MobileAppScope openid offline_access",
      "grant_type": "password",
    }).then((response) {
      if (response.statusCode == 200) {
        print('Issued token: ${response.body}');
        final Map parsed = jsonDecode(response.body);
        _accessToken = parsed["access_token"];
        _refreshToken = parsed["refresh_token"];
        _accessTokenExpirationDateTime = DateTime.now();
        _accessTokenExpirationDateTime = _accessTokenExpirationDateTime
            ?.add(Duration(seconds: parsed["expires_in"] ?? 0));
      } else {
        _accessToken = "";
        _refreshToken = "";
        _accessTokenExpirationDateTime = DateTime.now();
      }
      return response;
    });

    _gettingNewToken = false;
    return resultToken;
  }

  createNewToken() async {
    _gettingNewToken = true;
    var config = await getAppConfigProvider();
    var clientId = config.clientId;
    var clientSecret = config.clientSecret;
    var tokenEndpoint = config.tokenEndpoint;
    final http.Response resultToken =
        await http.post(Uri.parse(tokenEndpoint), body: {
      "client_id": clientId,
      "client_secret": clientSecret,
      "scope": "NotRegisteredAccess",
      "grant_type": "client_credentials",
    }).then((response) {
      if (response.statusCode == 200) {
        print('Issued token: ${response.body}');
        final Map parsed = jsonDecode(response.body);
        _accessToken = parsed["access_token"];
        _refreshToken = parsed["refresh_token"];
        _accessTokenExpirationDateTime = DateTime.now();
        _accessTokenExpirationDateTime = _accessTokenExpirationDateTime
            ?.add(Duration(seconds: parsed["expires_in"] ?? 0));
      } else {
        _accessToken = "";
        _refreshToken = "";
        _accessTokenExpirationDateTime = DateTime.now();
      }
      return response;
    });

    _gettingNewToken = false;
    if (resultToken.statusCode == 200) {
      return true;
    } else {
      return false;
    }
  }

  logout() async {
    _refreshToken = null;
    _accessToken = null;
  }
}
