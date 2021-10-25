using Microsoft.EntityFrameworkCore;
using WebApiProdutos.Domain.Entities;
using WebApiProdutos.Infra.Mapping;

namespace WebApiProdutos.Infra.Context
{
    public class ProdutosDbContext : DbContext
    {
        public ProdutosDbContext(DbContextOptions<ProdutosDbContext> options) : base(options) { }

        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produtos>(new ProdutosMap().Configure);
        }
    }
}
