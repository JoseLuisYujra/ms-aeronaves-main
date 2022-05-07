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
        public int CodAeronave { get;  set; }
        public string EstadoFuncionalAeronave { get; set; }
        public int Nroasientos { get;  set; }

        public ICollection<ControlAeronaveDto> AeronaveControl { get;  set; }

        //Parametro que debe ingresar desde microservicio VUELOS
        public int Codvuelo { get; set; }


        public AeronaveDTO()
        {
            AeronaveControl = new List<ControlAeronaveDto>();
        }
    }
}
