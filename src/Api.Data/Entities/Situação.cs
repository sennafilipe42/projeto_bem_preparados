using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities
{
    [Table("TREINA_SITUACAO")]
    public class Situação : BaseEntity<int>
    {
        [Key]
        [Required]
        [Column("SITUACAO")]
        public string SITUACAO { get; set; }


        [Required]
        [Column("DESCRICAO")]
        public string DESCRICAO { get; set; }

    }
}
