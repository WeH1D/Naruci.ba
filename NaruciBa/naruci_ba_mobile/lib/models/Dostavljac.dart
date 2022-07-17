import 'package:json_annotation/json_annotation.dart';

part 'Dostavljac.g.dart';

@JsonSerializable()
class Dostavljac {
  final int dostavljacID;
  final int? korisnikID;
  final DateTime? datumZaposlenja;
  final int? dostavljacStatus;

  Dostavljac(
      {required this.korisnikID,
      required this.dostavljacID,
      required this.datumZaposlenja,
      required this.dostavljacStatus});

  /// Connect the generated [_$KorisnikFromJson] function to the `fromJson`
  /// factory.
  factory Dostavljac.fromJson(Map<String, dynamic> json) =>
      _$DostavljacFromJson(json);

  /// Connect the generated [_$KorisnikToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$DostavljacToJson(this);
}
