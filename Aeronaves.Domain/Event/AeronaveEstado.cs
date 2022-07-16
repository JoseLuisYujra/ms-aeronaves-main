using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;

namespace Aeronaves.Domain.Event
{
     public record AeronaveEstado : DomainEvent
    {
        public Guid IdAeronave { get; }
        public int CodAeronave { get; }
        public string EstadoDisponibilidad { get; }
            
        public int TotalNroAsientos { get; }

        public AeronaveEstado(Guid idaeronave, int codaeronave, string estadoDisponibilidad, 
            int totalNroAsientos) : base(DateTime.Now)
        {
            IdAeronave= idaeronave;
            CodAeronave = codaeronave;
            EstadoDisponibilidad = estadoDisponibilidad;  //Disponible/Asignado
            TotalNroAsientos = totalNroAsientos;
        }
    }
}
