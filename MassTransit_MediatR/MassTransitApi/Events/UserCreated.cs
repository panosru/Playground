namespace MassTransitApi.Events
{
    using System;
    using System.Threading.Tasks;
    using MassTransit;

    public interface UserCreated
    {
        public Guid Id { get; set; }

        public DateTime Created { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }

    public class InformAboutUserCreation :
        IConsumer<UserCreated>
    {
        public Task Consume(ConsumeContext<UserCreated> context)
        {
            Console.WriteLine($"User created: {context.Message.Name} {context.Message.Surname}");
            return Task.CompletedTask;
        }
    }

    public class EmailCreatedUser :
        IConsumer<UserCreated>
    {
        public Task Consume(ConsumeContext<UserCreated> context)
        {
            Console.WriteLine($"Emailing user: {context.Message.Name} {context.Message.Surname}");
            return Task.CompletedTask;
        }
    }
}