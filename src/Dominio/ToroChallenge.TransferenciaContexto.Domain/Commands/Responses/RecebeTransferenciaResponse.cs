using ToroChallenge.Domain;

namespace ToroChallenge.TransferenciaContexto.Domain.Commands.Responses
{
    public class RecebeTransferenciaResponse : DefaultResponse
    {
        public string Evento { get; set; }
        public string BancoDestino { get; set; }
        public string AgenciaDestino { get; set; }
        public string ContaDestino { get; set; }
        public string BancoOrigem { get; set; }
        public string AgenciaOrigem { get; set; }
        public string DocumentoOrigem { get; set; }
        public double Valor { get; set; }
    }
}
