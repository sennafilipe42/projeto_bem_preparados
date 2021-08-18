using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities
{
    [Table("TREINA_CONVENIADA")]
    public class Convenio : BaseEntity

    {
        [Required]
        [Column("ID_TREINA_CONVENIADA")]
        public int ID_TREINA_CONVENIADA { get; set; }

        [Required]
        [Column("CONVENIADA")]
        public string CONVENIADA { get; set; }

        [Required]
        [Column("DESCRICAO")]
        public string DESCRICAO { get; set; }

    }
}
