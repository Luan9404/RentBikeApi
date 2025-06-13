using MediatR;
using RabbitMQ.Client.Core.DependencyInjection.Services.Interfaces;
using RentBikeApi.Core.Application.UseCases.Motorcycles.CreateMotorcycle;

namespace RentBikeApi.Core.Application.Notification;

public class NotificationHandler(IProducingService queueService) : INotificationHandler<CreateMotorcycleNotification>
{

    public Task Handle(CreateMotorcycleNotification notification, CancellationToken cancellationToken)
    {
        return Task.Run(() =>
        {
            queueService.SendAsync<string>("asdf", "motorcycle-created", "main");
            Console.WriteLine($"Created motorcycle with Identifier: {notification.Identifier}, " +
                              $"Year: {notification.Year}, License Plate: {notification.LicensePlate}, " +
                              $"Model: {notification.Model}");
        }, cancellationToken);
    }
}