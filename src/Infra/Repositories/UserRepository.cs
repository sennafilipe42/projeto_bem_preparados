using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Infra.Context;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class UserRepository : BaseRepository<UserEntitie>, IUserRepository
    {
        private readonly ContextBase _context;

        //Recebe por injeção de dependencia a classe contexto
        //classe que faz as operações no EFCore
        public UserRepository(ContextBase context) : base(context)
        {
            _context = context;
        }


        //acessa o usuario, via injeção de dependencia do context
        public async Task<UserEntitie> GetByUsuario(string usuario)
        {
            var user = await _context.Users
                                    .Where(  //Expressão lambda 
                                         x =>  //usuario em minusculo é igual ao usuario do construtor
                                            x.Usuario.ToLower() == usuario.ToLower()
                                     )
                                     .AsNoTracking()//retira o trackeamento
                                     .ToListAsync();//Transforma em uma lista
            return user.FirstOrDefault(); //retora o primeio da lista
        }



        //Aqui ele faz um busca que contenha o usuario, não precisa ser identico
        public async Task<List<UserEntitie>> SearchByUsuario(string usuario)
        {
            var allUsers = await _context.Users
                                         .Where
                                         (
                                             x => x.Usuario.ToLower().Contains(usuario.ToLower())
                                         )
                                         .AsNoTracking()
                                         .ToListAsync();
            return allUsers;
        }


        //Mesma coisa do usuario, busca que tem nome no meio, não precisa ser identico
        public async Task<List<UserEntitie>> SearchByNome(string nome)
        {
            var allUsers = await _context.Users
                                         .Where
                                         (
                                             x => x.Nome.ToLower().Contains(nome.ToLower())
                                         )
                                         .AsNoTracking()
                                         .ToListAsync();
            return allUsers;
        }
    }
}
