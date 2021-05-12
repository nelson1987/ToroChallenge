using System;
using System.Collections.Generic;
using System.Linq;
using ToroChallenge.Domain.Enums;

namespace ToroChallenge.Domain.Entities
{
    public class ContaCorrente
    {
        public ContaCorrente()
        {
            Movimentacoes = new List<Movimentacao>();
        }
        public Guid Id { get; set; }
        public List<Movimentacao> Movimentacoes { get; set; }
        public double SaldoDisponivel
        {
            get
            {
                return Movimentacoes.Sum(x => x.Valor * (x.TipoMovimentacao == MovimentacaoEnum.Debito ? -1 : 1));
            }
        }

        public void Debitar(double valor)
        {
            Movimentacoes.Add(new Movimentacao(MovimentacaoEnum.Debito, valor));
        }
        public void Creditar(double valor)
        {
            Movimentacoes.Add(new Movimentacao(MovimentacaoEnum.Credito, valor));
        }
    }
}
