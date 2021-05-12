using ToroChallenge.PapelContexto.Domain.Handlers.Contracts;
using ToroChallenge.PapelContexto.Domain.Queries.Requests;
using ToroChallenge.PapelContexto.Domain.Queries.Responses;
using ToroChallenge.PapelContexto.Domain.Repositories;

namespace ToroChallenge.PapelContexto.Domain.Handlers
{
    public class BuscaAtivosNegociadosHandler : IBuscaAtivosNegociadosHandler
    {
        IPapelRepository _repository;

        public BuscaAtivosNegociadosHandler(IPapelRepository repository)
        {
            _repository = repository;
        }

        public BuscaAtivosNegociadosResponse Handle(BuscaAtivosNegociadosRequest command)
        {
            return _repository.GetAtivosMaisNegociados(command);
        }
    }
}
