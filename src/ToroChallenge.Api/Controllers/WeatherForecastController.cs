using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToroChallenge.PapelContexto.Domain.Commands.Requests;
using ToroChallenge.PapelContexto.Domain.Queries.Requests;
using ToroChallenge.TransferenciaContexto.Domain.Commands.Requests;

namespace ToroChallenge.Api.Controllers
{
    [ApiController]
    [Route("api")]
    [Produces("application/json")]
    public class WeatherForecastController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        //private readonly ILogger<WeatherForecastController> _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet]
        [Route("List")]
        public IActionResult ListarMaisNegociados(
                  [FromServices] IMediator handler,
                  [FromBody] BuscaAtivosNegociadosRequest command
              )
        {
            var response = handler.Send(command);
            return Ok(response);
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
