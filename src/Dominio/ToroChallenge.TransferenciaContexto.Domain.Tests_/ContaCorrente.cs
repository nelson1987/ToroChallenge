using System.Collections.Generic;
using System.Linq;

namespace ToroChallenge.Domain.Transferencia.Tests
{
    public class ContaCorrente
    {
        public string Conta { get; set; }
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
    public class Movimentacao
    {
        public Movimentacao(MovimentacaoEnum tipoMovimentacao, double valor)
        {
            TipoMovimentacao = tipoMovimentacao;
            Valor = valor;
        }

        public MovimentacaoEnum TipoMovimentacao { get; private set; }
        public double Valor { get; private set; }
    }
}
