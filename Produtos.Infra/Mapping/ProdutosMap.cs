using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiProdutos.Domain.Entities;

namespace WebApiProdutos.Infra.Mapping
{
    public class ProdutosMap : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder)
        {
            builder.ToTable("Produtos");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Descricao)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Descricao")
                .HasColumnType("varchar(200)");

            builder.Property(prop => prop.ValorUnitario)
                .IsRequired()
                .HasColumnName("ValorUnitario")
                .HasPrecision(25, 10);

            builder.Property(prop => prop.DataCadastro)
                .HasConversion(prop => prop, prop => prop)
                .IsRequired()
                .HasColumnName("DataCadastro");

            builder.Property(prop => prop.Quantidade)
                .IsRequired()
                .HasColumnName("Quantidade")
                .HasPrecision(25, 10);

            builder.Property(prop => prop.Tipo)
                .HasConversion(prop => prop.ToInt(), prop => prop)
                .IsRequired()
                .HasColumnName("Tipo");
        }
    }
}