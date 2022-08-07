import 'package:flutter/material.dart';
import 'package:modal_progress_hud/modal_progress_hud.dart';
import 'package:naruci_ba_mobile/widgets/SideDrawer.dart';
import 'package:provider/src/provider.dart';

class MainTemplate extends StatefulWidget {
  final Widget child;
  final Widget? floatingButton;
  final bool includeMenu;
  const MainTemplate(
      {required this.child,
      this.floatingButton,
      Key? key,
      this.includeMenu = true})
      : super(key: key);

  @override
  _MainTemplateState createState() => _MainTemplateState();
}

class _MainTemplateState extends State<MainTemplate> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      drawer: widget.includeMenu ? SideDrawer() : null,
      floatingActionButton:
          widget.floatingButton != null ? widget.floatingButton : null,
      floatingActionButtonLocation: FloatingActionButtonLocation.centerFloat,
      backgroundColor: Colors.white,
      appBar: widget.includeMenu
          ? AppBar(
              toolbarHeight: 40,
              backgroundColor: Color.fromARGB(255, 255, 83, 73),
            )
          : null,
      body: SafeArea(
        child: widget.child,
      ),
    );
  }
}
