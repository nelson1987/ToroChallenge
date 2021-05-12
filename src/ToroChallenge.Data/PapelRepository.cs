using System;
using System.Collections.Generic;
using System.Linq;
using ToroChallenge.PapelContexto.Domain.Commands.Requests;
using ToroChallenge.PapelContexto.Domain.Entities;
using ToroChallenge.PapelContexto.Domain.Queries.Requests;
using ToroChallenge.PapelContexto.Domain.Repositories;

namespace ToroChallenge.Data
{
    public class PapelRepository : IPapelRepository
    {
        public IQueryable<Ordem> GetAtivosMaisNegociados(SubmeteOrdemRequest command)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Papel> GetAtivosMaisNegociados(BuscaAtivosNegociadosRequest command)
        {
            var papeis = new List<Papel>()
            {
                new Papel("PETR4",  28.44),
                new Papel("MGLU3",25.91),
                new Papel("VVAR3",25.91),
                new Papel("SANB11",40.77),
                new Papel("TORO4",115.98)
            }.AsQueryable();
            return papeis;
        }
    }
}
