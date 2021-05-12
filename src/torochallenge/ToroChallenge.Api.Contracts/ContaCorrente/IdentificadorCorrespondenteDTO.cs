using System.Text.Json.Serialization;

namespace ToroChallenge.Api.Contracts.ContaCorrente
{
    public abstract class IdentificadorCorrespondenteDTO
    {
        [JsonPropertyName("bank")]
        public string CodigoCompe { get; set; }
        [JsonPropertyName("branch")]
        public string Agencia { get; set; }
    }
}
