using MediatR;
using ToroChallenge.PapelContexto.Domain.Commands.Responses;

namespace ToroChallenge.PapelContexto.Domain.Commands.Requests
{
    public class SubmeteOrdemRequest : IRequest<SubmeteOrdemResponse>
    {
        public string Conta { get; set; }
        public string Papel { get; set; }
        public int Quantidade { get; set; }
    }
}
