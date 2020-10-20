namespace MassTransitApi.Commands
{
    using System;
    using System.Threading.Tasks;
    using Events;
    using GreenPipes;
    using MassTransit;
    using MassTransit.ConsumeConfigurators;
    using MassTransit.Definition;
    using Processors;

    public class CreateUser
    {
        public Guid Id { get; set; }

        public DateTime Created { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        
        public int Age { get; set; }
        
        public bool IsAdult { get; set; }
    }

    public class UserConsumer :
        IConsumer<CreateUser>
    {
        public async Task Consume(ConsumeContext<CreateUser> context)
        {
            Console.WriteLine("Consuming CreateUser command");

            await context.RespondAsync<UserCreated>(context.Message);
            
            await context.Publish<UserCreated>(context.Message);
        }
    }

    public class UserConsumerDefinition :
        ConsumerDefinition<UserConsumer>
    {
        protected override void ConfigureConsumer(
            IReceiveEndpointConfigurator endpointConfigurator, 
            IConsumerConfigurator<UserConsumer> consumerConfigurator)
        {
            consumerConfigurator.Message<CreateUser>(m => 
                m.UseFilter(new UserFilter()));
        }
    }
}