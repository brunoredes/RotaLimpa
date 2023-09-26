﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RotaLimpa.Api.Data;

#nullable disable

namespace RotaLimpa.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RotaLimpa.Api.Models.CEP", b =>
                {
                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cep");

                    b.ToTable("CEP");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Dc_Colaborador")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)")
                        .HasColumnName("dbColaborador");

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<int>("Empresa_Id")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("Nome");

                    b.Property<string>("St_Colaborador")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("stColaborador");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("Empresa_Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Colaboradores");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Da_Empresa")
                        .HasColumnType("datetime2")
                        .HasColumnName("da_empresa")
                        .HasComment("DATA DA ULTIMA ALTERAÇÃO");

                    b.Property<string>("Dc_Empresa")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)")
                        .HasColumnName("dc_empresa")
                        .HasComment("CNPJ");

                    b.Property<DateTime>("Di_Empresa")
                        .HasColumnType("datetime2")
                        .HasColumnName("di_empresa")
                        .HasComment("DATA DE INCLUSÃO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("Nome");

                    b.Property<int>("St_Empresa")
                        .HasColumnType("int")
                        .HasColumnName("st_empresa")
                        .HasComment("SITUAÇÃO DA EMPRESA");

                    b.HasKey("Id");

                    b.HasIndex("Dc_Empresa")
                        .IsUnique();

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Frota", b =>
                {
                    b.Property<int>("Id_Veiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Veiculo"));

                    b.Property<DateTime>("Di_Veiculo")
                        .HasColumnType("datetime2");

                    b.Property<string>("P_Veiculo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("St_Veiculo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Tmn_Veiculo")
                        .HasColumnType("real");

                    b.HasKey("Id_Veiculo");

                    b.ToTable("Frotas");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Kilometragem", b =>
                {
                    b.Property<int>("Id_Veiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Veiculo"));

                    b.Property<DateTime>("Di_Kilometragem")
                        .HasColumnType("datetime2")
                        .HasColumnName("diKilometragem")
                        .HasComment("Data de início marcação");

                    b.Property<int>("FrotaId_Veiculo")
                        .HasColumnType("int");

                    b.Property<int>("Km")
                        .HasColumnType("int")
                        .HasColumnName("Kilometragem");

                    b.Property<string>("Se_Kilometragem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("seKilometragem")
                        .HasComment("Sentido da Marcação");

                    b.HasKey("Id_Veiculo");

                    b.HasIndex("FrotaId_Veiculo");

                    b.ToTable("Kilometragens");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Motorista", b =>
                {
                    b.Property<int>("Id_Motorista")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Motorista"));

                    b.Property<DateTime>("Dc_Motorista")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nm_Motorista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("St_Motorista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Motorista");

                    b.ToTable("Motoristas");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Ocorrencia", b =>
                {
                    b.Property<int>("Id_Ocorrencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdOcorrencia");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Ocorrencia"));

                    b.Property<int>("Id_TrajetoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Mt_Ocorrencia")
                        .HasColumnType("datetime2")
                        .HasColumnName("mtOcorrencia")
                        .HasComment("Momento da ocorrencia");

                    b.Property<int>("Tipo_Ocorrencia")
                        .HasColumnType("int");

                    b.HasKey("Id_Ocorrencia");

                    b.HasIndex("Id_Ocorrencia")
                        .IsUnique();

                    b.HasIndex("Id_TrajetoId");

                    b.ToTable("Ocorrencias");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Periodo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ds_Periodo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mf_Periodo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mi_Periodo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Periodos");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Rota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdRota");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Dt_Rota")
                        .HasColumnType("int")
                        .HasColumnName("dtRota")
                        .HasComment("Distancia da Rota");

                    b.Property<int>("Id_Colaborador")
                        .HasColumnType("int");

                    b.Property<int>("Id_Periodo")
                        .HasColumnType("int");

                    b.Property<int>("Id_Setor")
                        .HasColumnType("int");

                    b.Property<int?>("SetorId")
                        .HasColumnType("int");

                    b.Property<int>("Tm_Rota")
                        .HasColumnType("int")
                        .HasColumnName("tmRota")
                        .HasComment("Tempo médio da Rota");

                    b.HasKey("Id");

                    b.HasIndex("Id_Colaborador");

                    b.HasIndex("Id_Periodo");

                    b.HasIndex("SetorId");

                    b.ToTable("Rotas");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Rua", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Cep1");

                    b.ToTable("Ruas");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Setor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Da_Setor")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Di_Setor")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<int>("Id_Colaborador")
                        .HasColumnType("int");

                    b.Property<int>("Id_Empresa")
                        .HasColumnType("int");

                    b.Property<string>("St_Setor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoServico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("Id_Colaborador");

                    b.HasIndex("Id_Empresa");

                    b.ToTable("Setores");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.SetorVeiculo", b =>
                {
                    b.Property<int>("Id_Setor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Setor"));

                    b.Property<int>("FrotaId_Veiculo")
                        .HasColumnType("int");

                    b.Property<int>("Id_Veiculo")
                        .HasColumnType("int");

                    b.Property<int>("SetorId")
                        .HasColumnType("int");

                    b.HasKey("Id_Setor");

                    b.HasIndex("FrotaId_Veiculo");

                    b.HasIndex("SetorId");

                    b.ToTable("SetorVeiculos");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Trajeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idTrajeto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Id_Motorista1")
                        .HasColumnType("int");

                    b.Property<int>("Id_RotaId")
                        .HasColumnType("int");

                    b.Property<int>("Id_Veiculo1")
                        .HasColumnType("int");

                    b.Property<DateTime>("Mi_Trajeto")
                        .HasColumnType("datetime2")
                        .HasComment("Momento de início do trajeto");

                    b.Property<DateTime>("Mj_Trajeto")
                        .HasColumnType("datetime2")
                        .HasComment("Momento do fim do trajeto");

                    b.HasKey("Id");

                    b.HasIndex("Id_Motorista1");

                    b.HasIndex("Id_RotaId");

                    b.HasIndex("Id_Veiculo1");

                    b.ToTable("Trajetos");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Colaborador", b =>
                {
                    b.HasOne("RotaLimpa.Api.Models.Empresa", null)
                        .WithMany("Colaboradores")
                        .HasForeignKey("EmpresaId");

                    b.HasOne("RotaLimpa.Api.Models.Empresa", "Empresas")
                        .WithMany()
                        .HasForeignKey("Empresa_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Empresas");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Kilometragem", b =>
                {
                    b.HasOne("RotaLimpa.Api.Models.Frota", "Frota")
                        .WithMany()
                        .HasForeignKey("FrotaId_Veiculo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Frota");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Ocorrencia", b =>
                {
                    b.HasOne("RotaLimpa.Api.Models.Trajeto", "Id_Trajeto")
                        .WithMany()
                        .HasForeignKey("Id_TrajetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Id_Trajeto");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Rota", b =>
                {
                    b.HasOne("RotaLimpa.Api.Models.Colaborador", "Colaborador")
                        .WithMany("Rotas")
                        .HasForeignKey("Id_Colaborador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RotaLimpa.Api.Models.Periodo", "Periodo")
                        .WithMany("Rotas")
                        .HasForeignKey("Id_Periodo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RotaLimpa.Api.Models.Setor", null)
                        .WithMany("Rotas")
                        .HasForeignKey("SetorId");

                    b.Navigation("Colaborador");

                    b.Navigation("Periodo");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Rua", b =>
                {
                    b.HasOne("RotaLimpa.Api.Models.CEP", null)
                        .WithMany("Ruas")
                        .HasForeignKey("Cep1");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Setor", b =>
                {
                    b.HasOne("RotaLimpa.Api.Models.Empresa", null)
                        .WithMany("Setores")
                        .HasForeignKey("EmpresaId");

                    b.HasOne("RotaLimpa.Api.Models.Colaborador", "Colaborador")
                        .WithMany("Setores")
                        .HasForeignKey("Id_Colaborador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RotaLimpa.Api.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("Id_Empresa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colaborador");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.SetorVeiculo", b =>
                {
                    b.HasOne("RotaLimpa.Api.Models.Frota", "Frota")
                        .WithMany()
                        .HasForeignKey("FrotaId_Veiculo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RotaLimpa.Api.Models.Setor", "Setor")
                        .WithMany()
                        .HasForeignKey("SetorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Frota");

                    b.Navigation("Setor");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Trajeto", b =>
                {
                    b.HasOne("RotaLimpa.Api.Models.Motorista", "Id_Motorista")
                        .WithMany()
                        .HasForeignKey("Id_Motorista1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RotaLimpa.Api.Models.Rota", "Id_Rota")
                        .WithMany()
                        .HasForeignKey("Id_RotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RotaLimpa.Api.Models.Frota", "Id_Veiculo")
                        .WithMany()
                        .HasForeignKey("Id_Veiculo1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Id_Motorista");

                    b.Navigation("Id_Rota");

                    b.Navigation("Id_Veiculo");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.CEP", b =>
                {
                    b.Navigation("Ruas");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Colaborador", b =>
                {
                    b.Navigation("Rotas");

                    b.Navigation("Setores");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Empresa", b =>
                {
                    b.Navigation("Colaboradores");

                    b.Navigation("Setores");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Periodo", b =>
                {
                    b.Navigation("Rotas");
                });

            modelBuilder.Entity("RotaLimpa.Api.Models.Setor", b =>
                {
                    b.Navigation("Rotas");
                });
#pragma warning restore 612, 618
        }
    }
}
