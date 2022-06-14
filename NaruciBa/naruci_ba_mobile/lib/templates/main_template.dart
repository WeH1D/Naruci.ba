import 'package:flutter/material.dart';
import 'package:naruci_ba_mobile/widgets/SideDrawer.dart';

class MainTemplate extends StatefulWidget {
  final Widget child;
  final Widget? floatingButton;
  const MainTemplate({required this.child, this.floatingButton, Key? key})
      : super(key: key);

  @override
  _MainTemplateState createState() => _MainTemplateState();
}

class _MainTemplateState extends State<MainTemplate> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        drawer: SideDrawer(),
        floatingActionButton:
            widget.floatingButton != null ? widget.floatingButton : null,
        floatingActionButtonLocation: FloatingActionButtonLocation.centerFloat,
        backgroundColor: Colors.white,
        appBar: AppBar(
          toolbarHeight: 40,
          backgroundColor: Color.fromARGB(255, 255, 83, 73),
        ),
        body: Center(
          child: SafeArea(
            child: widget.child,
          ),
        ));
  }
}
