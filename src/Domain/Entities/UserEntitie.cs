using System;
using System.Collections.Generic;
using Domain.Validators;
using Project.Core.Exceptions;

namespace Domain.Entities
{
    public class UserEntitie : BaseEntitie
    {


        //deixando privado para somente o metodo de validação           public int Id { get; private set; }

        public string Usuario { get; private set; }

        public string Senha { get; private set; }

        public string Nome { get; private set; }

        public DateTime ValidadeSenha { get; private set; }

        //Metodo que vai ser feito paara acessar
        // pois é privado.

        //var usuario = new usuario("Teste")
        //usuario.ChangeName("Teste")


        //particularidade do entitie framework
        //só será passar as propriedades por aqui
        protected UserEntitie() { }

        //Construtor
        public UserEntitie(int id, string usuario, string senha, string nome, DateTime validadeSenha)
        {
            this.Id = id;
            this.Usuario = usuario;
            this.Senha = senha;
            this.Nome = nome;
            this.ValidadeSenha = validadeSenha;

            //instanciar a lista de erros
            _errors = new List<string>();

            Validate();

        }


        public void ChangeUsuario(string usuario)
        {
            Usuario = usuario;
            Validate();
        }

        public void ChangeNome(string nome)
        {
            Nome = nome;
            Validate();
        }

        public void ChangeSenha(string senha)
        {
            Senha = senha;
            Validate();
        }

        public void ChangeValidadeSenha(DateTime validadeSenha)
        {
            ValidadeSenha = validadeSenha;
            Validate();
        }


        //Validação do usuário usando bool, True or False
        public override bool Validate()
        {
            var validador = new UsuarioValidador();
            var validation = validador.Validate(this);

            if (!validation.IsValid)
            {
                foreach (var error in validation.Errors)
                    _errors.Add(error.ErrorMessage);

                throw new DomainException("Alguns campos estão inválidos, por favor os corrija!", _errors);
            }

            return true;
        }
    }
}
