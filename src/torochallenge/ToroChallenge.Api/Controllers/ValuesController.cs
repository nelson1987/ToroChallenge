using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ToroChallenge.PapelContexto.Domain.Commands.Requests;
using ToroChallenge.PapelContexto.Domain.Handlers.Contracts;
using ToroChallenge.PapelContexto.Domain.Queries.Requests;

namespace ToroChallenge.Api.Controllers
{
    [Route("api")]
    [ApiController]
    [Produces("application/json")]
    public class ValuesController : ControllerBase
    {
        // POST api/spb/events
        [HttpPost]
        [Route("/spb/events")]
        public IActionResult Transferir(
                   [FromServices]IBuscaAtivosNegociadosHandler handler,
                   [FromBody]BuscaAtivosNegociadosRequest command)
        {
            var response = handler.Handle(command);
            return Ok(response);
        }

        // POST api/order
        [HttpPost, AllowAnonymous, Route("/order")]
        public async Task<IActionResult> Submeter(
                   [FromServices]IMediator _mediator,
                   [FromBody]SubmeteOrdemResponse command)
        {
            var response = await _mediator.Send(command).ConfigureAwait(false);

            if (response.Errors.Any())
            {
                return BadRequest(response.Errors);
            }

            return Ok(response.Result);
        }
    }

        // GET api/trends
        [HttpGet, AllowAnonymous, Route("/trends")]
        public async Task<IActionResult> ListarCincoMaisNegociados(
                   [FromServices]IBuscaAtivosNegociadosHandler handler,
                   [FromQuery]BuscaAtivosNegociadosRequest command)
        {
            var response = handler.Handle(command);
            return Ok(response);
        }
    }
}
