using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities
{
    [Table("TREINA_CONVENIADA")]
    public class Convenio : BaseEntity<int>

    {
        [Key]
        [Column("CONVENIADA")]
        public string CONVENIADA { get; set; }


        [Column("DESCRICAO")]
        public string DESCRICAO { get; set; }

    }
}
