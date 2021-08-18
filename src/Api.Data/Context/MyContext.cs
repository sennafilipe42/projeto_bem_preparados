using Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Usuarios> MyProperty { get; set; }


    }
}
