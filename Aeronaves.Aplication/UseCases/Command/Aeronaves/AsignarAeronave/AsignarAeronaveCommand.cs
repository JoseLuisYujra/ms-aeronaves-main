using Aeronaves.Aplication.Dto.Aeronave;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Aplication.UseCases.Command.Aeronaves.AsignarAeronave
{
    public class AsignarAeronaveCommand : IRequest<Guid>
    {
        private AsignarAeronaveCommand() { }

        public AsignarAeronaveCommand(List<ControlAeronaveDto> detalle)
        {
            Detalle = detalle;
        }

        public List<ControlAeronaveDto> Detalle { get; set; }



    }
}
