using ToroChallenge.Domain.Handlers.Contracts;
using ToroChallenge.Domain.Queries.Requests;
using ToroChallenge.Domain.Repositories;

namespace ToroChallenge.Domain.Queries.Responses
{
    public class SubmeteOrdemHandler : ISubmeteOrdemHandlerHandler
    {
        IPapelRepository _repository;

        public SubmeteOrdemHandler(IPapelRepository repository)
        {
            _repository = repository;
        }

        public BuscaAtivosNegociadosResponse Handler(BuscaAtivosNegociadosRequest command)
        {
            return _repository.GetAtivosMaisNegociados(command);
        }
    }
}
