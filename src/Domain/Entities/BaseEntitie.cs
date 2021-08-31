using System.Collections.Generic;
using System;

namespace Domain.Entities
{
    public abstract class BaseEntitie
    {
        public string Usuario_Atualizacao { get; set; }
        public DateTime Data_Atualizacao { get; set; }

        //lista de erros, pois toda entidade precisa de um metodo de validação
        internal List<string> _errors;

        //somente para leitura dos erros
        public IReadOnlyCollection<string> Errors => _errors;//arrow function para o _errors 

        //metodo de validação
        public abstract bool Validate();
    }
}
