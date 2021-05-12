using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ToroChallenge.PapelContexto.Domain.Commands.Requests;
using ToroChallenge.PapelContexto.Domain.Commands.Responses;
using ToroChallenge.PapelContexto.Domain.Repositories;

namespace ToroChallenge.PapelContexto.Domain.Handlers
{
    public class SubmeteOrdemHandler : IRequestHandler<SubmeteOrdemRequest, SubmeteOrdemResponse>
    {
        IPapelRepository _repository;

        public SubmeteOrdemHandler(IPapelRepository repository)
        {
            _repository = repository;
        }

        public Task<SubmeteOrdemResponse> Handle(SubmeteOrdemRequest request, CancellationToken cancellationToken)
        {
            var submeter = _repository.GetAtivosMaisNegociados(request);
            return Task.FromResult(new SubmeteOrdemResponse() { });
        }
    }
}
