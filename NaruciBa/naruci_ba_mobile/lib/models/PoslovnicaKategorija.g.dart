// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'PoslovnicaKategorija.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

PoslovnicaKategorija _$PoslovnicaKategorijaFromJson(
        Map<String, dynamic> json) =>
    PoslovnicaKategorija(
      PoslovnicaKategorijaID: json['PoslovnicaKategorijaID'] as int,
      kategorijaID: json['kategorijaID'] as int,
      poslovnicaID: json['poslovnicaID'] as int,
    );

Map<String, dynamic> _$PoslovnicaKategorijaToJson(
        PoslovnicaKategorija instance) =>
    <String, dynamic>{
      'PoslovnicaKategorijaID': instance.PoslovnicaKategorijaID,
      'kategorijaID': instance.kategorijaID,
      'poslovnicaID': instance.poslovnicaID,
    };
