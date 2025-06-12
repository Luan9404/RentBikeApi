namespace RentBikeApi.Core.Domain.Interfaces;

public interface IUnityOfWork
{
    Task Commit();
}