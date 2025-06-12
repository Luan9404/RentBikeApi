using System.Text.Json.Serialization;

namespace Desafio.Core.Application.UseCases.Motorcycles.GetAllMotorcycles;

public sealed record GetAllMotorcyclesResponse()
{
    [JsonPropertyName("identificador")]
    public string Identifier { get; set; }
    [JsonPropertyName("modelo")]
    public string Model { get; set; }
    [JsonPropertyName("ano")]
    public int Year { get; set; }
    [JsonPropertyName("placa")]
    public string LicensePlate { get; set; }
}