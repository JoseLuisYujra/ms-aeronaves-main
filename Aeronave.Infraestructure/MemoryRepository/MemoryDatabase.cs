using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeronaves.Domain.Model.Aeronaves;

namespace Aeronave.Infraestructure.MemoryRepository
{
    public class MemoryDatabase
    {
        private readonly List<Aeronaves.Domain.Model.Aeronaves.Aeronave> _aeronaves;

        public List<Aeronaves.Domain.Model.Aeronaves.Aeronave> Aeronaves
        {
            get { return _aeronaves; }
        }

      

        public MemoryDatabase()
        {
            _aeronaves = new List<Aeronaves.Domain.Model.Aeronaves.Aeronave>();
        }

    }
}
