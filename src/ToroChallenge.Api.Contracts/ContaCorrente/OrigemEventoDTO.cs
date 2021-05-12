using System.Text.Json.Serialization;

namespace ToroChallenge.Api.Contracts.ContaCorrente
{
    public class OrigemEventoDTO : IdentificadorCorrespondenteDTO
    {
        [JsonPropertyName("cpf")]
        public string Documento { get; set; }
    }
}
