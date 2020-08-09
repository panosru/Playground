namespace MassTransitApi.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Commands;
    using Events;
    using MassTransit;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        private readonly IRequestClient<CreateUser> _requestClient;

        public UserController(IRequestClient<CreateUser> requestClient)
        {
            _requestClient = requestClient;
        }

        [HttpPost]
        public async Task<UserCreated> Post(string name, string surname, int age)
        {
            Console.WriteLine("Calling the API method");
            
            var user = await _requestClient
                .GetResponse<UserCreated>(new CreateUser
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    Name = name,
                    Surname = surname,
                    Age = age
                });

            return user.Message;
        }
    }
}