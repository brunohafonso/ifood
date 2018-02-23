using Microsoft.EntityFrameworkCore;
using senai.ifood.domain.entities;

namespace senai.ifood.repository.Context
{
    public class IFoodContext : DbContext
    {
        public IFoodContext(DbContextOptions<IFoodContext> options) : base(options) { }

        public DbSet<UsuarioDomain> Usuarios { get; set; }
        public DbSet<UsuarioPermissaoDomain> UsuariosPermissoes { get; set; }
        public DbSet<PermissoesDomain> Permissoes { get; set; }
        public DbSet<RestauranteDomain> Restaurantes { get; set; }
        public DbSet<EspecialidadeDomain> Especialidades { get; set; }
        public DbSet<ProdutoRestauranteDomain> ProdutosRestaurantes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioDomain>().ToTable("Usuarios");
            modelBuilder.Entity<UsuarioPermissaoDomain>().ToTable("UsuariosPermissoes");
            modelBuilder.Entity<PermissoesDomain>().ToTable("Permissoes");
            modelBuilder.Entity<RestauranteDomain>().ToTable("Restaurantes");
            modelBuilder.Entity<EspecialidadeDomain>().ToTable("Especialidades");
            modelBuilder.Entity<ProdutoRestauranteDomain>().ToTable("ProdutosRestaurantes");

            base.OnModelCreating(modelBuilder);
        }
    }
}