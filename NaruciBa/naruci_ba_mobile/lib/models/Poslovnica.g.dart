// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'Poslovnica.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Poslovnica _$PoslovnicaFromJson(Map<String, dynamic> json) => Poslovnica(
      poslovnicaID: json['poslovnicaID'] as int,
      adresa: json['adresa'] as String,
      gradID: json['gradID'] as int?,
      kontaktTel: json['kontaktTel'] as String,
      kontaktEmail: json['kontaktEmail'] as String,
      trgovackiLanacID: json['trgovackiLanacID'] as int?,
      datumIzmjene: json['datumIzmjene'] == null
          ? null
          : DateTime.parse(json['datumIzmjene'] as String),
      datumKreiranja: json['datumKreiranja'] == null
          ? null
          : DateTime.parse(json['datumKreiranja'] as String),
    );

Map<String, dynamic> _$PoslovnicaToJson(Poslovnica instance) =>
    <String, dynamic>{
      'poslovnicaID': instance.poslovnicaID,
      'adresa': instance.adresa,
      'gradID': instance.gradID,
      'kontaktTel': instance.kontaktTel,
      'kontaktEmail': instance.kontaktEmail,
      'trgovackiLanacID': instance.trgovackiLanacID,
      'datumKreiranja': instance.datumKreiranja?.toIso8601String(),
      'datumIzmjene': instance.datumIzmjene?.toIso8601String(),
    };
