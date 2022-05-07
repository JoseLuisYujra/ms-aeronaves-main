using MediatR;
using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Aeronaves.Domain.Factory;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;
using Aeronaves.Aplication.Services;

namespace Aeronaves.Aplication.UseCases.Command.Aeronaves.AsignarAeronave
{

    public class AsignarAeronaveHandler : IRequestHandler<AsignarAeronaveCommand, Guid>
    {
        private readonly IAeronaveRepository _aeronaveRepository;
        private readonly ILogger<AsignarAeronaveHandler> _logger;
        private readonly IAeoronaveService _aeoronaveService;
        private readonly IAeronaveFactory _aeronaveFactory;
        private readonly IUnitOfWork _unitOfWork;

        public AsignarAeronaveHandler(IAeronaveRepository aeronaveRepository, ILogger<AsignarAeronaveHandler> logger,
            IAeoronaveService aeoronaveService, IAeronaveFactory aeronaveFactory, IUnitOfWork unitOfWork)
        {
            _aeronaveRepository = aeronaveRepository;
            _logger = logger;
            _aeoronaveService = aeoronaveService;
            _aeronaveFactory = aeronaveFactory;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(AsignarAeronaveCommand request, CancellationToken cancellationToken)
        {
            try
            {
                int nroAsignacion = await _aeoronaveService.GenerarAsignacionAeronaveAsync();
                Aeronave objPedido = _aeronaveFactory.Create(nroAsignacion);

                /*
                foreach (var item in request.Detalle)
                {
                    objPedido.RegistroAeronave(item.IdAeronave, item.Marca, item.Modelo, item.CapacidadCarga,
                                               item.CapTanqueCombustible,item.AereopuertoEstacionamiento,item.EstadoFuncionalAeronave,item.AsientosAsignados);
                }
                */
                objPedido.RegistroAeronave(request.AeronaveControl.IdAeronave, request.AeronaveControl.Marca, request.AeronaveControl.Modelo, request.AeronaveControl.CapacidadCarga,
                                               request.AeronaveControl.CapTanqueCombustible, request.AeronaveControl.AereopuertoEstacionamiento, request.AeronaveControl.EstadoFuncionalAeronave, request.AeronaveControl.AsientosAsignados);

                objPedido.AsignarAeronave();

                await _aeronaveRepository.CreateAsync(objPedido);

                await _unitOfWork.Commit();

                return objPedido.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear asignacion");
            }
            return Guid.Empty;
        }

    }
}
