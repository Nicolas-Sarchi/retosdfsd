using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class JugadorConfiguration: IEntityTypeConfiguration<Jugador>
{
    public void Configure(EntityTypeBuilder<Jugador> builder)
    {
        builder.ToTable("jugador");

        builder.Property(p => p.Dorsal)
        .IsRequired()
        .HasColumnType("int");

        
    }
}
