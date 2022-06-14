import 'package:json_annotation/json_annotation.dart';

part 'NaruceniProizvod.g.dart';

@JsonSerializable()
class NaruceniProizvod {
  final int naruceniProizvodID;
  final int? proizvodID;
  final int? narudzbaID;
  final double? kolicina;
  final double? ukupnaCijena;

  NaruceniProizvod(
      {required this.naruceniProizvodID,
      required this.proizvodID,
      required this.narudzbaID,
      required this.kolicina,
      required this.ukupnaCijena});

  /// Connect the generated [_$NaruceniProizvodFromJson] function to the `fromJson`
  /// factory.
  factory NaruceniProizvod.fromJson(Map<String, dynamic> json) =>
      _$NaruceniProizvodFromJson(json);

  /// Connect the generated [_$NaruceniProizvodToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$NaruceniProizvodToJson(this);
}
