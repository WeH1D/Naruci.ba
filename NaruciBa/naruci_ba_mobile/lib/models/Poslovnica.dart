import 'package:json_annotation/json_annotation.dart';

part 'Poslovnica.g.dart';

@JsonSerializable()
class Poslovnica {
  final int poslovnicaID;
  final String adresa;
  final int? gradID;
  final String kontaktTel;
  final String kontaktEmail;
  final int? trgovackiLanacID;
  final DateTime? datumKreiranja;
  final DateTime? datumIzmjene;

  Poslovnica(
      {required this.poslovnicaID,
      required this.adresa,
      required this.gradID,
      required this.kontaktTel,
      required this.kontaktEmail,
      required this.trgovackiLanacID,
      required this.datumIzmjene,
      required this.datumKreiranja});

  /// Connect the generated [_$PersonFromJson] function to the `fromJson`
  /// factory.
  factory Poslovnica.fromJson(Map<String, dynamic> json) =>
      _$PoslovnicaFromJson(json);

  /// Connect the generated [_$PoslovnicaToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$PoslovnicaToJson(this);
}
