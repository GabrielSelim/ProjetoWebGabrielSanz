﻿using SiteGabriel.Business.Models.Fornecedores;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace SiteGabriel.Infra.Data.Mappings
{
    public class FornecedorMap : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorMap()
        {
            HasKey(f => f.Id);
            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(f => f.Documento)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute {IsUnique = true }));

            HasRequired(f => f.Endereco)
                .WithRequiredPrincipal(e=>e.Fornecedor);

            ToTable("Fornecedores");
        }
    }
}
