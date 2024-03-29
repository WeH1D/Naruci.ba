import 'dart:io';

import 'package:flutter/cupertino.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

import 'package:naruci_ba_mobile/models/app_config.dart';
import 'package:naruci_ba_mobile/providers/app_config_provider.dart';
import 'package:naruci_ba_mobile/providers/authentification_provider.dart';
import 'package:provider/provider.dart';

abstract class BaseAPIProvider<T> {
  BuildContext context;
  late AppConfigProvider provider;
  late AuthentificationProvider _authentication;
  Future<String> basePath();
  String resourceName();

  BaseAPIProvider(this.context) {
    provider = context.read<AppConfigProvider>();
    _authentication = context.read<AuthentificationProvider>();
  }

  Future get({dynamic id, String? actionName, Map? searchParams}) async {
    var path = '${await basePath()}/${resourceName()}';

    if (id != null) {
      path = path + "/${id.toString()}";
    }

    if (actionName != null) {
      path = path + "/$actionName";
    }

    if (searchParams != null) {
      String queryString = getQueryString(searchParams);
      path = path + "?" + queryString;
    }
    print("running GET: $path");

    var uriPath = Uri.parse(path);
    final response =
        await http.get(uriPath, headers: await createTokenHeader());

    if (response.body == null || response.body == "") {
      throw Exception("Connectivity issue");
    }

    var data = json.decode(response.body);

    if (response.statusCode == 200) {
      print("RESPONSE $data");
      List<T> result = [];
      data.forEach((a) => {result.add(convertFromJSON(a))});
      var val = Future.value(result);
      return val;
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
  }

  Future getById({dynamic id}) async {
    var path = '${await basePath()}/${resourceName()}/${id.toString()}';

    print("running GET BY ID: $path");
    var uriPath = Uri.parse(path);
    final response =
        await http.get(uriPath, headers: await createTokenHeader());
    print(response.body);
    if (response.body == null || response.body == "") {
      throw Exception("Connectivity issue");
    }

    var data = json.decode(response.body);

    if (response.statusCode == 200) {
      print("RESPONSE $data");
      return convertFromJSON(data);
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
  }

  Future<T> post(
      {required dynamic request,
      String jsonRequest = "",
      String actionName = ""}) async {
    var path = '${await basePath()}/${resourceName()}';
    if (actionName != "") {
      path = path + "/$actionName";
    }
    String tmp;
    if (request != null) {
      tmp = json.encode(request);
    } else {
      tmp = jsonRequest;
    }

    var start = DateTime.now();
    print("running POST $path");
    var uriPath = Uri.parse(path);
    var headers = await createTokenHeader();
    print("HEADERS $headers");
    final response = await http.post(uriPath, body: tmp, headers: headers);

    print("done");
    var end = DateTime.now();
    var diff = end.difference(start).inMilliseconds;

    print('Finished POST: $path executedin: ${diff}');

    var data;

    if (response.body != null && response.body != "") {
      data = json.decode(response.body);
    }

    if (response.statusCode == 200) {
      if (data != null && response.body != "") {
        return convertFromJSON(jsonDecode(response.body));
      } else {
        throw Exception("No response");
      }
    } else if (response.statusCode == 307) {
      final uri = Uri.parse(response.headers["location"]!);
      final redirectData = await http.post(uri, body: tmp, headers: headers);
      return convertFromJSON(jsonDecode(redirectData.body));
    } else {
      throw Exception("Server side error");
    }
  }

  Future<T> put(
      {required int id,
      required dynamic request,
      String jsonRequest = ""}) async {
    var path = '${await basePath()}/${resourceName()}/$id';

    String tmp;
    if (request != null) {
      tmp = json.encode(request);
    } else {
      tmp = jsonRequest;
    }

    var start = DateTime.now();
    print("running PUT $path");
    var uriPath = Uri.parse(path);
    var headers = await createTokenHeader();
    print("HEADERS $headers");
    final response = await http.put(uriPath, body: tmp, headers: headers);

    print("done");
    var end = DateTime.now();
    var diff = end.difference(start).inMilliseconds;

    print('Finished PUT: $path executedin: ${diff}');

    var data;

    if (response.body != null && response.body != "") {
      data = json.decode(response.body);
    }

    if (response.statusCode == 200) {
      if (data != null && response.body != "") {
        return convertFromJSON(jsonDecode(response.body));
      } else {
        throw Exception("No response");
      }
    } else if (response.statusCode == 307) {
      final uri = Uri.parse(response.headers["location"]!);
      final redirectData = await http.put(uri, body: tmp, headers: headers);
      return convertFromJSON(jsonDecode(redirectData.body));
    } else {
      throw Exception("Server side error");
    }
  }

  Future<T> delete({required int id}) async {
    var path = '${await basePath()}/${resourceName()}/$id';

    var start = DateTime.now();
    print("running DELETE $path");
    var uriPath = Uri.parse(path);
    var headers = await createTokenHeader();
    print("HEADERS $headers");
    final response = await http.delete(uriPath, headers: headers);

    print("done");
    var end = DateTime.now();
    var diff = end.difference(start).inMilliseconds;

    print('Finished DELETE: $path executedin: ${diff}');

    var data;

    if (response.body != null && response.body != "") {
      data = json.decode(response.body);
    }

    if (response.statusCode == 200) {
      if (data != null && response.body != "") {
        return convertFromJSON(jsonDecode(response.body));
      } else {
        throw Exception("No response");
      }
    } else if (response.statusCode == 307) {
      final uri = Uri.parse(response.headers["location"]!);
      final redirectData = await http.delete(uri, headers: headers);
      return convertFromJSON(jsonDecode(redirectData.body));
    } else {
      throw Exception("Server side error");
    }
  }

  T convertFromJSON(dynamic json);

  AuthentificationProvider get authentication {
    if (_authentication == null) {
      _authentication = context.read<AuthentificationProvider>();
    }
    return _authentication;
  }

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

  Future<Map<String, String>> createTokenHeader() async {
    print('creeating headers');
    //If there is no access token then create new token
    var accessToken = authentication.accessToken;
    var config = await getAppConfigProvider();

    if (accessToken != null && !_authentication.gettingNewToken) {
      // token expired
      if (_authentication.accessTokenExpirationDateTime!
          .difference(DateTime.now())
          .isNegative) {
        print('getting new token...');
        await _authentication.getNewToken();
      }
      return {
        "Authorization": "Bearer ${_authentication.accessToken}",
        "Accept": "application/json",
        "content-type": "application/json"
      };
    } else if (accessToken == null) {
      print("CREATING NEW TOKEN");
      await _authentication.createNewToken();
      return {
        "Authorization": "Bearer ${_authentication.accessToken}",
        "Accept": "application/json",
        "content-type": "application/json"
      };
    }
    print("RETURNING NOTHING");
    return {};
  }
}
