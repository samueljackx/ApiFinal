using CotacaoMoeda.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CotacaoMoeda.Context
{
    public class MoneyContext : DbContext
    {
        public MoneyContext(DbContextOptions<MoneyContext> options) : base(options) { }
        public DbSet<Moeda> Moedas { get; set; }
        public DbSet<Cotacao> Cotacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
 
