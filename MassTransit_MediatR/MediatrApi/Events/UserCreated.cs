namespace MediatrApi.Events
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class UserCreated : INotification
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class InformAboutUserCreation : INotificationHandler<UserCreated>
    {
        public Task Handle(UserCreated notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"User created: {notification.Name} {notification.Surname}");
            return Task.CompletedTask;
        }
    }

    public class EmailCreatedUser : INotificationHandler<UserCreated>
    {
        public Task Handle(UserCreated notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Emailing user: {notification.Name} {notification.Surname}");
            return Task.CompletedTask;
        }
    }
}