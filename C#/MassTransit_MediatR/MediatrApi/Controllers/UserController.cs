namespace MediatrApi.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Commands;
    using Dtos;
    using Events;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<User> Post([FromBody] CreateUser command)
        {
            Console.WriteLine("Calling the API method");
            
            var user = await _mediator.Send(command);

            await _mediator.Publish(new UserCreated
            {
                Name = user.Name,
                Surname = user.Surname
            });

            return user;
        }
    }
}