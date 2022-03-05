// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'Proizvod.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Proizvod _$ProizvodFromJson(Map<String, dynamic> json) => Proizvod(
      proizvodID: json['proizvodID'] as int,
      naziv: json['naziv'] as String,
      sifra: json['sifra'] as String,
      opis: json['opis'] as String,
      cijena: (json['cijena'] as num?)?.toDouble(),
      kg: json['kg'] as bool?,
      podkategorijaID: json['podkategorijaID'] as int?,
      poslovnicaID: json['poslovnicaID'] as int?,
      status: json['status'] as bool?,
      slika: json['slika'] as String?,
      slikaPutanja: json['slikaPutanja'] as String?,
      datumKreiranja: json['datumKreiranja'] == null
          ? null
          : DateTime.parse(json['datumKreiranja'] as String),
      datumIzmjene: json['datumIzmjene'] == null
          ? null
          : DateTime.parse(json['datumIzmjene'] as String),
    );

Map<String, dynamic> _$ProizvodToJson(Proizvod instance) => <String, dynamic>{
      'proizvodID': instance.proizvodID,
      'naziv': instance.naziv,
      'sifra': instance.sifra,
      'opis': instance.opis,
      'cijena': instance.cijena,
      'kg': instance.kg,
      'podkategorijaID': instance.podkategorijaID,
      'poslovnicaID': instance.poslovnicaID,
      'status': instance.status,
      'slika': instance.slika,
      'slikaPutanja': instance.slikaPutanja,
      'datumKreiranja': instance.datumKreiranja?.toIso8601String(),
      'datumIzmjene': instance.datumIzmjene?.toIso8601String(),
    };
