// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'Korisnik.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Korisnik _$KorisnikFromJson(Map<String, dynamic> json) => Korisnik(
      korisnikID: json['korisnikID'] as int,
      ime: json['ime'] as String,
      prezime: json['prezime'] as String,
      adresa: json['adresa'] as String,
      email: json['email'] as String,
      telefon: json['telefon'] as String,
      datumRodenja: json['datumRodenja'] == null
          ? null
          : DateTime.parse(json['datumRodenja'] as String),
      datumKreiranja: json['datumKreiranja'] == null
          ? null
          : DateTime.parse(json['datumKreiranja'] as String),
      datumIzmjene: json['datumIzmjene'] == null
          ? null
          : DateTime.parse(json['datumIzmjene'] as String),
      slika: json['slika'] as String?,
      gradID: json['gradID'] as int?,
    );

Map<String, dynamic> _$KorisnikToJson(Korisnik instance) => <String, dynamic>{
      'korisnikID': instance.korisnikID,
      'ime': instance.ime,
      'prezime': instance.prezime,
      'adresa': instance.adresa,
      'email': instance.email,
      'telefon': instance.telefon,
      'datumRodenja': instance.datumRodenja?.toIso8601String(),
      'datumKreiranja': instance.datumKreiranja?.toIso8601String(),
      'datumIzmjene': instance.datumIzmjene?.toIso8601String(),
      'slika': instance.slika,
      'gradID': instance.gradID,
    };
