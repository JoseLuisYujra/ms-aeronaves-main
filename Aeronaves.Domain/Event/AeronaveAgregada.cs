using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;
using Aeronaves.Domain.ValueObjects;


namespace Aeronaves.Domain.Event
{
    public record AeronaveAgregada : DomainEvent
    {
        public Guid IdAeronave { get; }
        public string Marca { get; }
        public string Modelo { get;  }
        public RegistroDecimalValue CapacidadCarga { get;  }
        public RegistroDecimalValue CapTanqueCombustible { get;  }
        public string AereopuertoEstacionamiento { get; }
        public AeronaveEstadoFuncional EstadoFuncionalAeronave { get;  }

        public AeronaveAgregada(Guid idaeronave, string marca, string modelo,
            decimal capacidadCarga, decimal capTanqueCombustible, string aereopuertoEstacionamiento,
            string estadoFuncionalAeronave) : base(DateTime.Now)
        {
            IdAeronave = idaeronave;            
            Marca = marca;
            Modelo = modelo;
            CapacidadCarga = capacidadCarga;
            CapTanqueCombustible = capTanqueCombustible;
            AereopuertoEstacionamiento = aereopuertoEstacionamiento;
            EstadoFuncionalAeronave = estadoFuncionalAeronave;
        }
    }
}
