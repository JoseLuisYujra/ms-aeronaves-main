using MediatR;
using Microsoft.AspNetCore.Mvc;
using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Aplication.UseCases.Command.Aeronaves.AsignarAeronave;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById;
using System;
using System.Threading.Tasks;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.SearchAeronave;

namespace AeroNaves.webApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AeronaveController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AeronaveController(IMediator mediator)
        {
            _mediator = mediator;
        }

   
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AsignarAeronaveCommand command)
        {
            Guid id = await _mediator.Send(command);

            if (id == Guid.Empty)
                return BadRequest();

            return Ok(id);
        }

        [Route("{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> GetPedidoById([FromRoute] GetAeronaveByIdQuery command)
        {
            AeronaveDTO result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [Route("search")]
        [HttpPost]       
        public async Task<IActionResult> Search([FromBody] SearchAeronaveQuery query)
        {
            var aeronaves = await _mediator.Send(query);

            if (aeronaves == null)
                return BadRequest();

            return Ok(aeronaves);
        }

    }
}
