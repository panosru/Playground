namespace MediatrApi.Commands
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Dtos;
    using MediatR;

    public class CreateUser :
        IRequest<User>
    {
        public string Name { get; set; }

        public string Surname { get; set; }
    }

    public class CreateUserHandler :
        IRequestHandler<CreateUser, User>
    {
        public Task<User> Handle(CreateUser request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Created = DateTime.Now,
                Name = request.Name,
                Surname = request.Surname
            };

            return Task.FromResult(user);
        }
    }
}