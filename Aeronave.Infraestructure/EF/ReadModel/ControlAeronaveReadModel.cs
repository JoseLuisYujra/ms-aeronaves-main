using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronave.Infraestructure.EF.ReadModel
{
    public class ControlAeronaveReadModel
    {
        public Guid Id { get; set; }
        public Guid IdAeronave { get; set; }

        public Guid IdControlAeronave { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal CapacidadCarga { get; set; }
        public decimal CapTanqueCombustible { get; set; }
        public string AereopuertoEstacionamiento { get; set; }
        public string EstadoFuncionalAeronave { get; set; }

        public int AsientosAsignados { get; set; }

       // public AeronaveReadModel Aeronave { get; set; }
    }
}
