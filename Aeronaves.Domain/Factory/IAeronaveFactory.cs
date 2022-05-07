using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;
using Aeronaves.Domain.Event;
using Aeronaves.Domain.Model.Aeronaves.ValueObjects;
using Aeronaves.Domain.ValueObjects;
using Aeronaves.Domain.Model.Aeronaves;

namespace Aeronaves.Domain.Factory
{
    public interface IAeronaveFactory
    {
        Aeronave Create(int idAeronave);
        
    }
}
