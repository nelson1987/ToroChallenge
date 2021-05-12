using ToroChallenge.Domain.Entities;

namespace ToroChallenge.Domain.Repositories
{
    public interface IContaCorrenteRepository
    {
        ContaCorrente Buscar(string bancoDestino, string agenciaDestino, string contaDestino);
        void Salvar(ContaCorrente conta);
    }
}
