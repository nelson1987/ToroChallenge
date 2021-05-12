using ToroChallenge.Domain.Handlers.Contracts;
using ToroChallenge.Domain.Queries.Requests;
using ToroChallenge.Domain.Repositories;

namespace ToroChallenge.Domain.Queries.Responses
{
    public class BuscaAtivosNegociadosHandler : IBuscaAtivosNegociadosHandler
    {
        IPapelRepository _repository;

        public BuscaAtivosNegociadosHandler(IPapelRepository repository)
        {
            _repository = repository;
        }

        public BuscaAtivosNegociadosResponse Handler(BuscaAtivosNegociadosRequest command)
        {
            return _repository.GetAtivosMaisNegociados(command);
        }
    }
}
