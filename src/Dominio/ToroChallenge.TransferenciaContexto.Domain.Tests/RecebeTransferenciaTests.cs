using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;
using ToroChallenge.Domain.Entities;
using ToroChallenge.Domain.Enums;
using ToroChallenge.TransferenciaContexto.Domain.Commands.Requests;
using ToroChallenge.TransferenciaContexto.Domain.Handlers;
using ToroChallenge.TransferenciaContexto.Domain.Repositories;

namespace ToroChallenge.TransferenciaContexto.Domain.Tests
{
    public class RecebeTransferenciaTests
    {
        private RecebeTransferenciaRequest _recebeTransferencia { get; set; }
        private Mock<IContaCorrenteRepository> _mockRepository;
        [SetUp]
        public void Setup()
        {
            //Request vindo preenchido na integração do SPB
            _recebeTransferencia = new RecebeTransferenciaRequest();
            _mockRepository = new Mock<IContaCorrenteRepository>();
        }

        [Test]
        public void RealizarCreditoTransferencia()
        {
            _recebeTransferencia.Evento = "TRANSFER";
            _recebeTransferencia.BancoOrigem = "033";
            _recebeTransferencia.AgenciaOrigem = "03312";
            _recebeTransferencia.DocumentoOrigem = "45358996060";
            _recebeTransferencia.BancoDestino = "352";
            _recebeTransferencia.AgenciaDestino = "0001";
            _recebeTransferencia.ContaDestino = "300123";
            _recebeTransferencia.Valor = 1000;

            var contaCorrente = new ContaCorrente()
            {
                Conta = _recebeTransferencia.ContaDestino,
                Movimentacoes = new List<Movimentacao>() {
                    new Movimentacao(TipoMovimentacaoEnum.Credito, 10.00)
                }
            };
            _mockRepository.Setup(x => x.Buscar(_recebeTransferencia.BancoDestino, _recebeTransferencia.AgenciaDestino, _recebeTransferencia.ContaDestino)).Returns(contaCorrente);

            //Serviço para realizar o recebimento
            RecebeTransferenciaHandler manipulador = new RecebeTransferenciaHandler(_mockRepository.Object);
            var token = new CancellationToken();
            //Realizar o recebimento
            manipulador.Handle(_recebeTransferencia, token);

            Assert.AreEqual(contaCorrente.SaldoDisponivel, 1010.00);
        }
    }
}