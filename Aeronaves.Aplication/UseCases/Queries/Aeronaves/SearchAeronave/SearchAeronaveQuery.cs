using MediatR;
using Aeronaves.Aplication.Dto.Aeronave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Aplication.UseCases.Queries.Aeronaves.SearchAeronave
{

    public class SearchAeronaveQuery : IRequest<AeronaveDTO>
    {
        public Guid Id { get; set; }
    }
}

