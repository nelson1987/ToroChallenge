namespace ToroChallenge.Domain.Transferencia.Tests
{
    public class Transferencia : Notification
    {
        public Transferencia(string documentoOrigem, string contaDestino, string agenciaDestino, string bancoDestino, double valor)
        {
            if (string.IsNullOrEmpty(documentoOrigem))
                AddNotification("Documento", "Número de CPF inválido.");
            if (string.IsNullOrEmpty(contaDestino))
                AddNotification("Conta", "Número da conta deve estar preenchido.");
            if (agenciaDestino != "0001")
                AddNotification("Agencia", "Agência inexistente na IF");
            if (bancoDestino != "352")
                AddNotification("Banco", "Número Compe não pertence a esta IF");
            if (valor <= 0.00)
                AddNotification("Valor", "Valor de transferênica rejeitado pela IF.");

            Documento = documentoOrigem;
            Conta = contaDestino;
            Agencia = agenciaDestino;
            Banco = bancoDestino;
            Valor = valor;
        }

        public string Documento { get; }
        public string Conta { get; }
        public string Agencia { get; }
        public string Banco { get; }
        public double Valor { get; }
    }
}
