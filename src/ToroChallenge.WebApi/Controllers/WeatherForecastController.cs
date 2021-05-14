using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToroChallenge.PapelContexto.Domain.Commands.Requests;
using ToroChallenge.PapelContexto.Domain.Queries.Requests;
using ToroChallenge.TransferenciaContexto.Domain.Commands.Requests;

namespace ToroChallenge.WebApi.Controllers
{
    [ApiController]
    [Route("api")]
    [Produces("application/json")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("List")]
        public IActionResult ListarMaisNegociados(
                  [FromServices] IMediator handler,
                  [FromQuery] BuscaAtivosNegociadosRequest command
              )
        {
            var response = handler.Send(command);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("Start")]
        public IActionResult SubmeterOrdem(
                  [FromServices] IMediator handler,
                  [FromBody] SubmeteOrdemRequest command
       )
        {
            var result = handler.Send(command);
            return Ok(result);
        }

        [HttpPost]
        [Route("Get")]
        public IActionResult ReceberTransferencia(
           [FromServices] IMediator handler,
           [FromQuery] RecebeTransferenciaRequest command
       )
        {
            var result = handler.Send(command);
            return Ok(result);
        }
    }
}
