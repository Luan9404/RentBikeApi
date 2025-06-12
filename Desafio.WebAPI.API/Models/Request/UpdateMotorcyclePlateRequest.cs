using System.Text.Json.Serialization;

namespace Desafio.WebAPI.API.Models.Request;

public class UpdateMotorcyclePlateRequest
{
    [JsonPropertyName("placa")]
    public string LicensePlate { get; set; }
}