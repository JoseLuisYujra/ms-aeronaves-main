using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Aplication.Dto.Aeronave
{
    public class AsignacionAeronaveDTO
    {
        public Guid IdAsignacionAeronave { get;  set; }
        public Guid IdAeronave { get;  set; }
        public Guid IdVuelo { get;  set; }

        public int NroAsientosAeronave { get;  set; }
        public string EstadoAsignacion { get;  set; }

    }
}
