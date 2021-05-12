using System;
using ToroChallenge.Domain.Commands.Requests;
using ToroChallenge.Domain.Commands.Responses;
using ToroChallenge.Domain.Handlers.Contracts;
using ToroChallenge.Domain.Repositories;

namespace ToroChallenge.Domain.Handlers
{
    public class RecebimentoTransferenciaHandler : IRecebimentoTransferenciaHandler
    {
        IContaCorrenteRepository _repository;
        public RecebimentoTransferenciaHandler(IContaCorrenteRepository repository)
        {
            _repository = repository;
        }

        public ReceberTransferenciaResponse Handle(ReceberTransferenciaRequest command)
        {
            var conta = _repository.Buscar(command.BancoDestino, command.AgenciaDestino, command.ContaDestino);

            if (conta == null)
                throw new Exception();

            conta.Creditar(command.Valor);

            _repository.Salvar(conta);

            return new ReceberTransferenciaResponse
            {
                Id = conta.Id,
                Evento = command.Evento,
                BancoDestino = command.BancoDestino,
                AgenciaDestino = command.AgenciaDestino,
                ContaDestino = command.ContaDestino,
                BancoOrigem = command.BancoOrigem,
                AgenciaOrigem = command.AgenciaOrigem,
                DocumentoOrigem = command.DocumentoOrigem,
                Valor = command.Valor,
                Criacao = DateTime.Now
            };
        }
    }
}
