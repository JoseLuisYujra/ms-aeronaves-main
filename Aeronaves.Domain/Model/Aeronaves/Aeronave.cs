using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;
using Aeronaves.Domain.Event;
using Aeronaves.Domain.Model.Aeronaves.ValueObjects;
using Aeronaves.Domain.ValueObjects;
using System.Collections.ObjectModel;

namespace Aeronaves.Domain.Model.Aeronaves
{

    public class Aeronave : AggregateRoot<Guid>          
    {
        public Guid IdAeronave { get; private set; }       
        public int CodAeronave { get; private set; }
        public AeronaveEstadoFuncional EstadoFuncionalAeronave { get; set; }
        public NroAsientosValue Nroasientos { get; private set; }

        public readonly ICollection<ControlAeronave> AeronaveControl; 


        public IReadOnlyCollection<ControlAeronave> Control
        {
            get
            {
                return new ReadOnlyCollection<ControlAeronave>(AeronaveControl.ToList());
            }
        }

        
        //Parametro que debe ingresar desde microservicio VUELOS
        public int Codvuelo { get; private set; }

        public Aeronave() { Id = Guid.NewGuid(); }

        public Aeronave(int codaeronave)
        {
            Id = Guid.NewGuid();           
            CodAeronave = codaeronave;
            AeronaveControl = new List<ControlAeronave>();
        }

        //public Aeronave(int codvuelo, int codaeronave, string estadofuncionalAeronave)
        public Aeronave(int codvuelo, int codaeronave)
        {
            Id = Guid.NewGuid();
            Codvuelo = codvuelo;
            CodAeronave = codaeronave;            
            AeronaveControl = new List<ControlAeronave>();
        }

        //uso de DOMAIN EVENT
        public void AsignarAeronave()
        {
      
            var evento = new AeronaveAsignada(Id, CodAeronave);
            AddDomainEvent(evento);
        }

        //
        public void RegistroAeronave(Guid idaeronave, string marca, string modelo,
            decimal capacidadCarga, decimal capTanqueCombustible, string aereopuertoEstacionamiento,
            string estadoFuncionalAeronave)
        {

            var controlAeronave = AeronaveControl.FirstOrDefault(x => x.IdAeronave == idaeronave);
            if (controlAeronave is null)
            {
                controlAeronave = new ControlAeronave(idaeronave, marca, modelo, capacidadCarga, capTanqueCombustible, aereopuertoEstacionamiento, estadoFuncionalAeronave);
                AeronaveControl.Add(controlAeronave);
            }
            else
            {
                controlAeronave.ActualizarAeronave(capTanqueCombustible, aereopuertoEstacionamiento, estadoFuncionalAeronave);
            }

            AddDomainEvent(new AeronaveAgregada(idaeronave, marca, modelo, capacidadCarga, capTanqueCombustible, aereopuertoEstacionamiento, estadoFuncionalAeronave));
               
        }

    }
}
