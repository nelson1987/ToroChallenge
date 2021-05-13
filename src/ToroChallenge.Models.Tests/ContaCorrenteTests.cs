using NUnit.Framework;
using ToroChallenge.Domain.Entities;

namespace ToroChallenge.Models.Tests
{
/*
    public class ContaCorrenteTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[TestCase(122.31, 40.77, 3)]
        public void CriarMovimentacaoCredito()//double saldoDisponivel, double valorAcao, int quantidadePapel)
        {
            ContaCorrente conta = new ContaCorrente();
            Assert.IsNotNull(conta.Movimentacoes);
            conta.Creditar(10.00);
            Assert.IsNotNull(conta.SaldoDisponivel);
            Assert.AreEqual(conta.SaldoDisponivel, 10.00);
        }

        public void CriarMovimentacaoDebito()//double saldoDisponivel, double valorAcao, int quantidadePapel)
        {
            ContaCorrente conta = new ContaCorrente();
            Assert.IsNotNull(conta.Movimentacoes);
            conta.Debitar(10.00);
            Assert.IsNotNull(conta.SaldoDisponivel);
            Assert.AreEqual(conta.SaldoDisponivel, -10.00);

        }

        public void CriarMovimentacao()//double saldoDisponivel, double valorAcao, int quantidadePapel)
        {
            ContaCorrente conta = new ContaCorrente();
            Assert.IsNotNull(conta.Movimentacoes);
            conta.Debitar(10.00);
            Assert.IsNotNull(conta.SaldoDisponivel);
            Assert.AreEqual(conta.SaldoDisponivel, -10.00);
            conta.Creditar(20.00);
            Assert.AreEqual(conta.SaldoDisponivel, 10.00);


            //Acao balcao = new Acao("SANB11", valorAcao);
            //Usuario investidor = new Usuario(saldoDisponivel);
            //investidor.ComprarAtivo(balcao, quantidadePapel);
            //Assert.AreEqual(investidor.ContaCorrente.SaldoDisponivel, saldoDisponivel - (valorAcao * quantidadePapel));
            //Assert.AreEqual(investidor.Carteira.Count, 1);
            
             //* No exemplo acima o usuário deseja comprar 3 ações SANB11. 
             //* Neste caso, a API deve chegar o valor de SANB11 naquele momento (no exemplo, R$40.77), 
             //* verificar se o usuário tem pelo menos R$122.31 disponível em conta corrente e, em caso afirmativo, 
             //* realizar a compra (debitar o saldo e registrar as novas quantidades de ativos SANB11 ao cliente). 
             //* Caso não tenha saldo suficiente, ou o ativo informado seja invalido, a API deve retornar uma codido e 
             //* uma mensagem de erro indicando "saldo insuficiente" ou "ativo invalido". 
             //* Esta operação deve impactar o saldo e a lista de ativos do usuário.

            //Frontend:
           // Para o Frontend, você deve oferecer um fluxo onde o usuário veja lista dos ativos mais negociados, 
            //o valor de cada um, e possa clicar em um deles para comprar. Ao clicar, usuário deve informar 
            //a quantidade desejada para compra e submeter a ordem. Em caso de sucesso, usuário deve visualizar 
            //mensagem de sucesso e seu novo saldo e novas posições de ativos. Em caso de erro (saldo insuficiente) 
            //deverá ver msg apropriada.
             
        }
    }

    public class ContaCorrente
    {
        public double SaldoDisponivel { get; private set; }

        internal void Debitar(double v)
        {
            SaldoDisponivel -= v;
        }
    }

    public class Usuario
    {
        public Usuario(double saldoDisponivel)
        {
            Carteira = new List<Acao>();
            ContaCorrente = new ContaCorrente();
        }
        public List<Acao> Carteira { get; private set; }

        public ContaCorrente ContaCorrente { get; private set; }

        internal void ComprarAtivo(Acao acao, int quantidade)
        {
            if (ValidarDisponibilidadeAtivo(acao, quantidade) && ValidarSaldoDisponivel(acao, quantidade))
            {
                ContaCorrente.Debitar(acao.Valor * quantidade);
            }
        }

        private bool ValidarSaldoDisponivel(Acao acao, int quantidade)
        {
            return ContaCorrente.SaldoDisponivel <= (acao.Valor * quantidade);
        }
        private bool ValidarDisponibilidadeAtivo(Acao acao, int quantidade)
        {
            return acao.Quantidade >= quantidade;
        }
    }
    public class Acao
    {
        public Acao(string codigo, double valorAtual)
        {
            Codigo = codigo;
            Valor = valorAtual;
        }

        public string Codigo { get; }
        public double Valor { get; }
        public int Quantidade { get; internal set; }
    }*/
}
