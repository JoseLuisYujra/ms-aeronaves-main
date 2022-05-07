using Aeronaves.Domain.Model.Aeronaves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;

namespace Aeronaves.Domain.Repositories
{
    public interface IAsignacionAeronaveRepository : IRepository<AsignacionAeronave, Guid>
    {
        Task UpdateAsync(AsignacionAeronave obj);

        Task RemoveAsync(AsignacionAeronave obj);

    }
}
