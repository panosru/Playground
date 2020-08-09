namespace MassTransitApi.Processors
{
    using System;
    using System.Threading.Tasks;
    using Commands;
    using GreenPipes;
    using MassTransit;

    public class UserFilter :
        IFilter<ConsumeContext<CreateUser>>
    {
        public async Task Send(ConsumeContext<CreateUser> context, IPipe<ConsumeContext<CreateUser>> next)
        {
            Console.WriteLine("Processing User Filter");

            context.Message.IsAdult = context.Message.Age >= 18;
            
            await next.Send(context);
        }

        public void Probe(ProbeContext context)
        {
            context.CreateFilterScope("UserFilter");
        }
    }

    public class UserCreationObserver :
        IConsumeMessageObserver<CreateUser>
    {
        public Task PreConsume(ConsumeContext<CreateUser> context)
        {
            Console.WriteLine("PreConsume");
            
            return Task.CompletedTask;
        }

        public Task PostConsume(ConsumeContext<CreateUser> context)
        {
            Console.WriteLine("PostConsume");
            
            return Task.CompletedTask;
        }

        public Task ConsumeFault(ConsumeContext<CreateUser> context, Exception exception)
        {
            Console.WriteLine("ConsumeFault");
            
            return Task.CompletedTask;
        }
    }
}