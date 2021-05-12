using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ToroChallenge.Models.Tests
{
    /*
    public class AtivosMaisNegociadosTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ListarMaisVisualizados()
        {
            //ContaCorrente conta = new ContaCorrente();
            Usuario investidor = new Usuario();
            Assert.IsNotNull(investidor.ContaCorrente);
            //Papel papel = new Papel("SANB11", 40.77);
            //Balcao balcao = new Balcao(investidor, papel);
            //balcao.Comprar(3);

        }
    }
    public class ContaCorrente
    {
        public double SaldoDisponivel { get; private set; }

        public void Debitar(double compra)
        {
            SaldoDisponivel -= compra;
        }
    }

    public class Balcao
    {
        public Balcao(Usuario investidor, Papel papel)
        {
            Investidor = investidor;
            Papel = papel;
        }

        public Usuario Investidor { get; }
        public Papel Papel { get; }

        internal void Comprar(int quantidade)
        {
            if (Investidor.ContaCorrente.SaldoDisponivel >= (Papel.Valor * quantidade))
            {
                Investidor.IncluirAtivo(Papel, quantidade);
            }
            throw new NotImplementedException();
        }
    }
    public class Usuario
    {
        public ContaCorrente ContaCorrente { get; private set; }

        internal void IncluirAtivo(Papel papel, int quantidade)
        {
            //DebitarSaldo
            ContaCorrente.Debitar(papel.Valor * quantidade);
            //AlterarQuantidadeAtivo
        }
    }

    public class Papel
    {
        public Papel(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public string Descricao { get; }
        public double Valor { get; }
    }
    */
}
