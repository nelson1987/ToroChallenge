using NUnit.Framework;
using System.Linq;
using ToroChallenge.TransferenciaContexto.Domain.Entities;

namespace ToroChallenge.TransferenciaContexto.Domain.Tests
{
    public class TransferenciaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("", "", "", "", 0.00, false, "Documento", Category = "VALIDAR_SE_TRANSFERENCIA_VALIDA")]
        [TestCase(null, null, null, null, 0.00, false, "Documento", Category = "VALIDAR_SE_TRANSFERENCIA_VALIDA")]
        [TestCase("", "1234", "0001", "352", 0.01, false, "Documento", Category = "DOCUMENTO_DEVE_ESTAR_PREENCHIDO_SENAO_TRANSFERENCIA_SER_INVALIDADA")]
        [TestCase(null, "1234", "0001", "352", 0.01, false, "Documento", Category = "DOCUMENTO_DEVE_ESTAR_PREENCHIDO_SENAO_TRANSFERENCIA_SER_INVALIDADA")]
        [TestCase("12345678901", "", "0001", "352", 0.01, false, "Conta", Category = "CONTA_DEVE_ESTAR_PREENCHIDA_SENAO_TRANSFERENCIA_SER_INVALIDADA")]
        [TestCase("12345678901", null, "0001", "352", 0.01, false, "Conta", Category = "CONTA_DEVE_ESTAR_PREENCHIDA_SENAO_TRANSFERENCIA_SER_INVALIDADA")]
        [TestCase("12345678901", "1234", "", "352", 0.01, false, "Agencia", Category = "AGENCIA_DEVE_ESTAR_PREENCHIDA_E_SER_0001_SENAO_TRANSFERENCIA_SER_INVALIDADA")]
        [TestCase("12345678901", "1234", null, "352", 0.01, false, "Agencia", Category = "AGENCIA_DEVE_ESTAR_PREENCHIDA_E_SER_0001_SENAO_TRANSFERENCIA_SER_INVALIDADA")]
        [TestCase("12345678901", "1234", "0001", "", 0.01, false, "Banco", Category = "BANCO_DEVE_ESTAR_PREENCHIDA_E_SER_352_SENAO_TRANSFERENCIA_SER_INVALIDADA")]
        [TestCase("12345678901", "1234", "0001", null, 0.01, false, "Banco", Category = "BANCO_DEVE_ESTAR_PREENCHIDA_E_SER_352_SENAO_TRANSFERENCIA_SER_INVALIDADA")]
        [TestCase("12345678901", "1234", "0001", "352", 0.00, false, "Valor", Category ="VALOR_DEVE_ESTAR_PREENCHIDO_E_SER_MAIOR_QUE_ZERO_SENAO_TRANSFERENCIA_SER_INVALIDADA")]
        [TestCase("12345678901", "1234", "0001", "352", 0.01, true, "Valor", Category = "TRANSFERENCIA_VALIDA")]
        public void RealizarTransferencia(string documentoOrigem, string contaDestino, string agenciaDestino, string bancoDestino, double valor, bool valida, string propriedadeErro)
        {
            Transferencia transferencia = new Transferencia(documentoOrigem, contaDestino, agenciaDestino, bancoDestino, valor);

            if (!valida)
                Assert.IsTrue(transferencia.Errors.Any(x => x.Propriedade == propriedadeErro));

            Assert.AreEqual(transferencia.IsValid, valida);
        }
    }
}
