using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using ToroChallenge.TransferenciaContexto.Domain.Commands.Requests;
using ToroChallenge.TransferenciaContexto.Domain.Commands.Responses;
using ToroChallenge.TransferenciaContexto.Domain.Repositories;

namespace ToroChallenge.TransferenciaContexto.Domain.Handlers
{
    public class RecebeTransferenciaHandler : IRequestHandler<RecebeTransferenciaRequest, RecebeTransferenciaResponse>
    {
        IContaCorrenteRepository _repository;
        public RecebeTransferenciaHandler(IContaCorrenteRepository repository)
        {
            _repository = repository;
        }

        public Task<RecebeTransferenciaResponse> Handle(RecebeTransferenciaRequest request, CancellationToken cancellationToken)
        {
            var conta = _repository.Buscar(request.BancoDestino, request.AgenciaDestino, request.ContaDestino);

            if (conta == null)
                return null;

            conta.Creditar(request.Valor);

            _repository.Alterar(conta);

            var result = new RecebeTransferenciaResponse
            {
                //Id = conta.Id,
                Evento = request.Evento,
                BancoDestino = request.BancoDestino,
                AgenciaDestino = request.AgenciaDestino,
                ContaDestino = request.ContaDestino,
                BancoOrigem = request.BancoOrigem,
                AgenciaOrigem = request.AgenciaOrigem,
                DocumentoOrigem = request.DocumentoOrigem,
                Valor = request.Valor,
                Criacao = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
