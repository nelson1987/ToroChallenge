using NUnit.Framework;

namespace ToroChallenge.Models.Tests
{
    public class Investidor
    {
        public Investidor(double saldoDisponivel)
        {
            SaldoDisponivel = saldoDisponivel;
            Carteira = new List<Acao>();
        }
        public double SaldoDisponivel { get; set; }
        public List<Acao> Carteira { get; set; }
        public void Comprar(Acao acao, int quantidade)
        {
            if (SaldoDisponivel >= (acao.ValorCompra * quantidade))
                Carteira.Add(acao);
        }
    }

    public class Acao
    {
        public Acao(double valorCompra)
        {
            ValorCompra = valorCompra;
        }
        public double ValorCompra { get; set; }
    }
    
    public class CompraAcaoTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10.00, 5.00, 2, Author = "nelson.neto", Description = "Caso 1 - O Investidor tenta comprar 2 papéis que somados dão um valor igual ao do seu saldo.")]
        [TestCase(11.00, 4.00, 3, Author = "nelson.neto", Description = "Caso 2 - O Investidor tenta comprar 3 papéis que somados dão um valor menor que o seu saldo.")]
        [TestCase(12.00, 3.00, 1, Author = "nelson.neto", Description = "Caso 3 - O Investidor tenta comprar 1 papéis que somados dão um valor maior que o seu saldo.")]
        public void ComprarAcaoComSaldo(double saldoCliente, double valorAcao, int quantidade)
        {
            var acao = new Acao(valorAcao);
            var investidor = new Investidor(saldoCliente);
            Assert.AreEqual(investidor.Carteira.Count, 0);
            investidor.Comprar(acao, quantidade);

            Assert.AreEqual(investidor.Carteira.Count, 1);

        }
    }
}
