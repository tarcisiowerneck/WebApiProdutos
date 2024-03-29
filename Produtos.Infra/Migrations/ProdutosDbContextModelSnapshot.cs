﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiProdutos.Infra.Context;

namespace WebApiProdutos.Infra.Migrations
{
    [DbContext(typeof(ProdutosDbContext))]
    partial class ProdutosDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiProdutos.Domain.Entities.Produtos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataCadastro");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Descricao");

                    b.Property<decimal>("Quantidade")
                        .HasPrecision(25, 10)
                        .HasColumnType("decimal(25,10)")
                        .HasColumnName("Quantidade");

                    b.Property<int>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("Tipo");

                    b.Property<decimal>("ValorUnitario")
                        .HasPrecision(25, 10)
                        .HasColumnType("decimal(25,10)")
                        .HasColumnName("ValorUnitario");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
