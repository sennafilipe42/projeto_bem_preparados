using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities
{
    [Table("TREINA_CLIENTES")]
    public class Clientes : BaseEntity<int>
    {

        [Required]
        [Column("NOME")]
        public string NOME { get; set; }


        [Column("DT_NASCIMENTO")]
        public DateTime DT_NASCIMENTO { get; set; }

        [Column("GENERO")]
        public string GENERO { get; set; }

        [Column("VLR_SALARIO")]
        public int VLR_SALARIO { get; set; }

        [Column("LOGRADOURO")]
        public string LOGRADOURO { get; set; }


        [Column("NUMERO_RESIDENCIA")]
        public int NUMERO_RESIDENCIA { get; set; }

        [Column("BAIRRO")]
        public string BAIRRO { get; set; }

        [Column("CIDADE")]
        public DateTime CIDADE { get; set; }


        [Column("CEP")]
        public string CEP { get; set; }


    }
}
