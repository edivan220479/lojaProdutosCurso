using lojaProdutosCurso.Models;
using Microsoft.EntityFrameworkCore;

namespace lojaProdutosCurso.Data
{
    public class DataContext : DbContext    
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ProdutoModel> Produtos { get; set; }

        //Vamos criar essa tabela já com informações
        public DbSet<CategoriaModel> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaModel>().HasData(
                new CategoriaModel { Id = 1, Nome = "Tenis" },
                new CategoriaModel { Id = 2, Nome = "Botas" },
                new CategoriaModel { Id = 3, Nome = "Chinelos" },
                new CategoriaModel { Id = 4, Nome = "Sandalias" },
                new CategoriaModel { Id = 5, Nome = "Sapatos" }
            );
            base.OnModelCreating(modelBuilder);
        }

    }
}
