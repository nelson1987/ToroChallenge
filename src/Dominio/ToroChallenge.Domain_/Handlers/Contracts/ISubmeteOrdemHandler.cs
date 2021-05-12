using ToroChallenge.Domain.Queries.Requests;
using ToroChallenge.Domain.Queries.Responses;

namespace ToroChallenge.Domain.Handlers.Contracts
{
    public interface ISubmeteOrdemHandlerHandler
    {
        BuscaAtivosNegociadosResponse Handler(BuscaAtivosNegociadosRequest command);
    }
}
