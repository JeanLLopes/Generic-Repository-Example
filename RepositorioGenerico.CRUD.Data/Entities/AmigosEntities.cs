using System.Data.Entity.Migrations.Model;
using System.Data.Entity.ModelConfiguration;
using RepositorioGenerico.CRUD.Model.Models;

namespace RepositorioGenerico.CRUD.Data.Entities
{
    public class AmigosEntities : EntityTypeConfiguration<AmigosModel>
    {
        public AmigosEntities()
        {
            ToTable("TB_AMIGOS");

            HasKey(x => x.Id);

            Property(x => x.Nome).HasColumnName("NOME").HasColumnType("Varchar").HasMaxLength(50).IsRequired();
            Property(x => x.Rg).HasColumnName("RG").HasColumnType("Varchar").HasMaxLength(20).IsRequired();
            Property(x => x.Telefone).HasColumnName("TELEFONE").HasColumnType("Varchar").HasMaxLength(15).IsRequired();
            Property(x => x.DataNascimento).HasColumnName("DT_NASCIMENTO").IsRequired();
            Property(x => x.Email).HasColumnName("EMAIL").HasColumnType("Varchar").HasMaxLength(50).IsRequired();
            Property(x => x.Cpf).HasColumnName("CPF").HasColumnType("Varchar").HasMaxLength(30).IsRequired();

        }
    }
}
