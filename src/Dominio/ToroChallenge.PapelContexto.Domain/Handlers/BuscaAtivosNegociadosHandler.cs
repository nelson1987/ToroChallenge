using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ToroChallenge.PapelContexto.Domain.Queries.Requests;
using ToroChallenge.PapelContexto.Domain.Queries.Responses;
using ToroChallenge.PapelContexto.Domain.Repositories;

namespace ToroChallenge.PapelContexto.Domain.Handlers
{
    public class BuscaAtivosNegociadosHandler : IRequestHandler<BuscaAtivosNegociadosRequest, IQueryable<BuscaAtivosNegociadosResponse>>
    {
        IPapelRepository _repository;

        public BuscaAtivosNegociadosHandler(IPapelRepository repository)
        {
            _repository = repository;
        }

        public Task<IQueryable<BuscaAtivosNegociadosResponse>> Handle(BuscaAtivosNegociadosRequest request, CancellationToken cancellationToken)
        {
            var ativos = _repository.GetAtivosMaisNegociados(request).Select(x => new BuscaAtivosNegociadosResponse()
                {
                    Codigo = x.Codigo,
                    PrecoAtual = x.Valor
                });

            return Task.FromResult(ativos);
        }
    }
}
