import 'dart:convert';

import 'package:flutter/cupertino.dart';
import 'package:flutter/services.dart';
import 'package:naruci_ba_mobile/models/app_config.dart';

class AppConfigProvider {
  BuildContext context;

  AppConfigProvider({required this.context});

  Future<AppConfig> getConfig() async {
    // load the json file
    final contents = await rootBundle.loadString(
      'assets/config/config.json',
    );

    // decode our json
    final config = jsonDecode(contents);

    // convert our JSON into an instance of our AppConfig class
    return Future.value(AppConfig(
        baseUrl: config['baseUrl'],
        accessTokenTimeLimit: config['accessTokenTimeLimit'],
        clientId: config['clientId'],
        tokenEndpoint: config['tokenEndpoint'],
        redirectURL: config['redirectURL'],
        clientSecret: config['clientSecret'],
        signalRHubEndpoint: config['signalRHubEndpoint']));
  }
}
