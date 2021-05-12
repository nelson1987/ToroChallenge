using ToroChallenge.Domain.Queries.Requests;
using ToroChallenge.Domain.Queries.Responses;

namespace ToroChallenge.Domain.Repositories
{
    public interface IPapelRepository
    {
        BuscaAtivosNegociadosResponse GetAtivosMaisNegociados(BuscaAtivosNegociadosRequest command);
    }
}
