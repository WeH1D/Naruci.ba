import 'package:json_annotation/json_annotation.dart';

part 'Podkategorija.g.dart';

@JsonSerializable()
class Podkategorija {
  final int podkategorijaID;
  final String naziv;
  final int kategorijaID;

  Podkategorija({
    required this.podkategorijaID,
    required this.naziv,
    required this.kategorijaID,
  });

  /// Connect the generated [_$PersonFromJson] function to the `fromJson`
  /// factory.
  factory Podkategorija.fromJson(Map<String, dynamic> json) =>
      _$PodkategorijaFromJson(json);

  /// Connect the generated [_$PoslovnicaToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$PodkategorijaToJson(this);
}
