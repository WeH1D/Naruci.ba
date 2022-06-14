import 'package:json_annotation/json_annotation.dart';

part 'Grad.g.dart';

@JsonSerializable()
class Grad {
  final int gradID;
  final String naziv;

  Grad({
    required this.gradID,
    required this.naziv,
  });

  /// Connect the generated [_$GradFromJson] function to the `fromJson`
  /// factory.
  factory Grad.fromJson(Map<String, dynamic> json) => _$GradFromJson(json);

  /// Connect the generated [_$GradToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$GradToJson(this);
}
