import 'package:flutter/cupertino.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

import 'package:naruci_ba_mobile/models/app_config.dart';
import 'package:naruci_ba_mobile/providers/app_config_provider.dart';
import 'package:provider/provider.dart';

abstract class BaseAPIProvider<T> {
  BuildContext context;
  late AppConfigProvider provider;
  Future<String> basePath();
  String resourceName();

  BaseAPIProvider(this.context) {
    provider = context.read<AppConfigProvider>();
  }

  Future getInternal(
      {dynamic id, String? actionName, Map? additionalData}) async {
    var path = '${await basePath()}/${resourceName()}';

    if (id != null) {
      path = path + "/${id.toString()}";
    }

    if (actionName != null) {
      path = path + "/$actionName";
    }

    if (additionalData != null) {
      String queryString = getQueryString(additionalData);
      path = path + "?" + queryString;
    }
    print("running GET: $path");
    // final response = await http.get(path, headers: await createHeaders());
    var uriPath = Uri.parse(path);
    final response = await http.get(uriPath, headers: {
      "Accept": "application/json",
      "content-type": "application/json"
    });
    print(response.body);
    if (response.body == null || response.body == "") {
      throw Exception("Connectivity issue");
    }

    var data = json.decode(response.body);

    if (response.statusCode == 200) {
      print("RESPONSE $data");
    } else if (response.statusCode == 400) {
      throw Exception(data);
    } else if (response.statusCode == 401) {
      //logout();
    } else if (response.statusCode == 403) {
      //logout();
      throw Exception('Sorry, you are not authorized for this action');
    } else {
      throw Exception("Server side error");
    }
    return data;
  }

  T convertFromJSON(dynamic json);

  Future<AppConfig> getAppConfigProvider() async {
    if (provider == null) {
      var config = Provider.of<AppConfigProvider>(context, listen: false);
      provider = config;
    }
    return await provider.getConfig();
  }

  String getQueryString(Map params,
      {String prefix: '&', bool inRecursion: false}) {
    String query = '';
    params.forEach((key, value) {
      if (inRecursion) {
        if (key is int) {
          key = '[$key]';
        } else if (value is List || value is Map) {
          key = '.$key';
        } else {
          key = '.$key';
        }
      }
      if (value is String || value is int || value is double || value is bool) {
        var encoded = value;
        if (value is String) {
          encoded = Uri.encodeComponent(value);
        }
        query += '$prefix$key=$encoded';
      } else if (value is DateTime) {
        query += '$prefix$key=${(value as DateTime).toIso8601String()}';
      } else if (value is List || value is Map) {
        if (value is List) value = value.asMap();
        value.forEach((k, v) {
          query +=
              getQueryString({k: v}, prefix: '$prefix$key', inRecursion: true);
        });
      }
    });
    return query;
  }

  // Future<dynamic> createHeaders() async {
  //   print('creeating headers');
  //   var accessToken = Authentication.AccessToken;
  //   print("access token: $accessToken");
  //   var config = await getAppConfigProvider();

  //   if (Authentication.AccessTokenExpirationDateTime != null &&
  //       !Authentication.GettingNewToken) {
  //     var accessTokenExpirationDateTime =
  //         Authentication.AccessTokenExpirationDateTime;
  //     if (config.accessTokenTimeLimit * 1000 -
  //                 accessTokenExpirationDateTime
  //                     .difference(DateTime.now())
  //                     .inMilliseconds >=
  //             0 &&
  //         accessTokenExpirationDateTime
  //                 .difference(DateTime.now())
  //                 .inMilliseconds >
  //             0) {
  //       print("getting new token...");
  //       _authentication.getNewAccessToken();
  //       accessToken = Authentication.AccessToken;
  //     } else if (accessTokenExpirationDateTime
  //         .difference(DateTime.now())
  //         .isNegative) {
  //       logout();
  //     }
  //   }
  // }
}
