using SiteGabriel.Business.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteGabriel.Infra.Data.Mappings
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            HasKey(p => p.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(1000);

            Property(p => p.Imagem)
                .IsRequired();

            HasRequired(p => p.Fornecedor)
                .WithMany(f=>f.Produtos)
                .HasForeignKey(f=>f.FornecedorId);
            
            ToTable("Produtos");
        }
    }
}
