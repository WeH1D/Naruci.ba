import 'package:json_annotation/json_annotation.dart';

part 'NarudzbaStatus.g.dart';

@JsonSerializable()
class NarudzbaStatus {
  final int narudzbaStatusID;
  final String naziv;

  NarudzbaStatus({required this.narudzbaStatusID, required this.naziv});

  /// Connect the generated [_$NarudzbaStatusFromJson] function to the `fromJson`
  /// factory.
  factory NarudzbaStatus.fromJson(Map<String, dynamic> json) =>
      _$NarudzbaStatusFromJson(json);

  /// Connect the generated [_$NarudzbaStatusToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$NarudzbaStatusToJson(this);
}
