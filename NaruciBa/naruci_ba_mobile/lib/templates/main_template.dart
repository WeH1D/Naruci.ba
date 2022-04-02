import 'package:flutter/material.dart';

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
        floatingActionButton:
            widget.floatingButton != null ? widget.floatingButton : null,
        floatingActionButtonLocation: FloatingActionButtonLocation.centerFloat,
        backgroundColor: Colors.white,
        body: Center(
          child: SafeArea(
            child: widget.child,
          ),
        ));
  }
}
