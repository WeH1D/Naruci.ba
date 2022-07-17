// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'Dostavljac.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Dostavljac _$DostavljacFromJson(Map<String, dynamic> json) => Dostavljac(
      korisnikID: json['korisnikID'] as int?,
      dostavljacID: json['dostavljacID'] as int,
      datumZaposlenja: json['datumZaposlenja'] == null
          ? null
          : DateTime.parse(json['datumZaposlenja'] as String),
      dostavljacStatus: json['dostavljacStatus'] as int?,
    );

Map<String, dynamic> _$DostavljacToJson(Dostavljac instance) =>
    <String, dynamic>{
      'dostavljacID': instance.dostavljacID,
      'korisnikID': instance.korisnikID,
      'datumZaposlenja': instance.datumZaposlenja?.toIso8601String(),
      'dostavljacStatus': instance.dostavljacStatus,
    };
