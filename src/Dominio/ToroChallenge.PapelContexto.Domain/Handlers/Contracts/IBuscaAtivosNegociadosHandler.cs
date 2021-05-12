using ToroChallenge.PapelContexto.Domain.Queries.Requests;
using ToroChallenge.PapelContexto.Domain.Queries.Responses;

namespace ToroChallenge.PapelContexto.Domain.Handlers.Contracts
{
    public interface IBuscaAtivosNegociadosHandler
    {
        BuscaAtivosNegociadosResponse Handle(BuscaAtivosNegociadosRequest command);
    }
}
