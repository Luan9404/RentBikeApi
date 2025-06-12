namespace Desafio.Core.Domain.Interfaces;

public interface IUnityOfWork
{
    Task Commit();
}