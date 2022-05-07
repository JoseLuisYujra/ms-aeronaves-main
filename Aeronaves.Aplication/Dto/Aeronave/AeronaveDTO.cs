using Aeronaves.Domain.Model.Aeronaves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Aplication.Dto.Aeronave
{
  
    public class AeronaveDTO
    {
        public Guid IdAeronave { get; set; }

        public int CodAeronave { get; set; }

        public Guid IdAeropuerto { get; set; }
        //public Guid IdControlAeronave { get; set; }

        //public Guid IdAsignacionAeronave { get; set; }

        public int TotalNroAsientos { get; set; }

        public string EstadoDisponibilidad { get; set; }

        //public ICollection<ControlAeronaveDto> AeronaveControl { get;  set; }

        public ControlAeronave AeronaveControl { get; set; }

        public AeronaveDTO()
        {
            //AeronaveControl = new List<ControlAeronaveDto>();
            AeronaveControl = new ControlAeronave();     
        }
    }
}
