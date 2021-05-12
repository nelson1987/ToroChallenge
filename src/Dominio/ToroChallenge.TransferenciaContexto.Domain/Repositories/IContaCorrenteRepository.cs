using ToroChallenge.Domain.Entities;

namespace ToroChallenge.TransferenciaContexto.Domain.Repositories
{
    public interface IContaCorrenteRepository
    {
        ContaCorrente Buscar(string bancoDestino, string agenciaDestino, string contaDestino);
        void Alterar(ContaCorrente conta);
    }
}