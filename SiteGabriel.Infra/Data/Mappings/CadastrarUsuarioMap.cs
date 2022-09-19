using SiteGabriel.Business.Models.CadastroUsuario;
using System.Data.Entity.ModelConfiguration;

namespace SiteGabriel.Infra.Data.Mappings
{
    public class CadastrarUsuarioMap : EntityTypeConfiguration<CadastrarUsuario>
    {
        public CadastrarUsuarioMap()
        {
            HasKey(p => p.Id);

            Property(c => c.Nome)
                    .IsRequired()
                    .HasMaxLength(200);

            Property(c => c.Sexo)
                .IsRequired();

            Property(c => c.Peso)
                    .IsRequired()
                    .HasPrecision(5,2);

            Property(c => c.Altura)
                    .IsRequired()
                    .HasPrecision(3, 2);

            Property(c => c.Cpf)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength();

            Property(c => c.Telefone)
                    .IsRequired();

            Property(c => c.GorduraCorporal)
                    .IsRequired()
                    .HasPrecision(4, 2);

            Property(c => c.Imc)
                    .IsRequired()
                    .HasPrecision(4, 2);

            ToTable("UsuarioDados");
        }
    }
}
