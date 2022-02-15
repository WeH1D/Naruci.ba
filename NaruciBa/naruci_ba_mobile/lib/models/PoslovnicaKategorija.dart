import 'package:json_annotation/json_annotation.dart';

part 'PoslovnicaKategorija.g.dart';

@JsonSerializable()
class PoslovnicaKategorija {
  final int PoslovnicaKategorijaID;
  final int kategorijaID;
  final int poslovnicaID;

  PoslovnicaKategorija({
    required this.PoslovnicaKategorijaID,
    required this.kategorijaID,
    required this.poslovnicaID,
  });

  /// Connect the generated [_$PersonFromJson] function to the `fromJson`
  /// factory.
  factory PoslovnicaKategorija.fromJson(Map<String, dynamic> json) =>
      _$PoslovnicaKategorijaFromJson(json);

  /// Connect the generated [_$PoslovnicaToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$PoslovnicaKategorijaToJson(this);
}
