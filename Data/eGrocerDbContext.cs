using eGrocer.Models;
using Microsoft.EntityFrameworkCore;

namespace eGrocer.Data
{
    public class eGrocerDbContext : DbContext
    {
        public eGrocerDbContext(DbContextOptions<eGrocerDbContext> options) : base(options)
        {
        }

        public DbSet<Carrinhos> Carrinhos { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Encomendas> Encomendas { get; set; }
        public DbSet<Utilizadores> Utilizadores { get; set; }
        public DbSet<CarrinhosProdutos> CarrinhosProdutos { get; set; }
        public DbSet<ProdutosEncomendas> ProdutosEncomendas { get; set; }
    }
}
