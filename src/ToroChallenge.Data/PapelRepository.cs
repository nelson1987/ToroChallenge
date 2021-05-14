using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using ToroChallenge.PapelContexto.Domain.Commands.Requests;
using ToroChallenge.PapelContexto.Domain.Entities;
using ToroChallenge.PapelContexto.Domain.Queries.Requests;
using ToroChallenge.PapelContexto.Domain.Repositories;

namespace ToroChallenge.Data
{
    public class PapelRepository : Repository<Papel>, IPapelRepository
    {
        public IQueryable<Ordem> GetAtivosMaisNegociados(SubmeteOrdemRequest command)
        {
            using (var connection = new MySqlConnection("Server=mysql;" +
                "Database=torodb; " +
                "Uid=root;" +
                "Pwd=MySql2019!;"))
            {
                //var guid = Guid.NewGuid();
                var idPapel = connection.Query<int>($"select Id = @Id from TB_PAPEL where NOM_PAPEL = {command.Papel}");

                //var count = connection.Execute(@"insert MyTable(colA, colB) values (@a, @b)",
                //    new[] { new { a = 1, b = 1 }, new { a = 2, b = 2 }, new { a = 3, b = 3 } }
                //  );

                connection.Execute(@"INSERT INTO `TB_TRANSACAO` (" +
                    "`IDT_TRANSACAO`, " +
                    "`IDT_USUARIO`, " +
                    "`IDT_PAPEL`, " +
                    "`QTD_TRANSACAO`, " +
                    "`VLR_UNIDADE_PAPEL`, " +
                    "`DTA_TRANSACAO`)VALUES(" +
                    "'@Id', " +
                    "'@IdUsuario', " +
                    "'@IdPapel', " +
                    "'@QtdTransacao', " +
                    "'@VlrUnidadePapel', " +
                    "now());",
                    new[] { new{Id=1, IdUsuario=1, IdPapel=idPapel, QtdTransacao=command.Quantidade, VlrUnidadePapel= 0.40}
                    });
            }
            throw new NotImplementedException();
        }

        public IQueryable<Papel> GetAtivosMaisNegociados(BuscaAtivosNegociadosRequest command)
        {
            using (var connection = new MySqlConnection("Server=mysql;" +
                "Database=torodb; " +
                "Uid=root;" +
                "Pwd=MySql2019!;"))
            {
                connection.Query<Papel>("SELECT NOM_PAPEL, VLR_PAPEL FROM TB_PAPEL");
            }

            Predicate<Papel> predicate = x => x.Codigo.Equals("PETR4");
            var papeis = new List<Papel>()
            {
                new Papel("PETR4",  28.44),
                new Papel("MGLU3",25.91),
                new Papel("VVAR3",25.91),
                new Papel("SANB11",40.77),
                new Papel("TORO4",115.98)
            }.AsQueryable();
            GetAll(predicate);
            return papeis;
        }
    }
}
