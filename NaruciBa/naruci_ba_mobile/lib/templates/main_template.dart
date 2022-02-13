import 'package:flutter/material.dart';

class MainTemplate extends StatefulWidget {
  final Widget child;
  const MainTemplate({required this.child, Key? key}) : super(key: key);

  @override
  _MainTemplateState createState() => _MainTemplateState();
}

class _MainTemplateState extends State<MainTemplate> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: Center(
      child: SafeArea(
        child: widget.child,
      ),
    ));
  }
}
