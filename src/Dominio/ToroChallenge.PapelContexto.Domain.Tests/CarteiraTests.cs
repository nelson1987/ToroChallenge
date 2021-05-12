using NUnit.Framework;
using System.Linq;
using ToroChallenge.PapelContexto.Domain.Entities;

namespace ToroChallenge.PapelContexto.Domain.Tests
{
    public class CarteiraTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("", "SANB11", 3, true, "Conta", Category = "CONTA_DEVE_ESTAR_PREENCHIDO_SENAO_ORDEM_SERA_INVALIDADA")]
        [TestCase(null, "SANB11", 3, true, "Conta", Category = "CONTA_DEVE_ESTAR_PREENCHIDO_SENAO_ORDEM_SERA_INVALIDADA")]
        [TestCase("1234", "", 3, true, "Papel", Category = "PAPEL_DEVE_ESTAR_PREENCHIDO_SENAO_ORDEM_SERA_INVALIDADA")]
        [TestCase("1234", null, 3, true, "Papel", Category = "PAPEL_DEVE_ESTAR_PREENCHIDO_SENAO_ORDEM_SERA_INVALIDADA")]
        [TestCase("1234", "SANB11", 0, true, "Quantidade", Category = "QUANTIDADE_DEVE_ESTAR_PREENCHIDO_E_SER_MAIOR_QUE_ZERO_SENAO_ORDEM_SERA_INVALIDADA")]
        [TestCase("1234", "SANB11", null, true, "Quantidade", Category = "QUANTIDADE_DEVE_ESTAR_PREENCHIDO_E_SER_MAIOR_QUE_ZERO_SENAO_ORDEM_SERA_INVALIDADA")]
        [TestCase("1234", "SANB11", 3, true, "Valor", Category = "ORDEM_VALIDA")]
        public void RealizarOrdem(string conta, string papel, int quantidade, bool valida, string propriedadeErro)
        {
            Ordem compra = new Ordem(conta, papel, quantidade);

            if (!valida)
                Assert.IsTrue(compra.Errors.Any(x => x.Propriedade == propriedadeErro));

            Assert.AreEqual(compra.IsValid, valida);
        }
    }
}
