using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.ValueObjects;
using Aeronaves.Domain.Model.Aeronaves.ValueObjects;

namespace Aeronave.Infraestructure.EF.Config.WriteConfig
{

    public class AeronaveWriteConfig : IEntityTypeConfiguration<Aeronaves.Domain.Model.Aeronaves.Aeronave>,
       IEntityTypeConfiguration<Aeronaves.Domain.Model.Aeronaves.ControlAeronave>
    {
      
        public void Configure(EntityTypeBuilder<Aeronaves.Domain.Model.Aeronaves.Aeronave> builder)
        {
            builder.ToTable("Aeronave");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CodAeronave)
                   .HasColumnName("CodAeronave")
                   .HasColumnType("int");

            builder.Property(x => x.IdAeropuerto)
              .HasColumnName("IdAeropuerto")            
              .HasMaxLength(16);
                      
            var TotalNroAsientosConverter = new ValueConverter<NroAsientosValue, int>(
                TotalNroAsientosValue => TotalNroAsientosValue.Value,
                totalNroAsientos => new NroAsientosValue(totalNroAsientos)
            );

            builder.Property(x => x.TotalNroAsientos)
               .HasConversion(TotalNroAsientosConverter)
               .HasColumnName("totalNroAsientos")
               .HasColumnType("int");


            var estadoDisponibilidadConverter = new ValueConverter<AeronaveEstadoDisponibilidad, string>(
               estadoDisponibilidadValue => estadoDisponibilidadValue.Value,
               estadoDisponibilidad => new AeronaveEstadoDisponibilidad(estadoDisponibilidad)
            );

            builder.Property(x => x.EstadoDisponibilidad)
               .HasConversion(estadoDisponibilidadConverter)
               .HasColumnName("EstadoDisponibilidad")               
               .HasMaxLength(20);

            //builder.HasMany(typeof(ControlAeronave), "_ControlAeronave");            
            //builder.HasMany<ControlAeronave>().WithMany("_ControlAeronave");
        

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
            builder.Ignore(x => x.AeronaveControl);
            builder.Ignore(x => x.AeronaveAsignacion);            
            builder.Ignore(x => x.IdVuelo);
        }

        public void Configure(EntityTypeBuilder<ControlAeronave> builder)
        {
            builder.ToTable("ControlAeronave");
            builder.HasKey(x => x.Id);


            builder.Property(x => x.IdAeronave)
            .HasColumnName("IdAeronave")
            //.HasColumnType("String")
            .HasMaxLength(16);

            builder.Property(x => x.Marca)
            .HasColumnName("Marca")
            //.HasColumnType("String")
            .HasMaxLength(30);

            builder.Property(x => x.Modelo)
            .HasColumnName("Modelo")
            //.HasColumnType("String")
            .HasMaxLength(30);


            var CapacidadCargaConverter = new ValueConverter<RegistroDecimalValue, decimal>(
                CapacidadCargaValue => CapacidadCargaValue.Value,
                capacidadCarga => new RegistroDecimalValue(capacidadCarga)
            );

            builder.Property(x => x.CapacidadCarga)
                .HasConversion(CapacidadCargaConverter)
                .HasColumnName("CapacidadCarga")
                .HasPrecision(12, 2);

            var CapTanqueCombustibleConverter = new ValueConverter<RegistroDecimalValue, decimal>(
               CapTanqueCombustibleValue => CapTanqueCombustibleValue.Value,
               capTanqueCombustible => new RegistroDecimalValue(capTanqueCombustible)
           );

            builder.Property(x => x.CapTanqueCombustible)
                .HasConversion(CapTanqueCombustibleConverter)
                .HasColumnName("capTanqueCombustible")
                .HasPrecision(12, 2);

            builder.Property(x => x.AereopuertoEstacionamiento)
                .HasColumnName("AereopuertoEstacionamiento")
                //.HasColumnType("String")
                .HasMaxLength(50);



            var EstadoFuncionalAeronaveConverter = new ValueConverter<AeronaveEstadoFuncional, string>(
               EstadoFuncionalAeronaveValue => EstadoFuncionalAeronaveValue.Value,
               estadoFuncionalAeronave => new AeronaveEstadoFuncional(estadoFuncionalAeronave)
           );

            builder.Property(x => x.EstadoFuncionalAeronave)
                .HasConversion(EstadoFuncionalAeronaveConverter)
                .HasColumnName("EstadoFuncionalAeronave")
                //.HasColumnType("String")
                .HasMaxLength(20);


            var AsientosAsignadosConverter = new ValueConverter<NroAsientosValue, int>(
               AsientosAsignadosValue => AsientosAsignadosValue.Value,
               asientosAsignados => new NroAsientosValue(asientosAsignados)
           );

            builder.Property(x => x.AsientosAsignados)
                .HasConversion(AsientosAsignadosConverter)
                .HasColumnName("AsientosAsignados")
                .HasColumnType("int");               


            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}
