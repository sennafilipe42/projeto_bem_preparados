using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities
{
    [Table("TREINA_CLIENTES")]
    public class Clientes : BaseEntity
    {
        [Required]
        [Column("ID_TREINA_CLIENTE")]
        public int ID_TREINA_CLIENTE { get; set; }

        [Required]
        [Column("CPF")]
        public string CPF { get; set; }

        [Required]
        [Column("NOME")]
        public string NOME { get; set; }

        [Required]
        [Column("DT_NASCIMENTO")]
        public DateTime DT_NASCIMENTO { get; set; }

        [Required]
        [Column("GENERO")]
        public string GENERO { get; set; }

        [Required]
        [Column("VLR_SALARIO")]
        public int VLR_SALARIO { get; set; }

        [Required]
        [Column("LOGRADOURO")]
        public string LOGRADOURO { get; set; }

        [Required]
        [Column("NUMERO_RESIDENCIA")]
        public int NUMERO_RESIDENCIA { get; set; }

        [Required]
        [Column("BAIRRO")]
        public string BAIRRO { get; set; }

        [Required]
        [Column("CIDADE")]
        public DateTime CIDADE { get; set; }

        [Required]
        [Column("CEP")]
        public string CEP { get; set; }


    }
}
