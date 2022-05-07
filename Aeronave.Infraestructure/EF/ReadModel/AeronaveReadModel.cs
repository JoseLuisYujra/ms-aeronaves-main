using Aeronaves.Aplication.Dto.Aeronave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronave.Infraestructure.EF.ReadModel
{
    public class AeronaveReadModel
    {

        public Guid Id { get; set; }

        public Guid IdAeronave { get; set; }

        public int CodAeronave { get; set; }

        public Guid IdAeropuerto { get; set; }
    
        public int TotalNroAsientos { get; set; }

        public string EstadoDisponibilidad { get; set; }
               

        public ControlAeronaveReadModel ControlAeronave { get; set; }
    }
}
