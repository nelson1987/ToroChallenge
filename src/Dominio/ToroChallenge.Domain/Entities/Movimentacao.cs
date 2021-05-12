using ToroChallenge.Domain.Enums;

namespace ToroChallenge.Domain.Entities
{
    public class Movimentacao
    {
        public Movimentacao(TipoMovimentacaoEnum tipoMovimentacao, double valor)
        {
            TipoMovimentacao = tipoMovimentacao;
            Valor = valor;
        }

        public TipoMovimentacaoEnum TipoMovimentacao { get; private set; }
        public double Valor { get; private set; }
    }
}
