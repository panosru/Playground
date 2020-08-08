namespace MassTransitApi.Commands
{
    using System;
    using System.Threading.Tasks;
    using Events;
    using MassTransit;

    public interface CreateUser
    {
        public Guid Id { get; set; }

        public DateTime Created { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }

    public class UserConsumer :
        IConsumer<UserCreated>
    {
        public async Task Consume(ConsumeContext<UserCreated> context)
        {
            await context.RespondAsync<UserCreated>(new
            {
                context.Message.Id,
                context.Message.Created,
                context.Message.Name,
                context.Message.Surname
            });
        }
    }
}