using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Aeronave.Infraestructure.EF.ReadModel;

namespace Aeronave.Infraestructure.EF.Config.ReadConfig
{
    public class AeronaveReadConfig : IEntityTypeConfiguration<AeronaveReadModel>,
        IEntityTypeConfiguration<ControlAeronaveReadModel>
    {
        public void Configure(EntityTypeBuilder<AeronaveReadModel> builder)
        {
            builder.ToTable("Aeronave");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.IdAeronave)
                .HasColumnName("IdAeronave")
                //.HasColumnType("String")
                .HasMaxLength(40);

            builder.Property(x => x.CodAeronave)
                .HasColumnName("CodAeronave")
                .HasColumnType("int");

            builder.Property(x => x.IdAeropuerto)
               .HasColumnName("IdAeropuerto")
               //.HasColumnType("String")
               .HasMaxLength(40);

            /*
            builder.Property(x => x.IdControlAeronave)
              .HasColumnName("IdControlAeronave")
              .HasColumnType("String")
              .HasMaxLength(16);

            builder.Property(x => x.IdAsignacionAeronave)
              .HasColumnName("IdAsignacionAeronave")
              .HasColumnType("String")
              .HasMaxLength(16);
            */
            builder.Property(x => x.TotalNroAsientos)
              .HasColumnName("TotalNroAsientos")
              .HasColumnType("int");

            builder.Property(x => x.EstadoDisponibilidad)
              .HasColumnName("EstadoDisponibilidad")
              //.HasColumnType("String")
              .HasMaxLength(20);

           // builder.HasMany(x => x.ControlAeronave)
            //       .WithOne(x => x.Aeronave);

        }

        public void Configure(EntityTypeBuilder<ControlAeronaveReadModel> builder)
        {
            builder.ToTable("ControlAeronave");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Marca)
                .HasColumnName("Marca")
                .HasMaxLength(500);
            
            builder.Property(x => x.Modelo)
              .HasColumnName("Modelo")
              .HasMaxLength(500);

            builder.Property(x => x.CapacidadCarga)
                .HasColumnName("CapacidadCarga")
                .HasColumnType("decimal")
                .HasPrecision(12, 2);

            builder.Property(x => x.CapTanqueCombustible)
              .HasColumnName("CapTanqueCombustible")
              .HasColumnType("decimal")
              .HasPrecision(12, 2);

            builder.Property(x => x.AereopuertoEstacionamiento)
              .HasColumnName("AereopuertoEstacionamiento")
              .HasMaxLength(500);

            builder.Property(x => x.EstadoFuncionalAeronave)
             .HasColumnName("EstadoFuncionalAeronave")
             .HasMaxLength(500);

            builder.Property(x => x.AsientosAsignados)
             .HasColumnName("AsientosAsignados")
             .HasColumnType("int");
          
        }
    }
}


