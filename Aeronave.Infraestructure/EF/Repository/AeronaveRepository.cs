using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeronaves.Domain.Repositories;
using ShareKernel.Core;
using Aeronaves.Domain.Model.Aeronaves;
using Microsoft.EntityFrameworkCore;
using Aeronave.Infraestructure.EF.Context;


namespace Aeronave.Infraestructure.EF.Repository
{

    public class AeronaveRepository : IAeronaveRepository
    {
        /*
          public Task CreateAsync(Aeronaves.Domain.Model.Aeronaves.Aeronave obj)
          {
              Console.WriteLine($"Insertando Asignacion de Aeronave { obj.CodAeronave }");

              return Task.CompletedTask;
          }

          public Task<Aeronaves.Domain.Model.Aeronaves.Aeronave> FindByIdAsync(Guid id)
          {
              Console.WriteLine($"Retornando Asignacion de Aeronave{ id }");

              return null;
          }


          public Task UpdateAsync(Aeronaves.Domain.Model.Aeronaves.Aeronave obj)
          {
              Console.WriteLine($"Actualizando Asignacion de Aeronave { obj.CodAeronave }");

              return Task.CompletedTask;
          }
          /*
          Task<Aeronaves.Domain.Model.Aeronaves.Aeronave> IRepository<Aeronaves.Domain.Model.Aeronaves.Aeronave, Guid>.FindByIdAsync(Guid id)
          {
              throw new NotImplementedException();
          }
          */


        public readonly DbSet<Aeronaves.Domain.Model.Aeronaves.Aeronave> _aeronave;

        public AeronaveRepository(WriteDbContext context)
        {
            _aeronave = context.Aeronave;
        }

        public async Task CreateAsync(Aeronaves.Domain.Model.Aeronaves.Aeronave obj)
        {
            await _aeronave.AddAsync(obj);
        }

        public async Task<Aeronaves.Domain.Model.Aeronaves.Aeronave> FindByIdAsync(Guid id)
        {
            return await _aeronave.Include("_ControlAeronave")
                    .SingleAsync(x => x.Id == id);
        }

        public Task UpdateAsync(Aeronaves.Domain.Model.Aeronaves.Aeronave obj)
        {
            _aeronave.Update(obj);

            return Task.CompletedTask;
        }


    }
}
