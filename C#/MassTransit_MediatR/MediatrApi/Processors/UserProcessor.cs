namespace MediatrApi.Processors
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Commands;
    using Dtos;
    using MediatR;
    using MediatR.Pipeline;

    public class UserPreProcessor :
        IRequestPreProcessor<CreateUser>
    {
        public Task Process(CreateUser request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Running before the creation of the user {request.Name} {request.Surname}");
            return Task.CompletedTask;
        }
    }

    public class UserPostProcessor :
        IRequestPostProcessor<CreateUser, User>
    {
        public Task Process(CreateUser request, User response, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Running after the creation of the user {response.Name} {response.Surname} with ID {response.Id}");
            return Task.CompletedTask;
        }
    }
}