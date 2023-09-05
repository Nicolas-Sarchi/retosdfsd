using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class TipoNominaConfiguration : IEntityTypeConfiguration<TipoNomina>
{
    public void Configure(EntityTypeBuilder<TipoNomina> builder)
    {
        builder.ToTable("tipo_nomina");

        builder.Property(tn => tn.Nombre)
        .IsRequired()
        .HasMaxLength(50);
    }
}
