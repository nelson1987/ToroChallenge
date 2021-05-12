using ToroChallenge.Domain;

namespace ToroChallenge.PapelContexto.Domain.Entities
{
    public class Ordem : Notification
    {
        public Ordem(string conta, string papel, int quantidade)
        {
            if (string.IsNullOrEmpty(conta))
                AddNotification("Conta", "Número de conta inválido.");
            if (string.IsNullOrEmpty(papel))
                AddNotification("Papel", "Nome de papel inválido.");
            if (quantidade <= 0)
                AddNotification("Quantidade", "Quantidade comprada inválida.");
            Conta = conta;
            Papel = papel;
            Quantidade = quantidade;
        }

        public string Conta { get; }
        public string Papel { get; }
        public int Quantidade { get; }
    }
}
