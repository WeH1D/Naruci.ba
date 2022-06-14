// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'Narudzba.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Narudzba _$NarudzbaFromJson(Map<String, dynamic> json) => Narudzba(
      narudzbaID: json['narudzbaID'] as int,
      klijentID: json['klijentID'] as int?,
      dostavljacID: json['dostavljacID'] as int?,
      koordinatorID: json['koordinatorID'] as int?,
      poslovnicaID: json['poslovnicaID'] as int?,
      datum: json['datum'] == null
          ? null
          : DateTime.parse(json['datum'] as String),
      ukupanIznos: (json['ukupanIznos'] as num?)?.toDouble(),
      bonusZaDostavljaca: (json['bonusZaDostavljaca'] as num?)?.toDouble(),
      slikaRacunaPutanja: json['slikaRacunaPutanja'] as String,
      narudzbaStatusID: json['narudzbaStatusID'] as int?,
      kuponID: json['kuponID'] as int?,
    );

Map<String, dynamic> _$NarudzbaToJson(Narudzba instance) => <String, dynamic>{
      'narudzbaID': instance.narudzbaID,
      'klijentID': instance.klijentID,
      'dostavljacID': instance.dostavljacID,
      'koordinatorID': instance.koordinatorID,
      'poslovnicaID': instance.poslovnicaID,
      'datum': instance.datum?.toIso8601String(),
      'ukupanIznos': instance.ukupanIznos,
      'bonusZaDostavljaca': instance.bonusZaDostavljaca,
      'slikaRacunaPutanja': instance.slikaRacunaPutanja,
      'narudzbaStatusID': instance.narudzbaStatusID,
      'kuponID': instance.kuponID,
    };
