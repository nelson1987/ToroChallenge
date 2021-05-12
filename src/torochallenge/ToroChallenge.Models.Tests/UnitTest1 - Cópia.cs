using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace ToroChallenge.Models.Tests
{
    /*
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
    */
    public class CompraAcaoTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10.00, 5.00, 2, Author = "nelson.neto", Description = "Caso 1 - O Investidor tenta comprar 2 papéis que somados dão um valor igual ao do seu saldo.")]
        //[TestCase(11.00, 4.00, 3, Author = "nelson.neto", Description = "Caso 2 - O Investidor tenta comprar 3 papéis que somados dão um valor menor que o seu saldo.")]
        //[TestCase(12.00, 3.00, 1, Author = "nelson.neto", Description = "Caso 3 - O Investidor tenta comprar 1 papéis que somados dão um valor maior que o seu saldo.")]
        public void ComprarAcaoComSaldo(double saldoCliente, double valorAcao, int quantidade)
        {
            var investidor = new Investidor("05806190790");
            var investido = investidor.Investimento;
            Assert.IsNotNull(investido);

            //var acao = new Investimento();
            //investidor.Investimento.Comprar(1, papel);
            //investidor.Investimento.
            //double saldo = investidor.Investimento.Saldo;
            //investidor.Investimento.Comprar();.Acoes.Add(new Acao()
            //{
            //    Quantidade = 1,
            //    Papel = new Papel()
            //    {
            //        Valor = 1.23
            //    }
            //});
            /*
            Assert.IsNotNull(investidor);
            Assert.IsNotNull(papel);
            investidor.Compra(2, papel);
            Assert.IsNotNull(papel);

            var carteira = investidor.Carteira;
            carteira.Saldo = 0.00;
            CompraPapelFactory fabrica = new CompraPapelFactory();
            //Assert.AreEqual(investidor.Carteira.Count, 0);
            //investidor.Comprar(acao, quantidade);
            //
            //Assert.AreEqual(investidor.Carteira.Count, 1);
            */

        }
    }
    public class Investidor
    {

        public Investidor(string cpf)
        {
            Cpf = cpf;
        }

        private string Cpf { get; set; }
        public Investimento Investimento { get; set; }
        public double ValorInvestido
        {
            get
            {
                return Investimento.Acoes.Sum(x => (x.Quantidade * x.Papel.Valor));
            }
        }
    }
    public class Investimento
    {
        public double Saldo { get; internal set; }
        public List<Acao> Acoes { get; set; }
        public void Comprar(int quantidade, Papel papel)
        {
            Acoes.Add(new Acao(papel, quantidade));
        }
    }
    public class Acao
    {
        public Acao(Papel papel, int quantidade)
        {
            Papel = papel;
            Quantidade = quantidade;
        }

        public int Quantidade { get; set; }
        public Papel Papel { get; set; }
    }
    public class Papel
    {
        public double Valor { get; private set; }
    }
}
