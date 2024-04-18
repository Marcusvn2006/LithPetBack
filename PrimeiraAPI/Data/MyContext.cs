using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.Data
{
    public class MyContext : IdentityDbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Teste> Testes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Teste>().ToTable("Teste");
        }

        public DbSet<PrimeiraAPI.Models.Produto> Produto { get; set; } = default!;

        public DbSet<PrimeiraAPI.Models.Agendamento> Agendamento { get; set; } = default!;

        public DbSet<PrimeiraAPI.Models.Animais> Animais { get; set; } = default!;

        public DbSet<PrimeiraAPI.Models.DetalhesVenda> DetalhesVenda { get; set; } = default!;

        public DbSet<PrimeiraAPI.Models.FornecedorProduto> FornecedorProduto { get; set; } = default!;

        public DbSet<PrimeiraAPI.Models.Funcionario> Funcionario { get; set; } = default!;

        public DbSet<PrimeiraAPI.Models.Servicos> Servicos { get; set; } = default!;

        public DbSet<PrimeiraAPI.Models.Venda> Venda { get; set; } = default!;
    }
}
