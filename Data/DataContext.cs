using Microsoft.EntityFrameworkCore;
using RotaLimpa.Api.Models;

namespace RotaLimpa.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<CEP> CEPs { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Frota> Frotas { get; set; }
        public DbSet<Kilometragem> Kilometragens { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<Ocorrencia> Ocorrencias { get; set; }
        public DbSet<Periodo> Periodos { get; set; }
        public DbSet<Rota> Rotas { get; set; }
        public DbSet<Rua> Ruas { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<SetorVeiculo> SetorVeiculos { get; set; }
        public DbSet<Trajeto> Trajetos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Funcionario>()
                .HasOne(f => f.Empresa)
                .WithMany();*/
            modelBuilder.Entity<CEP>().HasKey(e => e.Id_Cep);
            modelBuilder.Entity<Colaborador>().HasKey(e => e.Id);
            modelBuilder.Entity<Empresa>().HasKey(e => e.Id);
            modelBuilder.Entity<Frota>().HasKey(e => e.Id_Veiculo);
            modelBuilder.Entity<Kilometragem>().HasKey(e => e.Id_Veiculo);
            modelBuilder.Entity<Motorista>().HasKey(e => e.Id_Motorista);
            modelBuilder.Entity<Ocorrencia>().HasKey(e => e.Id_Ocorrencia);
            modelBuilder.Entity<Periodo>().HasKey(e => e.Id_Periodo);
            modelBuilder.Entity<Rota>().HasKey(e => e.Id_Rota);
            modelBuilder.Entity<Rua>().HasKey(e => e.Id_Ruas);
            modelBuilder.Entity<Setor>().HasKey(e => e.Id_Setor);
            modelBuilder.Entity<SetorVeiculo>().HasKey(e => new { e.Id_Setor, e.Id_Veiculo });
            modelBuilder.Entity<Trajeto>().HasKey(e => e.Id_Trajeto);

            modelBuilder.Entity<CEP>().HasIndex(e => e.Cep).IsUnique();
            modelBuilder.Entity<Colaborador>().HasIndex(e => e.Nome).IsUnique();

        }

    }
}