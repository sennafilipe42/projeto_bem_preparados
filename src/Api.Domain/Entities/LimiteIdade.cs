using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities
{
    [Table("LIMITE_IDADE_CONVENIADA")]
    public class LimiteIdade
    {

        [Required]
        [Column("ID_TREINA_IDADE_CONVENIAA")]
        public int ID_TREINA_IDADE_CONVENIAA { get; set; }

        [Column("CONVENIADA")]
        public string CONVENIADA { get; set; }

        [Required]
        [Column("IDADE_INICIAL")]
        public int IDADE_INICIAL { get; set; }

        [Required]
        [Column("IDADE_FINAL")]
        public int IDADE_FINAL { get; set; }

        [Required]
        [Column("VALOR_LIMITE")]
        public int VALOR_LIMITE { get; set; }

        [Required]
        [Column("PERCENTUAL_MAXIMO_ANALISE")]
        public int PERCENTUAL_MAXIMO_ANALISE { get; set; }

    }
}
