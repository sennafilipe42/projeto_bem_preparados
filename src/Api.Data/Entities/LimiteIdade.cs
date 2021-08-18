using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities
{
    [Table("LIMITE_IDADE_CONVENIADA")]
    public class LimiteIdade
    {
        [Key]
        [Column("CONVENIADA")]
        public string CONVENIADA { get; set; }

        [Column("IDADE_INICIAL")]
        public int IDADE_INICIAL { get; set; }

        [Column("IDADE_FINAL")]
        public int IDADE_FINAL { get; set; }

        [Column("VALOR_LIMITE")]
        public int VALOR_LIMITE { get; set; }


        [Column("PERCENTUAL_MAXIMO_ANALISE")]
        public int PERCENTUAL_MAXIMO_ANALISE { get; set; }

    }
}
