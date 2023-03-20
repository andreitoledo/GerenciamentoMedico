﻿// <auto-generated />
using System;
using Cooperchip.ITDeveloper.Data.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cooperchip.ITDeveloper.Data.Migrations
{
    [DbContext(typeof(ITDeveloperDbContext))]
    [Migration("20230303082026_AddGenerico")]
    partial class AddGenerico
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cooperchip.ITDeveloper.Domain.Entities.Mural", b =>
                {
                    b.Property<int>("MuralId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("varchar(90)");

                    b.Property<string>("Aviso")
                        .HasColumnType("varchar(90)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(90)");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(90)");

                    b.HasKey("MuralId");

                    b.ToTable("Mural");
                });

            modelBuilder.Entity("Cooperchip.ITDeveloper.Domain.Models.EstadoPaciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Descricao");

                    b.HasKey("Id");

                    b.ToTable("EstadoPaciente");
                });

            modelBuilder.Entity("Cooperchip.ITDeveloper.Domain.Models.Generico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Nodigo")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(90)");

                    b.HasKey("Id");

                    b.ToTable("Generico");
                });

            modelBuilder.Entity("Cooperchip.ITDeveloper.Domain.Models.Paciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("Cpf")
                        .IsFixedLength(true);

                    b.Property<DateTime>("DataInternacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Email");

                    b.Property<Guid>("EstadoPacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(80)")
                        .HasColumnName("Nome");

                    b.Property<string>("Rg")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("Rg");

                    b.Property<DateTime>("RgDataEmissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("RgOrgao")
                        .HasColumnType("varchar(10)")
                        .HasColumnName("RgOrgao");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<int>("TipoPaciente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoPacienteId");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("Cooperchip.ITDeveloper.Domain.Models.Paciente", b =>
                {
                    b.HasOne("Cooperchip.ITDeveloper.Domain.Models.EstadoPaciente", "EstadoPaciente")
                        .WithMany("Paciente")
                        .HasForeignKey("EstadoPacienteId")
                        .IsRequired();

                    b.Navigation("EstadoPaciente");
                });

            modelBuilder.Entity("Cooperchip.ITDeveloper.Domain.Models.EstadoPaciente", b =>
                {
                    b.Navigation("Paciente");
                });
#pragma warning restore 612, 618
        }
    }
}
