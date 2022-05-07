using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Aeronaves.Domain.Event;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;
using System.Threading;



namespace Aeronaves.Aplication.UseCases.Command.Aeronaves
{
  
    public class ActualizarEstadoAeronaveHandler : INotificationHandler<AeronaveEstado>
    {
        private readonly IAeronaveRepository _IAeronaveRepository;

        public ActualizarEstadoAeronaveHandler(IAeronaveRepository iaeronaveRepository)
        {
            _IAeronaveRepository = iaeronaveRepository;
        }

        public async Task Handle(AeronaveEstado notification, CancellationToken cancellationToken)
        {
            Aeronave objAeronave = await _IAeronaveRepository.FindByIdAsync(notification.IdAeronave);
            //objAeronave.ActualizarEstadoAeronave(notification.TotalNroAsientos);
            objAeronave.ActualizarEstadoAeronave();

            await _IAeronaveRepository.UpdateAsync(objAeronave);


        }
    }
}
