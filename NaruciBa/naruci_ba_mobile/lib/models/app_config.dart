class AppConfig {
  final String baseUrl;
  final int accessTokenTimeLimit;
  final String clientId;
  final String clientSecret;
  final String redirectURL;
  final String tokenEndpoint;
  final String signalRHubEndpoint;

  AppConfig(
      {required this.baseUrl,
      required this.accessTokenTimeLimit,
      required this.clientId,
      required this.tokenEndpoint,
      required this.redirectURL,
      required this.clientSecret,
      required this.signalRHubEndpoint});
}
