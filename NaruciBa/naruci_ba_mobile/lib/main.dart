import 'dart:io';

import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/providers/KlijentProvider.dart';
import 'package:naruci_ba_mobile/providers/NaruceniProizvod.dart';
import 'package:naruci_ba_mobile/providers/NarudzbaProvider.dart';
import 'package:naruci_ba_mobile/providers/NarudzbaStatus.dart';
import 'package:naruci_ba_mobile/providers/app_config_provider.dart';
import 'package:naruci_ba_mobile/providers/authentification_provider.dart';
import 'package:naruci_ba_mobile/providers/base_api_provider.dart';
import 'package:naruci_ba_mobile/providers/dostavljacProvider.dart';
import 'package:naruci_ba_mobile/providers/gradProvider.dart';
import 'package:naruci_ba_mobile/providers/kategorijaProvider.dart';
import 'package:naruci_ba_mobile/providers/korisnikPorvider.dart';
import 'package:naruci_ba_mobile/providers/podkategorijaProvider.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaKategorijaProvider.dart';
import 'package:naruci_ba_mobile/providers/poslovnicaProvider.dart';
import 'package:naruci_ba_mobile/providers/proizvodProvider.dart';
import 'package:naruci_ba_mobile/providers/trgovackiLanacProvider.dart';
import 'package:naruci_ba_mobile/screens/home_screen.dart';
import 'package:naruci_ba_mobile/screens/login_screen.dart';
import 'package:naruci_ba_mobile/screens/poslovnica_screen.dart';
import 'package:provider/provider.dart';

void main() {
  runApp(const MyApp());
}

class MyHttpOverrides extends HttpOverrides {
  @override
  HttpClient createHttpClient(SecurityContext? context) {
    return super.createHttpClient(context)
      ..badCertificateCallback =
          (X509Certificate cert, String host, int port) => true;
  }
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    HttpOverrides.global = MyHttpOverrides();
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        // This is the theme of your application.
        //
        // Try running your application with "flutter run". You'll see the
        // application has a blue toolbar. Then, without quitting the app, try
        // changing the primarySwatch below to Colors.green and then invoke
        // "hot reload" (press "r" in the console where you ran "flutter run",
        // or simply save your changes to "hot reload" in a Flutter IDE).
        // Notice that the counter didn't reset back to zero; the application
        // is not restarted.
        primarySwatch: Colors.blue,
      ),
      home: const MyHomePage(title: 'Flutter Demo Home Page'),
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({Key? key, required this.title}) : super(key: key);

  // This widget is the home page of your application. It is stateful, meaning
  // that it has a State object (defined below) that contains fields that affect
  // how it looks.

  // This class is the configuration for the state. It holds the values (in this
  // case the title) provided by the parent (in this case the App widget) and
  // used by the build method of the State. Fields in a Widget subclass are
  // always marked "final".

  final String title;

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  @override
  Widget build(BuildContext context) {
    return MultiProvider(
      providers: [
        Provider<AppConfigProvider>(
          create: (ctx) => AppConfigProvider(context: ctx),
        ),
        ChangeNotifierProvider<AuthentificationProvider>(
          create: (ctx) => AuthentificationProvider(ctx),
        ),
        ChangeNotifierProvider<PoslovnicaProvider>(
            create: (ctx) => PoslovnicaProvider(ctx)),
        ChangeNotifierProvider<KategorijaProvider>(
            create: (ctx) => KategorijaProvider(ctx)),
        ChangeNotifierProvider<PodkategorijaProvider>(
            create: (ctx) => PodkategorijaProvider(ctx)),
        ChangeNotifierProvider<ProizvodProvider>(
            create: (ctx) => ProizvodProvider(ctx)),
        ChangeNotifierProvider<PoslovnicaKategorijaProvider>(
            create: (ctx) => PoslovnicaKategorijaProvider(ctx)),
        ChangeNotifierProvider<TrgovackiLanacProvider>(
            create: (ctx) => TrgovackiLanacProvider(ctx)),
        ChangeNotifierProvider<KorisnikProvider>(
            create: (ctx) => KorisnikProvider(ctx)),
        ChangeNotifierProvider<GradProvider>(
            create: (ctx) => GradProvider(ctx)),
        ChangeNotifierProvider<NarudzbaProvider>(
            create: (ctx) => NarudzbaProvider(ctx)),
        ChangeNotifierProvider<NarudzbaStatusProvider>(
            create: (ctx) => NarudzbaStatusProvider(ctx)),
        ChangeNotifierProvider<KlijentProvider>(
            create: (ctx) => KlijentProvider(ctx)),
        ChangeNotifierProvider<NaruceniProizvodProvider>(
            create: (ctx) => NaruceniProizvodProvider(ctx)),
        ChangeNotifierProvider<DostavljacProvider>(
            create: (ctx) => DostavljacProvider(ctx)),
      ],
      child: MaterialApp(
        theme: ThemeData(),
        home: Scaffold(
          body: LoginScreen(),
        ),
        /*  routes: {
          HomeScreen.routeName: (context) => const HomeScreen(),
          LoginScreen.routeName: (context) => const LoginScreen(),
          PoslovnicaScreen.routeName: (context) => const PoslovnicaScreen()
        }, */
      ),
    );
  }
}
