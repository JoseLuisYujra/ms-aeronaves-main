using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShareKernel.Core;
using Aeronaves.Domain.Event;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronave.Infraestructure.EF.Config.WriteConfig;

namespace Aeronave.Infraestructure.EF.Context
{
    public class WriteDbContext : DbContext
    {
        public virtual DbSet<Aeronaves.Domain.Model.Aeronaves.Aeronave> Aeronave { get; set; }
        public virtual DbSet<ControlAeronave> ControlAeronave { get; set; }

        public virtual DbSet<AsignacionAeronave> AsignacionAeronave { get; set; }

        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var aeronaveConfig = new AeronaveWriteConfig();
            modelBuilder.ApplyConfiguration<Aeronaves.Domain.Model.Aeronaves.Aeronave>(aeronaveConfig);
            modelBuilder.ApplyConfiguration<ControlAeronave>(aeronaveConfig);


            var asignacionAeronaveConfig = new AsignacionAeronaveWriteConfig();
            modelBuilder.ApplyConfiguration<AsignacionAeronave>(asignacionAeronaveConfig);

                                 
            modelBuilder.Ignore<DomainEvent>();
            modelBuilder.Ignore<AeronaveAsignada>();
            modelBuilder.Ignore<AeronaveAgregada>();
            modelBuilder.Ignore<AeronaveEstado>();

        }
    }
}
