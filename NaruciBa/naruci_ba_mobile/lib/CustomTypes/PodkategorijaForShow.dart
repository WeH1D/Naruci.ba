import 'package:naruci_ba_mobile/models/Proizvod.dart';

class PodkategorijaForShow {
  final int podkategorijaId;
  final String podkategorijaNaziv;
  final List<Proizvod> proizvodi;

  PodkategorijaForShow(
      this.podkategorijaId, this.podkategorijaNaziv, this.proizvodi);
}
