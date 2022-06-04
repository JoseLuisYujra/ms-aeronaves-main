using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;
using Aeronaves.Domain.Model.Aeronaves.ValueObjects;
using Aeronaves.Domain.ValueObjects;

namespace Aeronaves.Domain.Model.Aeronaves
{

    public class AsignacionAeronave : AggregateRoot<Guid> // Entity<Guid>
    {

        public Guid IdAsignacionAeronave { get; private set; }
        public Guid IdAeronave { get; private set; }        
        public Guid IdVuelo { get; private set; }
        
        public NroAsientosValue NroAsientosAeronave { get; private set; }
        public AeronaveEstadoAsignacion EstadoAsignacion { get; private set; }

        private AsignacionAeronave() { }

        public AsignacionAeronave(Guid idAeronave, Guid idVuelo, int nroAsientosAeronave,string estadoAsignacion)
        {
            Id = Guid.NewGuid();
            IdAsignacionAeronave = Guid.NewGuid();
            IdAeronave = idAeronave;
            IdVuelo = idVuelo;
            NroAsientosAeronave = nroAsientosAeronave;
            EstadoAsignacion = estadoAsignacion;            
        }

        internal void ActualizarAsignacionAeronave(int nroAsientosAeronave, string estadoAsignacion)
        {
            NroAsientosAeronave = nroAsientosAeronave;
            EstadoAsignacion = estadoAsignacion;
        }

    }


}