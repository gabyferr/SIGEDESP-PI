﻿using api.Models;
using api.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace api.DTO.Entities
{
    public class InstituicaoDTO
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "A Situação é requerida!")]
        public SituacaoEnum Situacao { get; set; }

        [Required(ErrorMessage = "O CNPJ é requerido!")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "O Nome é requerido!")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Logradouro é requerido!")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Logradouro { get; set; }

        public int Numero { get; set; }

        [Required(ErrorMessage = "O Bairro é requerido!")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Bairro { get; set; }

        public int Cep { get; set; }

        [Required(ErrorMessage = "O Nome de Razão Social é requerido!")]
        [MinLength(1)]
        [MaxLength(100)]
        public string nomeRazaoSocial { get; set; }

        [Required(ErrorMessage = "O Telefone é requerido!")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O E-mail é requerido!")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Cidade é requerida!")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Estado é requerido!")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Estado { get; set; }

        /*Código para colocar atributos da classes que dão chave estrangeira no cadastro*/
        [JsonIgnore]
        public TipoInstituicaoModel? TipoInstituicaoLista { get; set; }

        [Required(ErrorMessage = "O ID de Tipo Instituição é requerido!")]
        public int IdTipoInstituicao { get; set; }

        [JsonIgnore]
        public SecretariaModel? Secretaria { get; set; }

        [Required(ErrorMessage = "O ID de Secretaria é requerido!")]
        public int IdSecretaria { get; set; }

    }
}
