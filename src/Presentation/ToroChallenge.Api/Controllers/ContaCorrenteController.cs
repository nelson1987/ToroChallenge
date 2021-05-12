using Microsoft.AspNetCore.Mvc;

namespace ToroChallenge.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ContaCorrenteController : ControllerBase
    {
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
