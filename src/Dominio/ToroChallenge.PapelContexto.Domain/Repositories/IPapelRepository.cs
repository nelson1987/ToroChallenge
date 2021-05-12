using System.Linq;
using ToroChallenge.PapelContexto.Domain.Commands.Requests;
using ToroChallenge.PapelContexto.Domain.Entities;
using ToroChallenge.PapelContexto.Domain.Queries.Requests;

namespace ToroChallenge.PapelContexto.Domain.Repositories
{
    public interface IPapelRepository
    {
        IQueryable<Ordem> GetAtivosMaisNegociados(SubmeteOrdemRequest command);
        IQueryable<Papel> GetAtivosMaisNegociados(BuscaAtivosNegociadosRequest command);
    }
}
