using MediatR;
using System.Linq;
using ToroChallenge.PapelContexto.Domain.Queries.Responses;

namespace ToroChallenge.PapelContexto.Domain.Queries.Requests
{
    public class BuscaAtivosNegociadosRequest : IRequest<IQueryable<BuscaAtivosNegociadosResponse>>
    {
    }
}
