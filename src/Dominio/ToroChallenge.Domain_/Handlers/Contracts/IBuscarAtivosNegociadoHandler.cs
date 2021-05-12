using ToroChallenge.Domain.Queries.Requests;
using ToroChallenge.Domain.Queries.Responses;

namespace ToroChallenge.Domain.Handlers.Contracts
{
    public interface IBuscaAtivosNegociadosHandler
    {
        BuscaAtivosNegociadosResponse Handler(BuscaAtivosNegociadosRequest command);
    }
}
