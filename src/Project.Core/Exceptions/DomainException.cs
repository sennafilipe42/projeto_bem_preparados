using System;
using System.Collections.Generic;

namespace Project.Core.Exceptions
{
    public class DomainException : Exception
    {
        internal List<string> _errors;


        //lista interna de erros refletida a baixo
        public List<string> Errors => _errors;

        //ctor vazio
        public DomainException() { }

        //ctor recebendo uma mensagem de erros e lista de erros
        public DomainException(string message, List<string> errors) : base(message)
        {
            _errors = errors;
        }


        //uam excecao que só posso receber a mensagem 
        //já existe na exceptionbase
        public DomainException(string message) : base(message) { }


        // ctor que recebe um exception dentro de uma exception
        //já existe na exceptionbase

        public DomainException(string message, Exception innerException) : base(message) { }
    }
}
