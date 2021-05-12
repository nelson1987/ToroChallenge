using ToroChallenge.PapelContexto.Domain.Queries.Requests;
using ToroChallenge.PapelContexto.Domain.Queries.Responses;

namespace ToroChallenge.PapelContexto.Domain.Repositories
{
    public interface IPapelRepository
    {
        BuscaAtivosNegociadosResponse GetAtivosMaisNegociados(BuscaAtivosNegociadosRequest command);
    }
}
