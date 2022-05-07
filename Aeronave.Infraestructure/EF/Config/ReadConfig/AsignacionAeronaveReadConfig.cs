using Aeronave.Infraestructure.EF.ReadModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronave.Infraestructure.EF.Config.ReadConfig
{
     public class AsignacionAeronaveReadConfig : IEntityTypeConfiguration<AsignacionAeronaveReadModel>
    {
        public void Configure(EntityTypeBuilder<AsignacionAeronaveReadModel> builder)
        {
            builder.ToTable("AsignacionAeronave");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.IdAsignacionAeronave)
                .HasColumnName("IdAsignacionAeronave")                
                .HasMaxLength(40);

            builder.Property(x => x.IdAeronave)
               .HasColumnName("IdAeronave")               
               .HasMaxLength(40);

            builder.Property(x => x.IdVuelo)
               .HasColumnName("IdVuelo")               
               .HasMaxLength(40);

            builder.Property(x => x.NroAsientosAeronave)
               .HasColumnName("NroAsientosAeronave")
               .HasColumnType("int");

            builder.Property(x => x.EstadoAsignacion)
               .HasColumnName("EstadoAsignacion")               
               .HasMaxLength(20);

    }
}
}
