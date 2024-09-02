using api.Models.Enum; // Certifique-se de que o namespace do enum está correto
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api.Models
{
    [Table("usuario")]
    public class UsuarioModel
    {
        [Key]
        [Column("usuarioid")]
        public int Id { get; set; }

        [Column("cpfcnpj")]
        public string CpfCnpj { get; set; }

        [Column("nomerazaosocial")]
        public string NomeRazaoSocial { get; set; }

        [Column("rgle")]
        public int RgLe { get; set; }

        [Column("logradouro")]
        public string Logradouro { get; set; }

        [Column("numero")]
        public int Numero { get; set; }

        [Column("cidade")]
        public string Cidade { get; set; }

        [Column("estado")]
        public string Estado { get; set; }

        [Column("cep")]
        public int CEP { get; set; }

        [Column("bairro")]
        public string Bairro { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        // Mapear o campo situacao como enum
        [Column("situacao")]
        [EnumDataType(typeof(SituacaoEnum))]
        public SituacaoEnum Situacao { get; set; }

        [Column("matricula")]
        public string Matricula { get; set; }

        [Column("tipousuario")]
        [EnumDataType(typeof(TipoUsuarioEnum))]
        public TipoUsuarioEnum TipoUsuario { get; set; }

        // Relacionamento com DespesaModel
        [JsonIgnore]
        public ICollection<DespesaModel>? Despesa { get; set; }
    }
}
