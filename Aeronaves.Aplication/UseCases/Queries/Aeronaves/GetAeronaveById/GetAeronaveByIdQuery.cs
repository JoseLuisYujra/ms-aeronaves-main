using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Aeronaves.Aplication.Dto.Aeronave;



namespace Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById
{

    public class GetAeronaveByIdQuery : IRequest<AeronaveDTO>
    {
        public Guid Id { get; set; }

        public GetAeronaveByIdQuery(Guid id)
        {
            Id = id;
        }

        public GetAeronaveByIdQuery() { }
    }
}
