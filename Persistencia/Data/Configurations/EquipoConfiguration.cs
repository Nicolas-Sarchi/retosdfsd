using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class EquipoConfiguration: IEntityTypeConfiguration<Equipo>
{
    public void Configure(EntityTypeBuilder<Equipo> builder)
    {
        builder.ToTable("equipos");

        builder.Property(p => p.NombreEquipo)
        .IsRequired()
        .HasMaxLength(100);

        builder.HasOne(p => p.Pais).WithMany(e => e.Equipos).HasForeignKey(e => e.IdPaisFk);

    }
}
