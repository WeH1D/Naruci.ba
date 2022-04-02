import 'package:json_annotation/json_annotation.dart';

part 'TrgovackiLanac.g.dart';

@JsonSerializable()
class TrgovackiLanac {
  final int trgovackiLanacID;
  final String naziv;
  final String slikaPutanja;
  final String slika;

  TrgovackiLanac({
    required this.trgovackiLanacID,
    required this.naziv,
    required this.slikaPutanja,
    required this.slika,
  });

  /// Connect the generated [_$TrgovackiLanacJson] function to the `fromJson`
  /// factory.
  factory TrgovackiLanac.fromJson(Map<String, dynamic> json) =>
      _$TrgovackiLanacFromJson(json);

  /// Connect the generated [_$TrgovackiLanacToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$TrgovackiLanacToJson(this);
}
