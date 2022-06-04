using Aeronaves.Aplication.Dto.Aeronave;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Aplication.UseCases.Command.Aeronaves.ControlAeronave
{
    public class ControlAeronaveCommand : IRequest<Guid>
    {
        public ControlAeronaveDto AeronaveControl { get; set; }

        
        private ControlAeronaveCommand() { }


        public ControlAeronaveCommand(ControlAeronaveDto aeronaveControl)
        {
            AeronaveControl = aeronaveControl;
        }    

    }
}
