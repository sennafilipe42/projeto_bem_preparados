using System;
using System.Threading.Tasks;
using Application.Utilities;
using Application.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Core.Exceptions;
using Services.DTO;
using Services.Interfaces;

namespace Application.Controllers
{
        //controlador é o cara que recebe as requisições
        //e manda para as camadas fazerem o que precisam
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost] //rota de entrada para poder enviar o user
        [Route("/api/v1/users/create")]
                    //retorna o resultado dee uma Task
        public async Task<IActionResult> Create([FromBody] CreateUserViewModel userViewModel)
        {                                       //corpo da requisição
            try
            {
                var userDTO = _mapper.Map<UserDTO>(userViewModel);

                // await torna o método async, caso não coloque, vai acusar
                var userCreated = await _userService.Create(userDTO);

                return Ok(new ResultViewModel
                {
                    Message = "Usuário criado com sucesso!",
                    Success = true,
                    Data = userCreated
                });
            }
            catch (DomainException ex)
            {
                return BadRequest(Responses.DomainErrorMessage(ex.Message, ex.Errors));
            }
            catch (Exception)
            {
                return StatusCode(500, Responses.ApplicationErrorMessage());
            }
        }
    }
}
