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
        IConsumeMessageObserver<UserConsumer>
    {
        public Task PreConsume(ConsumeContext<UserConsumer> context)
        {
            Console.WriteLine("PreConsume");
            
            return Task.CompletedTask;
        }
    
        public Task PostConsume(ConsumeContext<UserConsumer> context)
        {
            Console.WriteLine("PostConsume");
            
            return Task.CompletedTask;
        }
    
        public Task ConsumeFault(ConsumeContext<UserConsumer> context, Exception exception)
        {
            Console.WriteLine("ConsumeFault");
            
            return Task.CompletedTask;
        }
    }

    public class UserOvserver :
        IObserver<ConsumeContext<UserConsumer>>
    {
        public void OnCompleted()
        {
            Console.WriteLine("On Completed");
        }
    
        public void OnError(Exception error)
        {
            Console.WriteLine("On Error");
        }
    
        public void OnNext(ConsumeContext<UserConsumer> value)
        {
            Console.WriteLine("On Next");
        }
    }
}