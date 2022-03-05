import 'package:naruci_ba_mobile/CustomTypes/PodkategorijaForShow.dart';

class KateogrijaForShow {
  final String kateogrijaNaziv;
  final int kateogrijaId;
  bool isOpen;
  final List<PodkategorijaForShow> podkategorije;

  KateogrijaForShow(this.kateogrijaNaziv, this.kateogrijaId, this.podkategorije,
      {this.isOpen = false});
}
