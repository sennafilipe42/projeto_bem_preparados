using Infra.Context;
using System.Threading.Tasks;
using Domain.Entities;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntitie
    {
        private readonly ContextBase _context;

        //Recebe por injeção de dependencia a classe contexto
        //classe que faz as operações no EFCore
        public BaseRepository(ContextBase context)
        {
            _context = context;
        }


        //metodos genericos


        //metodo virtual pode ser subscrito
        //se tiver muitas entidades, pode se usa outras formas de inserção



        //Metodo Create, usa o contexto para add a entidade, depois salva ele
        //no EFCore os objetos são trackeados, banco de dados gera o id
        public virtual async Task<T> Create(T obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();

            return obj;
        }


        //objeto é trackeado, então quando usa o Entry.State, 
        // informa que o estado dele é alterado e faz o update no BD
        public virtual async Task<T> Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return obj;
        }


        //Pega o obj e verifica se existe, se existe(diferente de nullo)
        // ele vai no bd e remove
        public virtual async Task Remove(long id)
        {
            var obj = await Get(id);

            if (obj != null)
            {

                _context.Remove(obj);
                await _context.SaveChangesAsync();
            }
        }


        //seta o obj e coloca para não trackear
        // no metodo Get não precisa trackear
        //tornando mais leve a utilização
        public virtual async Task<T> Get(long id)
        {
            var obj = await _context.Set<T>()
                                    .AsNoTracking() //não precisa trackear
                                    .Where(x => x.Id == id) //id for igual id repassado 
                                    .ToListAsync();
            return obj.FirstOrDefault(); //retorna o primeiro da lista
        }


        //retira o tracking do Get e volta a lista completa(SELECT *)
        public virtual async Task<List<T>> Get()
        {
            return await _context.Set<T>()
                                 .AsNoTracking()
                                 .ToListAsync();
        }

    }
}
