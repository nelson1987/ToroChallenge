using System;
using ToroChallenge.Api.Contracts.ContaCorrente;

namespace ToroChallenge.Application
{
    public class SensibilizaContaCorrenteService : ISensibilizaContaCorrente
    {
        private readonly ContaCorrenteBusiness _business { get; set; }
        public void InserirMovimentacao(EventoDTO eventoSpb) 
        {
            var conta = BuscarContaCorrente(eventoSpb.Destino);
            if (conta != null)
            { 

            }
        }
        public ContaCorrente BuscarContaCorrente(DestinoEventoDTO contaDestino) 
        {
            return _business.Buscar(contaDestino.CodigoCompe, contaDestino.Conta, contaDestino.Agencia);
        }
    }
    public class ContaCorrente 
    {
    }
}
