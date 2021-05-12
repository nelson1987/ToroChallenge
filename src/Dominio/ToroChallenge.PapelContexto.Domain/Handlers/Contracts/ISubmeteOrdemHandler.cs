using ToroChallenge.PapelContexto.Domain.Commands.Requests;
using ToroChallenge.PapelContexto.Domain.Commands.Responses;

namespace ToroChallenge.PapelContexto.Domain.Handlers.Contracts
{
    public interface ISubmeteOrdemHandler
    {
        SubmeteOrdemResponse Handle(SubmeteOrdemRequest command);
    }
}
