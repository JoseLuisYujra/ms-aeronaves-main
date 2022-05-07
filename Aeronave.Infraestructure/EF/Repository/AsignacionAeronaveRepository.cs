using Aeronaves.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronave.Infraestructure.EF.Context;

namespace Aeronave.Infraestructure.EF.Repository
{
    public class AsignacionAeronaveRepository : IAsignacionAeronaveRepository
    {
        public readonly DbSet<AsignacionAeronave> _asignacionAeronave;

        public AsignacionAeronaveRepository(WriteDbContext context)
        {
            _asignacionAeronave = context.AsignacionAeronave;
        }
        public async Task CreateAsync(AsignacionAeronave obj)
        {
            await _asignacionAeronave.AddAsync(obj);
        }

        public async Task<AsignacionAeronave> FindByIdAsync(Guid id)
        {
            return await _asignacionAeronave.SingleOrDefaultAsync(x => x.Id == id);
        }

        public Task RemoveAsync(AsignacionAeronave obj)
        {
            _asignacionAeronave.Remove(obj);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(AsignacionAeronave obj)
        {
            _asignacionAeronave.Update(obj);
            return Task.CompletedTask;
        }
    }
}
