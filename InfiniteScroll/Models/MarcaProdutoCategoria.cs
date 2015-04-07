using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace InfiniteScroll.Models
{
    public class MarcaProdutoCategoria
    {
        public string Id { get; set; }

        public string Marca { get; set; }

        public string Produto { get; set; }

        public string Categoria { get; set; }

        public string Caracteristica { get; set; }

        public string Caminho { get; set; }
    }

    public class EfDbContext : DbContext
    {
        public DbSet<MarcaProdutoCategoria> Produtos { get; set; }
       


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<MarcaProdutoCategoria>().ToTable("MarcaProdutoCategoria");
        }

    }
}