import 'package:json_annotation/json_annotation.dart';

part 'Klijent.g.dart';

@JsonSerializable()
class Klijent {
  final int klijentID;
  final int? korisnikID;

  Klijent({required this.korisnikID, required this.klijentID});

  /// Connect the generated [_$KorisnikFromJson] function to the `fromJson`
  /// factory.
  factory Klijent.fromJson(Map<String, dynamic> json) =>
      _$KlijentFromJson(json);

  /// Connect the generated [_$KorisnikToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$KlijentToJson(this);
}
