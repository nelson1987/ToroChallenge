using ToroChallenge.PapelContexto.Domain.Commands.Requests;

namespace ToroChallenge.PapelContexto.Domain.Handlers.Contracts
{
    public interface ISubmeteOrdemHandler
    {
        SubmeteOrdemResponse Handle(SubmeteOrdemResponse command);
    }
}
