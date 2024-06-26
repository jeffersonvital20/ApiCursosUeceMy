﻿// <auto-generated />
using System;
using ApiCursosUeceMy.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiCursosUeceMy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240601232921_initialMigrate")]
    partial class initialMigrate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiCursosUeceMy.Domain.Model.Aula", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("uuid");

                    b.Property<string>("Duracao")
                        .HasColumnType("text");

                    b.Property<string>("IdRecursoStream")
                        .HasColumnType("text");

                    b.Property<int>("Ordem")
                        .HasColumnType("integer");

                    b.Property<string>("Titulo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("Aula");
                });

            modelBuilder.Entity("ApiCursosUeceMy.Domain.Model.Curso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<string>("NomeInstrutor")
                        .HasColumnType("text");

                    b.Property<decimal>("Preco")
                        .HasColumnType("numeric");

                    b.Property<int>("QtdAulas")
                        .HasColumnType("integer");

                    b.Property<string>("Titulo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("ApiCursosUeceMy.Domain.Model.Aula", b =>
                {
                    b.HasOne("ApiCursosUeceMy.Domain.Model.Curso", "Curso")
                        .WithMany("Aulas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("ApiCursosUeceMy.Domain.Model.Curso", b =>
                {
                    b.Navigation("Aulas");
                });
#pragma warning restore 612, 618
        }
    }
}
