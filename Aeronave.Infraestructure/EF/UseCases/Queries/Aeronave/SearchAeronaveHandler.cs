using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Aeronave.Infraestructure.EF.Context;
using Aeronave.Infraestructure.EF.ReadModel;
using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.SearchAeronave;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Aeronave.Infraestructure.EF.UseCases.Queries.Aeronave
{

    public class SearchAeronaveHandler : IRequestHandler<SearchAeronaveQuery, AeronaveDTO>
    {
        private readonly DbSet<AeronaveReadModel> _context;

        public SearchAeronaveHandler(ReadDbContext context)
        {
            _context = context.Aeronave;
        }


        public async Task<AeronaveDTO> Handle(SearchAeronaveQuery request, CancellationToken cancellationToken)
        {
           var AeronaveList = await _context.FindAsync(request.Id);
           return new AeronaveDTO
            {
                //IdAeronave = AeronaveList.IdAeronave,
                CodAeronave = AeronaveList.CodAeronave,
                //IdAeropuerto = AeronaveList.IdAeropuerto,
                TotalNroAsientos = AeronaveList.TotalNroAsientos,
                EstadoDisponibilidad = AeronaveList.EstadoDisponibilidad
            };
        }
    }
}
