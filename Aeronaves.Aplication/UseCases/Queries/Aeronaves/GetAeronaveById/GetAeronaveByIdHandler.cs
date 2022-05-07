using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;


namespace Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById
{

    public class GetAeronaveByIdHandler : IRequestHandler<GetAeronaveByIdQuery, AeronaveDTO>
    {
        private readonly IAeronaveRepository _aeronaveRepository;
        private readonly ILogger<GetAeronaveByIdQuery> _logger;

        public GetAeronaveByIdHandler(IAeronaveRepository aeronaveRepository, ILogger<GetAeronaveByIdQuery> logger)
        {
            _aeronaveRepository = aeronaveRepository;
            _logger = logger;
        }

        public async Task<AeronaveDTO> Handle(GetAeronaveByIdQuery request, CancellationToken cancellationToken)
        {
            AeronaveDTO result = null;
            try
            {
                Aeronave objAeronave = await _aeronaveRepository.FindByIdAsync(request.Id);

                result = new AeronaveDTO()
                {
                    IdAeronave = objAeronave.IdAeronave,
                    IdAeropuerto = objAeronave.IdAeropuerto,
                    //IdControlAeronave = objAeronave.IdControlAeronave,
                    //IdAsignacionAeronave =objAeronave.IdAsignacionAeronave,
                    CodAeronave = objAeronave.CodAeronave,
                    TotalNroAsientos = objAeronave.TotalNroAsientos,
                    EstadoDisponibilidad = objAeronave.EstadoDisponibilidad,
                    AeronaveControl = objAeronave.AeronaveControl                   

                };
                /*
                foreach (var item in objAeronave.AeronaveControl)
                {
                    result.AeronaveControl.Add(new ControlAeronaveDto()
                    {
                        IdAeronave = item.IdAeronave,
                        Marca = item.Marca,
                        Modelo = item.Modelo,
                        CapacidadCarga = item.CapacidadCarga,
                        CapTanqueCombustible = item.CapTanqueCombustible,
                        AereopuertoEstacionamiento = item.AereopuertoEstacionamiento,
                        EstadoFuncionalAeronave = item.EstadoFuncionalAeronave,
                        AsientosAsignados =item.AsientosAsignados
                    });
                }
                */
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener asignacion con id: { IdAeronave }", request.Id);
            }

            return result;
        }
    }
}
