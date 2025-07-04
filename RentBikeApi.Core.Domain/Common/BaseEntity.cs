namespace RentBikeApi.Core.Domain.Common;

public abstract class BaseEntity
{ 
    public Guid Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}