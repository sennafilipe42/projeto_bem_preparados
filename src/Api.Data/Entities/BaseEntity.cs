using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Api.Data.Entities
{
    public class BaseEntity<T> where T : struct
    {
        [Key]
        [Column("CPF")]
        public T CPF { get; set; }


        [Column("DATA_ATUALIZACAO")]
        private DateTime? _dataAtualizacao;
        public DateTime? DATA_ATUALIZACAO
        {
            get { return _dataAtualizacao; }

            //Se o valor voltar como null, ele seta a data do banco de dados
            set { _dataAtualizacao = (value == null ? DateTime.UtcNow : value); }
        }

        [Column("USUARIO_ATUALIZACAO")]
        public string USUARIO_ATUALIZACAO { get; set; }

    }
}
