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
        public ControlAeronaveDto AeronaveControl { get; set; }

        //public AeronaveDTO Aeronave { get; set; }  //

        private AsignarAeronaveCommand() { }

        
        public AsignarAeronaveCommand(ControlAeronaveDto aeronaveControl)
          {
              AeronaveControl = aeronaveControl;
          }
        
        /*
          public AsignarAeronaveCommand(AeronaveDTO aeronave, ControlAeronaveDto aeronaveControl)
          {
              Aeronave = aeronave;
              AeronaveControl = aeronaveControl;
          }
        */

    }
}
