// A widget that displays the picture taken by the user.
import 'dart:convert';
import 'dart:io';

import 'package:camera/camera.dart';
import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/providers/NarudzbaProvider.dart';
import 'package:naruci_ba_mobile/providers/NarudzbaStatus.dart';
import 'package:naruci_ba_mobile/screens/narudzba_screen.dart';
import 'package:naruci_ba_mobile/templates/main_template.dart';
import 'package:path/path.dart' as Path;
import 'package:provider/src/provider.dart';

class DisplayPictureScreen extends StatefulWidget {
  final String imagePath;
  final int narudzbaId;

  const DisplayPictureScreen(
      {Key? key, required this.imagePath, required this.narudzbaId})
      : super(key: key);

  @override
  State<DisplayPictureScreen> createState() => _DisplayPictureScreen();
}

class _DisplayPictureScreen extends State<DisplayPictureScreen> {
  late NarudzbaProvider _narudzbaProvider;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _narudzbaProvider = context.read<NarudzbaProvider>();
  }

  Future<void> uploadImage() async {
    var imageFile = File(widget.imagePath);
    var imageAsBase64 = imageFile.readAsBytesSync();
    var result = Base64Encoder().convert(imageAsBase64);
    var request = {
      "SlikaRacuna": result,
      "SlikaRacunaPutanja": Path.basename(imageFile.path)
    };
    await _narudzbaProvider.put(id: widget.narudzbaId, request: request);

    Navigator.pushAndRemoveUntil(
        context,
        MaterialPageRoute(
          builder: (context) => NarudzbaScreen(
            narudzbaId: widget.narudzbaId,
            dostavljacView: true,
          ),
        ),
        (Route<dynamic> route) => route is NarudzbaScreen);
  }

  @override
  Widget build(BuildContext context) {
    return MainTemplate(
        includeMenu: false,
        // The image is stored as a file on the device. Use the `Image.file`
        // constructor with the given path to display the image.
        child: Column(
          children: [
            Padding(
              padding: const EdgeInsets.all(10),
              child: Container(
                height: MediaQuery.of(context).size.height / 1.5,
                child: Image.file(
                  File(widget.imagePath),
                  fit: BoxFit.fill,
                ),
              ),
            ),
            Padding(
              padding: const EdgeInsets.fromLTRB(20, 10, 20, 10),
              child: ElevatedButton(
                  onPressed: () => {uploadImage()},
                  child: Text(
                    "Iskoristi sliku",
                    style: TextStyle(fontWeight: FontWeight.bold, fontSize: 18),
                  ),
                  style: ElevatedButton.styleFrom(
                    shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(30)),
                    fixedSize: Size(MediaQuery.of(context).size.width, 50),
                    primary: Color.fromARGB(255, 255, 83, 73),
                  )),
            ),
            Padding(
              padding: const EdgeInsets.fromLTRB(20, 10, 20, 10),
              child: ElevatedButton(
                  onPressed: () => {
                        Navigator.pop(
                          context,
                        )
                      },
                  child: Text(
                    "Uslikaj ponovo",
                    style: TextStyle(fontWeight: FontWeight.bold, fontSize: 18),
                  ),
                  style: ElevatedButton.styleFrom(
                    shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(30)),
                    fixedSize: Size(MediaQuery.of(context).size.width, 50),
                    primary: Color.fromARGB(255, 255, 83, 73),
                  )),
            ),
          ],
        ));
  }
}
