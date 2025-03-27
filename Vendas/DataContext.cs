using Microsoft.EntityFrameworkCore;
using Vendas.Models.Produtos;
using Vendas.Models.Clientes;

namespace Vendas
{
    public class DataContext : DbContext
    {
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<GrupoProduto> GrupoProdutos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<GrupoCliente> GrupoClientes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }


        public DataContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connection = "Server=localhost;Database=loja;Uid=root;Pwd=1234;";
            options.UseMySql(connection, ServerVersion.AutoDetect(connection));
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marca>()
                .HasMany(e => e.Produtos)
                .WithOne(e => e.Marca)
                .HasForeignKey(e => e.MarcaId)
                .HasPrincipalKey(e => e.Id);

            modelBuilder.Entity<GrupoProduto>()
                .HasMany(e => e.Produtos)
                .WithOne(e => e.Grupo)
                .HasForeignKey(e => e.GrupoId)
                .HasPrincipalKey(e => e.Id);

            modelBuilder.Entity<GrupoCliente>()
                .HasMany(e => e.Clientes)
                .WithOne(e => e.Grupo)
                .HasForeignKey(e => e.GrupoId)
                .HasPrincipalKey(e => e.Id);
        }
    }
}
