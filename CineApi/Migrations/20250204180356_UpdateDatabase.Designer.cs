﻿// <auto-generated />
using CineApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CineApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250204180356_UpdateDatabase")]
    partial class UpdateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CineApi.Models.Assinatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Desconto")
                        .HasColumnType("numeric");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Preco")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Assinaturas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Desconto = 0m,
                            Nome = "Iniciante",
                            Preco = 0m
                        },
                        new
                        {
                            Id = 2,
                            Desconto = 0.15m,
                            Nome = "Cinéfilo",
                            Preco = 20m
                        },
                        new
                        {
                            Id = 3,
                            Desconto = 0.25m,
                            Nome = "Fanático",
                            Preco = 50m
                        },
                        new
                        {
                            Id = 4,
                            Desconto = 0.50m,
                            Nome = "Diretor",
                            Preco = 100m
                        });
                });

            modelBuilder.Entity("CineApi.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("PrecoIngresso")
                        .HasColumnType("numeric");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("CineApi.Models.FilmeProgramacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CinemaId")
                        .HasColumnType("integer");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Duracao")
                        .HasColumnType("integer");

                    b.Property<string>("FilmeNome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Horario")
                        .HasColumnType("integer");

                    b.Property<string>("Sala")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.ToTable("Programacoes");
                });

            modelBuilder.Entity("CineApi.Models.Ingresso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Assentos")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CinemaNome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FilmeData")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FilmeNome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sala")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Ingressos");
                });

            modelBuilder.Entity("CineApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AssinaturaId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AssinaturaId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CineApi.Models.FilmeProgramacao", b =>
                {
                    b.HasOne("CineApi.Models.Cinema", null)
                        .WithMany("Programacao")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CineApi.Models.User", b =>
                {
                    b.HasOne("CineApi.Models.Assinatura", "Assinatura")
                        .WithMany()
                        .HasForeignKey("AssinaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assinatura");
                });

            modelBuilder.Entity("CineApi.Models.Cinema", b =>
                {
                    b.Navigation("Programacao");
                });
#pragma warning restore 612, 618
        }
    }
}
