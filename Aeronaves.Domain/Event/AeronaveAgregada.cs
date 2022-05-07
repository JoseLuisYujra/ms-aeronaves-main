using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;
using Aeronaves.Domain.ValueObjects;
using Aeronaves.Domain.Model.Aeronaves.ValueObjects;
using Aeronaves.Domain.Model.Aeronaves;

namespace Aeronaves.Domain.Event
{
    public record AeronaveAgregada : DomainEvent
    {

        public Guid IdControlAeronave { get; }
        public Guid IdAeronave { get; }
        public string Marca { get; }
        public string Modelo { get;  }
        public RegistroDecimalValue CapacidadCarga { get;  }
        public RegistroDecimalValue CapTanqueCombustible { get;  }
        public AeronaveEstadoFuncional EstadoFuncionalAeronave { get;  }

        public string AereopuertoEstacionamiento { get; }

        public NroAsientosValue AsientosAsignados { get; }


        public ControlAeronave AeronaveControl { get;}

        public AeronaveAgregada(Guid idaeronave, string marca, string modelo,
            decimal capacidadCarga, decimal capTanqueCombustible, string aereopuertoEstacionamiento,
            string estadoFuncionalAeronave, int asientosAsignados, ControlAeronave aeronaveControl) : base(DateTime.Now)
        {
            IdAeronave = idaeronave;            
            Marca = marca;
            Modelo = modelo;
            CapacidadCarga = capacidadCarga;
            CapTanqueCombustible = capTanqueCombustible;
            AereopuertoEstacionamiento = aereopuertoEstacionamiento;
            EstadoFuncionalAeronave = estadoFuncionalAeronave;
            AsientosAsignados = asientosAsignados;
            AeronaveControl = aeronaveControl;
        }
    }
}
