using System;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Api.Data.Entities
{
    [Table("TREINA_PROPOSTAS")]
    public class CadastroPropostas : BaseEntity<int>
    {
        [Key]
        [Required]
        [Column("PROPOSTA")]
        public int PROPOSTA { get; set; }

        [Key]
        [Column("CONVENIADA")]
        public string CONVENIADA { get; set; }

        [Column("VLR_SOLICITADO")]
        public int VLR_SOLICITADO { get; set; }

        [Column("PRAZO")]
        public int PRAZO { get; set; }

        [Column("VLR_FINANCIADO")]
        public int VLR_FINANCIADO { get; set; }

        [Key]
        [Column("SITUACAO")]
        public string SITUACAO { get; set; }

        [Column("OBSERVACAO")]
        public string OBSERVACAO { get; set; }

        [Column("DT_SITUACAO")]
        public DateTime DT_SITUACAO { get; set; }

        [Key]
        [Column("USUARIO")]
        public string USUARIO { get; set; }
    }
}
