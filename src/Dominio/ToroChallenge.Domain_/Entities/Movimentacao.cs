using System;
using ToroChallenge.Domain.Enums;

namespace ToroChallenge.Domain.Entities
{
    public class Movimentacao
    {
        public Movimentacao(MovimentacaoEnum tipoMovimentacao, double valor)
        {
            Id = Guid.NewGuid();
            TipoMovimentacao = tipoMovimentacao;
            Valor = valor;
        }

        public Guid Id { get; private set; }
        public MovimentacaoEnum TipoMovimentacao { get; private set; }
        public double Valor { get; private set; }
    }
}
