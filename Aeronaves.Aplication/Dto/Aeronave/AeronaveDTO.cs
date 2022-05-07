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
        public Guid Id { get; set; }

        public Guid IdAeronave { get; set; }

        public int CodAeronave { get; set; }

        public Guid IdAeropuerto { get; set; }
       
        public int TotalNroAsientos { get; set; }

        public string EstadoDisponibilidad { get; set; }

       

        public ControlAeronave AeronaveControl { get; set; }

        public AeronaveDTO()
        {
           
            AeronaveControl = new ControlAeronave();     
        }
    }
}
