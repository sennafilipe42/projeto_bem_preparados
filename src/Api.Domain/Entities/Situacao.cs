using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities
{
    [Table("TREINA_SITUACAO")]
    public class Situacao : BaseEntity
    {
        [Required]
        [Column("ID_TREINA_SITUACAO")]
        public string ID_TREINA_SITUACAO { get; set; }

        [Required]
        [Column("SITUACAO")]
        public string SITUACAO { get; set; }


        [Required]
        [Column("DESCRICAO")]
        public string DESCRICAO { get; set; }

    }
}
