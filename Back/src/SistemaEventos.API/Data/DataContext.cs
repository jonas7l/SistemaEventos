using Microsoft.EntityFrameworkCore;
using SistemaEventos.API.Models;

namespace SistemaEventos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }        
        public DbSet<Evento> Eventos {get; set;}
    }
}