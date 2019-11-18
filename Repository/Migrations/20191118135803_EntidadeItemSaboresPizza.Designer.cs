﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.DATA;

namespace Repository.Migrations
{
    [DbContext(typeof(PizzariaContext))]
    [Migration("20191118135803_EntidadeItemSaboresPizza")]
    partial class EntidadeItemSaboresPizza
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Bebida", b =>
                {
                    b.Property<int>("BebidaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Nome");

                    b.Property<double>("Preco");

                    b.HasKey("BebidaId");

                    b.ToTable("Bebidas");
                });

            modelBuilder.Entity("Domain.Models.Cargo", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<double>("Salario");

                    b.HasKey("CargoId");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("Domain.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Localidade");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Uf");

                    b.HasKey("EnderecoId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Domain.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CargoId");

                    b.Property<string>("Cpf");

                    b.Property<string>("Nome");

                    b.HasKey("FuncionarioId");

                    b.HasIndex("CargoId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Domain.Models.ItemSabor", b =>
                {
                    b.Property<int>("ItemSaborId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PizzaId");

                    b.Property<int?>("SaborId");

                    b.HasKey("ItemSaborId");

                    b.HasIndex("PizzaId");

                    b.HasIndex("SaborId");

                    b.ToTable("ItemSabores");
                });

            modelBuilder.Entity("Domain.Models.Pizza", b =>
                {
                    b.Property<int>("PizzaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("TamanhoId");

                    b.HasKey("PizzaId");

                    b.HasIndex("TamanhoId");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("Domain.Models.Sabor", b =>
                {
                    b.Property<int>("SaborId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Nome");

                    b.HasKey("SaborId");

                    b.ToTable("Sabores");
                });

            modelBuilder.Entity("Domain.Models.Tamanho", b =>
                {
                    b.Property<int>("TamanhoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<double>("Preco");

                    b.Property<int>("QtdSabores");

                    b.HasKey("TamanhoId");

                    b.ToTable("Tamanhos");
                });

            modelBuilder.Entity("Domain.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<int?>("EnderecoId");

                    b.Property<string>("Senha");

                    b.HasKey("UsuarioId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Domain.Models.Funcionario", b =>
                {
                    b.HasOne("Domain.Models.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId");
                });

            modelBuilder.Entity("Domain.Models.ItemSabor", b =>
                {
                    b.HasOne("Domain.Models.Pizza")
                        .WithMany("itemSabores")
                        .HasForeignKey("PizzaId");

                    b.HasOne("Domain.Models.Sabor", "Sabor")
                        .WithMany()
                        .HasForeignKey("SaborId");
                });

            modelBuilder.Entity("Domain.Models.Pizza", b =>
                {
                    b.HasOne("Domain.Models.Tamanho", "Tamanho")
                        .WithMany()
                        .HasForeignKey("TamanhoId");
                });

            modelBuilder.Entity("Domain.Models.Usuario", b =>
                {
                    b.HasOne("Domain.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");
                });
#pragma warning restore 612, 618
        }
    }
}
