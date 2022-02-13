import 'package:flutter/material.dart';

class FiltersTopCard extends StatefulWidget {
  const FiltersTopCard({Key? key}) : super(key: key);

  @override
  _FiltersTopCardState createState() => _FiltersTopCardState();
}

class _FiltersTopCardState extends State<FiltersTopCard> {
  double filterContainerHeight = 150;
  bool filterContainerIsOpen = false;

  void openFilters() {
    setState(() {
      if (filterContainerIsOpen) {
        filterContainerHeight = MediaQuery.of(context).size.height / 1.5;
        filterContainerIsOpen = false;
      } else {
        filterContainerHeight = 150;
        filterContainerIsOpen = true;
      }
    });
  }

  @override
  Widget build(BuildContext context) {
    return Container(
      height: filterContainerHeight,
      width: MediaQuery.of(context).size.width,
      decoration: BoxDecoration(
          color: Color.fromARGB(255, 23, 255, 255),
          borderRadius: BorderRadius.only(
              bottomLeft: Radius.circular(20),
              bottomRight: Radius.circular(20))),
      child: Padding(
        padding: const EdgeInsets.fromLTRB(30, 10, 30, 10),
        child: Column(
          children: [
            Row(
              children: [
                Container(
                  width: MediaQuery.of(context).size.width / 1.2,
                  child: TextField(
                    decoration: InputDecoration(
                      fillColor: Colors.white,
                      hintText: "Search",
                      border: OutlineInputBorder(
                          borderRadius: BorderRadius.all(Radius.circular(10))),
                      contentPadding: EdgeInsets.all(10),
                    ),
                  ),
                ),
              ],
            ),
            Row(
              children: [
                ElevatedButton(
                    onPressed: () {
                      openFilters();
                    },
                    child: Text("Filter")),
                Text("Filters")
              ],
            )
          ],
        ),
      ),
    );
  }
}
