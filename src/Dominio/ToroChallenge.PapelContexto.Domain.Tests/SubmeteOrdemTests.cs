using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using ToroChallenge.Domain.Entities;
using ToroChallenge.Domain.Enums;
using ToroChallenge.PapelContexto.Domain.Repositories;
using ToroChallenge.PapelContexto.Domain.Requests;

namespace ToroChallenge.PapelContexto.Domain.Tests
{
    public class SubmeteOrdemTests
    {
        private SubmeteOrdemRequest _submeteOrdem { get; set; }
        private Mock<IContaCorrenteRepository> _mockRepository;
        [SetUp]
        public void Setup()
        {
            //Request vindo preenchido na integração do SPB
            _submeteOrdem = new SubmeteOrdemRequest();
            _mockRepository = new Mock<IContaCorrenteRepository>();
        }

        [Test]
        public void RealizarCreditoTransferencia()
        {
            //_submeteOrdem.Evento = "TRANSFER";
            //_submeteOrdem.BancoOrigem = "033";
            //_submeteOrdem.AgenciaOrigem = "03312";
            //_submeteOrdem.DocumentoOrigem = "45358996060";
            //_submeteOrdem.BancoDestino = "352";
            //_submeteOrdem.AgenciaDestino = "0001";
            //_submeteOrdem.ContaDestino = "300123";
            //_submeteOrdem.Valor = 1000;

            var contaCorrente = new ContaCorrente()
            {
                Conta = _submeteOrdem.Conta,
                Movimentacoes = new List<Movimentacao>() {
                    new Movimentacao(TipoMovimentacaoEnum.Credito, 10.00)
                }
            };
            _mockRepository.Setup(x => x.Buscar(_recebeTransferencia.BancoDestino, _recebeTransferencia.AgenciaDestino, _recebeTransferencia.ContaDestino)).Returns(contaCorrente);

            //Serviço para realizar o recebimento
            SubmeteOrdemHandler manipulador = new SubmeteOrdemHandler(_mockRepository.Object);
            //Realizar o recebimento
            manipulador.Handle(_recebeTransferencia);

            Assert.AreEqual(contaCorrente.SaldoDisponivel, 1010.00);
        }
    }
}