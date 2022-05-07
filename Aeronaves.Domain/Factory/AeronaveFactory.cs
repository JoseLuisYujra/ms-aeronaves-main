
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeronaves.Domain.Model.Aeronaves;

namespace Aeronaves.Domain.Factory
{
    public class AeronaveFactory : IAeronaveFactory
    {
        public Aeronave Create(int idAeronave)
        {
            return new Aeronave(idAeronave);
        }
              
    }
}


