namespace Domain.Entities
{
    public class UserEntitie : Base
    {
        //deixando privado para somente o metodo de validação
        public int Id { get; private set; }

        public string Cpf { get; private set; }

        public string String { get; private set; }

        public smalldatetime DtNascimento { get; private set; }

        public string Genero { get; private set; }

        public int VlrSalario { get; private set; }

        public string Logradouro { get; private set; }

        public string NumeroResidencia { get; private set; }

        public string Bairro { get; private set; }

        public string Cidade { get; private set; }

        public string Cep { get; private set; }

        



    }
}
