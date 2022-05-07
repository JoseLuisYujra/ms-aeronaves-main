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
        // public List<ControlAeronaveDto> AeronaveControl { get; set; }
        public ControlAeronaveDto AeronaveControl { get; set; }

        private AsignarAeronaveCommand() { }

        // public AsignarAeronaveCommand(List<ControlAeronaveDto> AeronaveControl)
        public AsignarAeronaveCommand(ControlAeronaveDto aeronaveControl)
        {
            AeronaveControl = aeronaveControl;
        }    

    }
}
