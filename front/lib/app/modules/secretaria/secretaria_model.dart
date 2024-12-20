// ignore_for_file: public_member_api_docs, sort_constructors_first
import 'dart:convert';

import 'package:front/app/util/situacao_enum.dart';

class SecretariaModel {
  final int? id;
  final String? nome;
  final String? nomeRazaoSocial;
  final String? email;
  final String? cnpj;
  final String? cep;
  final String? logradouro;
  final String? descricao;
  final String? numero;
  final String? bairro;
  final String? cidade;
  final String? estado;
  final String? telefone;
  final SituacaoEnum? situacao;

  SecretariaModel({
    this.id,
    this.nome,
    this.telefone,
    this.nomeRazaoSocial,
    this.email,
    this.cnpj,
    this.cep,
    this.descricao,
    this.logradouro,
    this.numero,
    this.bairro,
    this.cidade,
    this.estado,
    this.situacao,
  });

  Map<String, dynamic> toMap() {
    return <String, dynamic>{
      'id': id,
      'nome': nome,
      'telefone': telefone,
      'nomeRazaoSocial': nomeRazaoSocial,
      'email': email,
      'cnpj': cnpj,
      'cep': cep,
      'descricao': descricao,
      'logradouro': logradouro,
      'numero': numero,
      'bairro': bairro,
      'cidade': cidade,
      'estado': estado,
      'situacao': situacao?.index,
    };
  }

  factory SecretariaModel.fromMap(Map<String, dynamic> map) {
    return SecretariaModel(
      id: map['id'] != null ? map['id'] as int : null,
      nome: map['nome'] != null ? map['nome'] as String : null,
      nomeRazaoSocial: map['nomeRazaoSocial'] != null
          ? map['nomeRazaoSocial'] as String
          : null,
      email: map['email'] != null ? map['email'] as String : null,
      cnpj: map['cnpj'] != null ? map['cnpj'] as String : null,
      cep: map['cep'] != null ? map['descricao'] as String : null,
      descricao: map['descricao'] != null ? map['cep'] as String : null,
      logradouro:
          map['logradouro'] != null ? map['logradouro'] as String : null,
      numero: (map['numero']),
      bairro: map['bairro'] != null ? map['bairro'] as String : null,
      cidade: map['cidade'] != null ? map['cidade'] as String : null,
      estado: map['estado'] != null ? map['estado'] as String : null,
      telefone: map['telefone'] != null ? map['telefone'] as String : null,
      situacao: SituacaoEnum.fromInt(map['situacao'] ?? 0),
    );
  }

  static String toJson(SecretariaModel value) => json.encode(value.toMap());

  factory SecretariaModel.fromJson(String source) =>
      SecretariaModel.fromMap(json.decode(source) as Map<String, dynamic>);

  SecretariaModel copyWith({
    int? id,
    String? nome,
    String? nomeRazaoSocial,
    String? email,
    String? cnpj,
    String? cep,
    String? descricao,
    String? logradouro,
    String? numero,
    String? telefone,
    String? bairro,
    String? cidade,
    String? estado,
    SituacaoEnum? situacao,
  }) {
    return SecretariaModel(
      id: id ?? this.id,
      nome: nome ?? this.nome,
      nomeRazaoSocial: nomeRazaoSocial ?? this.nomeRazaoSocial,
      email: email ?? this.email,
      cnpj: cnpj ?? this.cnpj,
      cep: cep ?? this.cep,
      descricao: descricao ?? this.descricao,
      telefone: telefone ?? this.telefone,
      logradouro: logradouro ?? this.logradouro,
      numero: numero ?? this.numero,
      bairro: bairro ?? this.bairro,
      cidade: cidade ?? this.cidade,
      estado: estado ?? this.estado,
      situacao: situacao ?? this.situacao,
    );
  }
}
