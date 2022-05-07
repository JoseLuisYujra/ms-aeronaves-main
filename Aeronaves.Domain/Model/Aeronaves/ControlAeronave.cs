using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;
using ShareKernel.Rules;
using Aeronaves.Domain.Event;
using Aeronaves.Domain.Model.Aeronaves.ValueObjects;
using Aeronaves.Domain.ValueObjects;


namespace Aeronaves.Domain.Model.Aeronaves
{
    public class ControlAeronave : Entity<Guid>
    {
        public Guid IdAeronave { get; private set; }
        public Guid IdControlAeronave { get; private set; }
       

        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public RegistroDecimalValue CapacidadCarga { get; private set; }
        public RegistroDecimalValue CapTanqueCombustible { get; private set; }
        public string AereopuertoEstacionamiento { get; private set; }
        public AeronaveEstadoFuncional EstadoFuncionalAeronave { get; set; }

        public NroAsientosValue AsientosAsignados { get; private set; }

        public ControlAeronave() { }

        internal ControlAeronave(Guid idaeronave, string marca, string modelo,
            decimal capacidadCarga, decimal capTanqueCombustible, string aereopuertoEstacionamiento,
            string estadoFuncionalAeronave, int asientosAsignados)            
        {
            Id = Guid.NewGuid();
            IdControlAeronave = Guid.NewGuid();
            IdAeronave = idaeronave;
            Marca = marca;
            Modelo = modelo;
            CapacidadCarga = capacidadCarga;
            CapTanqueCombustible = capTanqueCombustible;
            AereopuertoEstacionamiento = aereopuertoEstacionamiento;
            EstadoFuncionalAeronave = estadoFuncionalAeronave;
            AsientosAsignados = asientosAsignados;
        }

        internal void ActualizarAeronave(decimal capTanqueCombustible, string aereopuertoEstacionamiento,
            string estadoFuncionalAeronave,int asientosAsignados)
        {
            CapTanqueCombustible = capTanqueCombustible;
            AereopuertoEstacionamiento = aereopuertoEstacionamiento;
            EstadoFuncionalAeronave = estadoFuncionalAeronave;
            AsientosAsignados = asientosAsignados;
        }
        
    }
}
