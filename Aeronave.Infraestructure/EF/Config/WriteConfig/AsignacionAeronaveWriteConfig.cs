using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Model.Aeronaves.ValueObjects;

namespace Aeronave.Infraestructure.EF.Config.WriteConfig
{
 

    public class AsignacionAeronaveWriteConfig : IEntityTypeConfiguration<AsignacionAeronave>
    {
        public void Configure(EntityTypeBuilder<AsignacionAeronave> builder)
        {
            builder.ToTable("AsignacionAeronave");
            builder.HasKey(x => x.Id);


            builder.Property(x => x.IdAsignacionAeronave)
             .HasColumnName("IdAsignacionAeronave")
             .HasColumnType("String")
             .HasMaxLength(16);

            builder.Property(x => x.IdAeronave)
            .HasColumnName("IdAeronave")
            .HasColumnType("String")
            .HasMaxLength(16);

            builder.Property(x => x.IdVuelo)
           .HasColumnName("IdVuelo")
           .HasColumnType("String")
           .HasMaxLength(16);


            var NroAsientosAeronaveConverter = new ValueConverter<NroAsientosValue, int>(
             NroAsientosAeronaveValue => NroAsientosAeronaveValue.Value,
             nroAsientosAeronave => new NroAsientosValue(nroAsientosAeronave)
         );

            builder.Property(x => x.NroAsientosAeronave)
                .HasConversion(NroAsientosAeronaveConverter)
                .HasColumnName("NroAsientosAeronave")
                .HasColumnType("int");


            var EstadoAsignacionConverter = new ValueConverter<AeronaveEstadoAsignacion, string>(
             EstadoAsignacionValue => EstadoAsignacionValue.Value,
             estadoAsignacion => new AeronaveEstadoAsignacion(estadoAsignacion)
         );

            builder.Property(x => x.EstadoAsignacion)
                .HasConversion(EstadoAsignacionConverter)
                .HasColumnName("EstadoAsignacion")
                .HasColumnType("String")
                .HasMaxLength(20);

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
                        
        }
    }
}
