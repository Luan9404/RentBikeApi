using System.Text.Json.Serialization;

namespace RentBikeApi.WebAPI.API.Models.Request;

public class UploadDriverLicenseRequest
{
    [JsonPropertyName("imagem_cnh")]
    public string Image { get; set; }
}