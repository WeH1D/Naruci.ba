import 'package:json_annotation/json_annotation.dart';

part 'Kategorija.g.dart';

@JsonSerializable()
class Kategorija {
  final int kategorijaID;
  final String naziv;

  Kategorija({
    required this.kategorijaID,
    required this.naziv,
  });

  /// Connect the generated [_$PersonFromJson] function to the `fromJson`
  /// factory.
  factory Kategorija.fromJson(Map<String, dynamic> json) =>
      _$KategorijaFromJson(json);

  /// Connect the generated [_$PoslovnicaToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$KategorijaToJson(this);
}
