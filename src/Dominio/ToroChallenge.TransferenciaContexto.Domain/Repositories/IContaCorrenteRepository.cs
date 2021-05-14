using ToroChallenge.Domain.Entities;
using ToroChallenge.Domain.Repositories;

namespace ToroChallenge.TransferenciaContexto.Domain.Repositories
{
    public interface IContaCorrenteRepository : IRepository<ContaCorrente>
    {
        ContaCorrente Buscar(string bancoDestino, string agenciaDestino, string contaDestino);
        void Alterar(ContaCorrente conta);
    }
}