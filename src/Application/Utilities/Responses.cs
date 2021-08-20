using System.Collections.Generic;
using Application.ViewModels;

namespace Application.Utilities
{

    //statica não precisa de instacia, não cria obj, tem dados mocados, só retorna dados
    public static class Responses
    {
        //************ Se usa essa classe para não ficar repetindo código
        public static ResultViewModel ApplicationErrorMessage()
        {
            //retorna uma view de resultado, toda vez que a application der um erro
            // retorna o obj a baixo
            return new ResultViewModel
            {
                Message = "Ocorreu algum erro interno na aplicação, por favor tente novamento.",
                Success = false,
                Data = null
            };

        }

        public static ResultViewModel DomainErrorMessage(string message, List<string> errors)
        {
            //retorna uma view de resultado, toda vez que a domain der um erro
            // retorna o obj a baixo
            return new ResultViewModel
            {
                Message = message,
                Success = false,
                Data = null
            };
        }

        public static ResultViewModel DomainErrorMessage(string message, IReadOnlyCollection<string> errors)
        {

            return new ResultViewModel
            {
                Message = message,
                Success = false,
                Data = errors
            };
        }

        public static ResultViewModel UnauthorizedErrorMessage()
        {
            //Retorna obj a baixo quando o login e a senha estão incorretos
            return new ResultViewModel
            {
                Message = "A combinação de login e senha está incorreta!",
                Success = false,
                Data = null
            };

        }


    }
}
