using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronave.Infraestructure.EF.ReadModel
{
    public class AsignacionAeronaveReadModel
    {
        public Guid Id { get; set; }
        public Guid IdAsignacionAeronave { get; set; }
        public Guid IdAeronave { get; set; }
        public Guid IdVuelo { get; set; }

        public int NroAsientosAeronave { get; set; }
        public string EstadoAsignacion { get; set; }
              
     }
}
