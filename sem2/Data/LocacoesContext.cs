using Microsoft.EntityFrameworkCore;
using sem2.Models;

namespace sem2.Data
{
    public class LocacoesContext : DbContext
    {
        public LocacoesContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
    }
}
