using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Aplication.Services
{
 
    public class AeronaveService : IAeoronaveService
    {
        public Task<int> GenerarAsignacionAeronaveAsync() => Task.FromResult(1);


    }
}
