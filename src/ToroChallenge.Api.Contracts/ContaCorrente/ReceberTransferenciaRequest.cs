using System.Text.Json.Serialization;

namespace ToroChallenge.Api.Contracts.ContaCorrente
{
    public class ReceberTransferenciaDTO
    {
        [JsonPropertyName("event")]
        public string Evento { get; set; }
        [JsonPropertyName("origin")]
        public OrigemEventoDTO Origem { get; set; }
        [JsonPropertyName("target")]
        public DestinoEventoDTO Destino { get; set; }
        [JsonPropertyName("amount")]
        public decimal Valor { get; set; }
    }
}
