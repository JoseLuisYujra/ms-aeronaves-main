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

        public Guid IdAeropuerto { get; private set; }
       
        public NroAsientosValue TotalNroAsientos { get; private set; }

        public AeronaveEstadoDisponibilidad EstadoDisponibilidad { get; private set; }
                    

        public ControlAeronave AeronaveControl { get; private set; }


        public AsignacionAeronave AeronaveAsignacion { get; private set; }

      
        //Parametro que debe ingresar desde microservicio VUELOS
        public Guid IdVuelo { get; private set; }

        private Aeronave() {
            Id = Guid.NewGuid();
            TotalNroAsientos = 0;
        }

        public Aeronave(int codaeronave)
        {
            Id = Guid.NewGuid();
            CodAeronave = codaeronave;
            TotalNroAsientos = 50;
         }      

        public Aeronave(Guid idVuelo, int codaeronave)
        {
            Id = Guid.NewGuid();
            IdVuelo = idVuelo;
            CodAeronave = codaeronave;            
        }

        public Aeronave(Guid idVuelo, int codaeronave, int totalNroAsientos)
        {
            Id = Guid.NewGuid();
            IdVuelo = idVuelo;
            CodAeronave = codaeronave;
            TotalNroAsientos = totalNroAsientos;
        }

        //uso de DOMAIN EVENT
        public void AsignarAeronave()
        {
            var evento = new AeronaveAsignada(CodAeronave, Id, IdVuelo);
            AddDomainEvent(evento);

        }

        /*
        public void ActualizarEstadoAeronave(NroAsientosValue _Nroasientos)
        {
            if (_Nroasientos < TotalNroAsientos)
            {
                EstadoDisponibilidad = "Disponible";
            }
            else
            {
                EstadoDisponibilidad = "Asignado";
            }
            if ((TotalNroAsientos - _Nroasientos) < 0)
            {
                throw new BussinessRuleValidationException("Nro de Asiento insuficiente");
            }          
        }
        */
        public void ActualizarEstadoAeronave()
        {
                         EstadoDisponibilidad = "Asignado";           
        }

        //
        public void RegistroAeronave(Guid idaeronave, string marca, string modelo,
            decimal capacidadCarga, decimal capTanqueCombustible, string aereopuertoEstacionamiento,
            string estadoFuncionalAeronave, int asientosAsignados)
        {
            /*
            var controlAeronave = AeronaveControl.FirstOrDefault(x => x.IdAeronave == idaeronave);
            if (controlAeronave is null)
            {
                controlAeronave = new ControlAeronave(idaeronave, marca, modelo, capacidadCarga, capTanqueCombustible, aereopuertoEstacionamiento, estadoFuncionalAeronave, asientosAsignados);
                AeronaveControl.Add(controlAeronave);
            }
            else
            {
                controlAeronave.ActualizarAeronave(capTanqueCombustible, aereopuertoEstacionamiento, estadoFuncionalAeronave);
            }
            */                   

            AddDomainEvent(new AeronaveAgregada(idaeronave, marca, modelo, capacidadCarga, capTanqueCombustible, aereopuertoEstacionamiento, estadoFuncionalAeronave, asientosAsignados, AeronaveControl));          

        }

        public void RegistroAsignacionAeronave(Guid idAeronave, Guid idVuelo, int nroAsientosAeronave, string estadoAsignacion)
        {
            AeronaveAsignacion = new AsignacionAeronave(idAeronave, idVuelo, nroAsientosAeronave, estadoAsignacion);                       
        }
    }
}
