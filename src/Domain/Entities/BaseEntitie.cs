using System.Collections.Generic;

namespace Domain.Entities
{
    public abstract class Base
    {
        public string USUARIO_ATUALIZACAO { get; set; }
        public string DATA_ATUALIZACAO { get; set; } 

        //lista de erros, pois toda entidade precisa de um metodo de validação
        internal list<string> _errors;

        //somente para leitura dos erros
        public IReadOnlyCollection<string> Errors => _errors;//arrow function para o _errors 

        //metodo de validação
        public abstract bool Validate();
    }
}
