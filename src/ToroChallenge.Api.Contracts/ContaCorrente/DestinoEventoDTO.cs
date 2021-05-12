using System.Text.Json.Serialization;

namespace ToroChallenge.Api.Contracts.ContaCorrente
{
    public class DestinoEventoDTO : IdentificadorCorrespondenteDTO
    {
        [JsonPropertyName("account")]
        public string Conta { get; set; }
    }
}
