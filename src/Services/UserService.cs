using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Infra.Interfaces;
using Project.Core.Exceptions;
using Services.DTO;
using Services.Interfaces;

namespace Services
{
    public class UserService : IUserService
    {

        private readonly IMapper _mapper;

        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }



        public async Task<UserDTO> Create(UserDTO userDTO)
        {
            var userExists = await _userRepository.GetByUsuario(userDTO.Usuario);

            if (userExists != null)
                throw new DomainException("Já existe um usuário cadastrado com esse nome.");

            //utilizando o auto mapper, para fazer o "de para"
            var user = _mapper.Map<UserEntitie>(userDTO);
            user.Validate();

            // usuário não estando no banco, ele cria o usuario
            var userCreated = await _userRepository.Create(user);

            //utilizando o auto mapper, para fazer o "de para"
            return _mapper.Map<UserDTO>(userCreated);

        }
        public async Task<UserDTO> Update(UserDTO userDTO)
        {
            var userExists = await _userRepository.Get(userDTO.Id);

            if (userExists == null)
                throw new DomainException("Não existe nenhum usuário com o id informado!");

            var userUpdated = await _userRepository.Update(userExists);
            return _mapper.Map<UserDTO>(userUpdated);
        }
        public async Task Remove(long id)
        {
            await _userRepository.Remove(id);
        }
        public async Task<List<UserDTO>> Get(long id)
        {
            var allUsers = await _userRepository.Get(id);
            return _mapper.Map<List<UserDTO>>(allUsers);
        }


        public async Task<List<UserDTO>> Get()
        {
            var allUsers = await _userRepository.Get();
            return _mapper.Map<List<UserDTO>>(allUsers);
        }
        public async Task<List<UserDTO>> SearchByUsuario(string usuario)
        {
            var allUsers = await _userRepository.SearchByUsuario(usuario);
            return _mapper.Map<List<UserDTO>>(allUsers);
        }
        public async Task<List<UserDTO>> SearchByNome(string nome)
        {
            var allUsers = await _userRepository.SearchByNome(nome);
            return _mapper.Map<List<UserDTO>>(allUsers);
        }
        public async Task<UserDTO> GetByUsuario(string usuario)
        {
            var user = await _userRepository.GetByUsuario(usuario);

            return _mapper.Map<UserDTO>(user);

        }



    }
}
