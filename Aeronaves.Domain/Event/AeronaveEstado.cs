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
        public String EstadoAeronave { get; }

        public AeronaveEstado(Guid idaeronave, int codaeronave, String estadoaeronave) : base(DateTime.Now)
        {
            IdAeronave = idaeronave;
            CodAeronave = codaeronave;
            EstadoAeronave = estadoaeronave;  //VUELO/TIERRA
        }
    }
}
