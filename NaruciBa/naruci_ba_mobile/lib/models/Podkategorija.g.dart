// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'Podkategorija.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Podkategorija _$PodkategorijaFromJson(Map<String, dynamic> json) =>
    Podkategorija(
      podkategorijaID: json['podkategorijaID'] as int,
      naziv: json['naziv'] as String,
      kategorijaID: json['kategorijaID'] as int,
    );

Map<String, dynamic> _$PodkategorijaToJson(Podkategorija instance) =>
    <String, dynamic>{
      'podkategorijaID': instance.podkategorijaID,
      'naziv': instance.naziv,
      'kategorijaID': instance.kategorijaID,
    };
