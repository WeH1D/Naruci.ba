import 'package:flutter/material.dart';

class NarudzbaTracker extends StatefulWidget {
  const NarudzbaTracker(
      {Key? key,
      required this.status,
      required this.isActive,
      this.isLast = false})
      : super(key: key);
  final String status;
  final bool isActive;
  final bool isLast;

  @override
  State<NarudzbaTracker> createState() => _NarudzbaTrackerState();
}

class _NarudzbaTrackerState extends State<NarudzbaTracker> {
  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Row(
          children: [
            Stack(
              alignment: Alignment.center,
              children: [
                Container(
                  width: 20,
                  height: 20,
                  decoration: BoxDecoration(
                    color: widget.isActive
                        ? Color.fromARGB(0, 255, 83, 73)
                        : Color.fromARGB(255, 255, 83, 73),
                    borderRadius: BorderRadius.circular(50),
                  ),
                ),
                Container(
                  width: 30,
                  height: 30,
                  decoration: BoxDecoration(
                    border: Border.all(
                      width: 2,
                      color: Color.fromARGB(255, 255, 83, 73),
                    ),
                    borderRadius: BorderRadius.circular(50),
                  ),
                )
              ],
            ),
            SizedBox(
              width: 20,
            ),
            Text(
              widget.status,
              style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
            )
          ],
        ),
        !widget.isLast
            ? Container()
            : Row(
                children: [
                  SizedBox(
                    width: 15,
                  ),
                  Container(
                    height: 20,
                    width: 2,
                    decoration: BoxDecoration(
                      color: Color.fromARGB(255, 255, 83, 73),
                    ),
                  ),
                ],
              ),
      ],
    );
  }
}
