import 'package:json_annotation/json_annotation.dart';

part 'Narudzba.g.dart';

@JsonSerializable()
class Narudzba {
  final int narudzbaID;
  final int? klijentID;
  final int? dostavljacID;
  final int? koordinatorID;
  final int? poslovnicaID;
  final DateTime? datum;
  final double? ukupanIznos;
  final double? bonusZaDostavljaca;
  final String slikaRacunaPutanja;
  final int? narudzbaStatusID;
  final int? kuponID;

  Narudzba(
      {required this.narudzbaID,
      required this.klijentID,
      required this.dostavljacID,
      required this.koordinatorID,
      required this.poslovnicaID,
      required this.datum,
      required this.ukupanIznos,
      required this.bonusZaDostavljaca,
      required this.slikaRacunaPutanja,
      required this.narudzbaStatusID,
      required this.kuponID});

  /// Connect the generated [_$NarudzbaFromJson] function to the `fromJson`
  /// factory.
  factory Narudzba.fromJson(Map<String, dynamic> json) =>
      _$NarudzbaFromJson(json);

  /// Connect the generated [_$NarudzbaToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$NarudzbaToJson(this);
}
