using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeronave.Infraestructure.EF.Config.ReadConfig;
using Aeronave.Infraestructure.EF.ReadModel;
using Aeronaves.Domain.Event;
using Microsoft.EntityFrameworkCore;
using ShareKernel.Core;

namespace Aeronave.Infraestructure.EF.Context
{
  
    public class ReadDbContext : DbContext
    {
        public virtual DbSet<AeronaveReadModel> Aeronave { set; get; }
        public virtual DbSet<ControlAeronaveReadModel> ControlAeronave { set; get; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var aeronaveConfig = new AeronaveReadConfig();
            modelBuilder.ApplyConfiguration<AeronaveReadModel>(aeronaveConfig);
            modelBuilder.ApplyConfiguration<ControlAeronaveReadModel>(aeronaveConfig);


            var asignacionAeronaveConfig = new AsignacionAeronaveReadConfig();
            modelBuilder.ApplyConfiguration<AsignacionAeronaveReadModel>(asignacionAeronaveConfig);

            modelBuilder.Ignore<DomainEvent>();
            modelBuilder.Ignore<AeronaveAsignada>();
            modelBuilder.Ignore<AeronaveAgregada>();
            modelBuilder.Ignore<AeronaveEstado>();

        }
    }
}
