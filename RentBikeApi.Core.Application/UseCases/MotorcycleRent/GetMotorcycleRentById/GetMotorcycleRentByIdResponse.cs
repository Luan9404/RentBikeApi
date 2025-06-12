namespace RentBikeApi.Core.Application.UseCases.MotorcycleRent.GetMotorcycleRentById;

public sealed record GetMotorcycleRentByIdResponse()
{
    public string Identifier { get; set; }
    public decimal DailyValue { get; set; }
    public string DeliveryManIdentifier { get; set; }
    public string MotorcycleIdentifier  { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime ExpectedEndDate { get; set; }
    public DateTime ReturnDate { get; set; }
}