// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'NaruceniProizvod.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

NaruceniProizvod _$NaruceniProizvodFromJson(Map<String, dynamic> json) =>
    NaruceniProizvod(
      naruceniProizvodID: json['naruceniProizvodID'] as int,
      proizvodID: json['proizvodID'] as int?,
      narudzbaID: json['narudzbaID'] as int?,
      kolicina: (json['kolicina'] as num?)?.toDouble(),
      ukupnaCijena: (json['ukupnaCijena'] as num?)?.toDouble(),
    );

Map<String, dynamic> _$NaruceniProizvodToJson(NaruceniProizvod instance) =>
    <String, dynamic>{
      'naruceniProizvodID': instance.naruceniProizvodID,
      'proizvodID': instance.proizvodID,
      'narudzbaID': instance.narudzbaID,
      'kolicina': instance.kolicina,
      'ukupnaCijena': instance.ukupnaCijena,
    };
