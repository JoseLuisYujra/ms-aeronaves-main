using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;

namespace Aeronaves.Domain.Event
{
    public record AeronaveAsignada : DomainEvent
    {
        public Guid IdAeronave { get; }
        public int CodAeronave { get; }

        public AeronaveAsignada(Guid idaeronave, int codaeronave) : base(DateTime.Now)
        {
            IdAeronave = idaeronave;
            CodAeronave = codaeronave;
        }
    }
}

