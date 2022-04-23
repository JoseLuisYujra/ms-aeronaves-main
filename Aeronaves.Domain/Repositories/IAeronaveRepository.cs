using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeronaves.Domain.Model.Aeronaves;
using ShareKernel.Core;

namespace Aeronaves.Domain.Repositories
{
    public interface IAeronaveRepository : IRepository<Aeronave, Guid>
    {
        Task UpdateAsync(Aeronave obj);

        //Task RemoveAsync(Aeronave obj);
    }
}
