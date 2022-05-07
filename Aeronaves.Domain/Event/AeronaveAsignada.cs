using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeronaves.Domain.Model.Aeronaves.ValueObjects;
using ShareKernel.Core;

namespace Aeronaves.Domain.Event
{
    public record AeronaveAsignada : DomainEvent
    {
        public int CodAeronave { get; private set; }
        public Guid IdAeronave { get; private set; }
        public Guid IdVuelo { get; private set; }

        public NroAsientosValue NroAsientosAeronave { get; private set; }
        public AeronaveEstadoAsignacion EstadoAsignacion { get; private set; }

        public AeronaveAsignada(int codAeronave,Guid idaeronave, Guid idVuelo, int nroAsientosAeronave, string estadoAsignacion) : base(DateTime.Now)
        {
            CodAeronave = codAeronave;
            IdAeronave = idaeronave;
            IdVuelo = idVuelo;
            NroAsientosAeronave = nroAsientosAeronave;
            EstadoAsignacion = estadoAsignacion;
        }

        public AeronaveAsignada(int codAeronave, Guid idaeronave, Guid idVuelo) : base(DateTime.Now)
        {
            CodAeronave = codAeronave;
            IdAeronave = idaeronave;
            IdVuelo = idVuelo;           
        }
    }
}

