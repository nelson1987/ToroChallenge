using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ToroChallenge.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class InvestimentoController : ControllerBase
    {
        [HttpGet]
        [Route("/trends")]
        public IActionResult Get([FromServices] IBuscaAtivosNegociadosHandler handler,
            [FromQuery] BuscaAtivosNegociadosRequest command)
        {
            List<BuscaAtivosNegociadosResponse> investimentos = new List<BuscaAtivosNegociadosResponse>();
            for (int i = 0; i < 5; i++)
            {
                investimentos.Add(new BuscaAtivosNegociadosResponse()
                {
                    PrecoAtual = i * 56.12,
                    Codigo = $"TORO" + i
                });
            }
            return Ok();
        }

        [HttpPost]
        [Route("/spb/events")]
        public IActionResult Post([FromServices] IRecebimentoTransferenciaHandler handler,
            [FromBody] ReceberTransferenciaRequest command)
        {
            var response = handler.Handle(command);
            return Ok(response);
        }
    }
}
