using ToroChallenge.Domain.Commands.Requests;
using ToroChallenge.Domain.Commands.Responses;

namespace ToroChallenge.Domain.Handlers.Contracts
{
    public interface IRecebimentoTransferenciaHandler
    {
        ReceberTransferenciaResponse Handle(ReceberTransferenciaRequest command);
    }
}
