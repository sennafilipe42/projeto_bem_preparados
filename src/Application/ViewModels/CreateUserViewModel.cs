using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class CreateUserViewModel
    {
        //exigencias sempre fazendo para baixo
        //funciona como uma DTO só para envio de dados, então precisa ser public


        [Required(ErrorMessage = "O usuario não pode ser nulo")]
        [MaxLength(10, ErrorMessage = "O usuario deve ter no máximo 10 caracteres.")]
        public string Usuario { get; set; }
        //************************************************************************************
        [Required(ErrorMessage = "O nome não pode ser nulo")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
        [MaxLength(20, ErrorMessage = "O nome de ter no máximo 20 caracteres.")]
        public string Nome { get; set; }
        //************************************************************************************
        [Required(ErrorMessage = "A senha não pode ser nulo")]
        [MaxLength(10, ErrorMessage = "A senha deve ter no mínimo 10 caracteres")]
        public string Senha { get; set; }
    }
}
