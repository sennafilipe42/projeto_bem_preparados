using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class CreateUserViewModel
    {
        //exigencias sempre fazendo para baixo
        //funciona como uma DTO só para envio de dados, então precisa ser public
        

        [Required(ErrorMessage = "O usuario não pode ser nulo")]
        [MinLength(8, ErrorMessage = "O usuario deve ter no mínimo 8 caracteres")]
        [MaxLength(14, ErrorMessage = "O usuario de ter no máximo 14 caracteres.")]
        public string Usuario { get;  set; }
        //************************************************************************************
        [Required(ErrorMessage = "O nome não pode ser nulo")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
        [MaxLength(80, ErrorMessage = "O nome de ter no máximo 80 caracteres.")]
        public string Nome { get; set; }
        //************************************************************************************
        [Required(ErrorMessage = "A senha não pode ser nulo")]
        [MinLength(8, ErrorMessage = "A senha deve ter no mínimo 8 caracteres")]
        public string Senha { get;  set; }
    }
}
