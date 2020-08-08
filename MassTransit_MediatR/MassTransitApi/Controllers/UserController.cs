namespace MassTransitApi.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Events;
    using MassTransit;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        private readonly IPublishEndpoint _endpoint;
        private readonly IRequestClient<UserCreated> _requestClient;

        public UserController(IRequestClient<UserCreated> requestClient, IPublishEndpoint endpoint)
        {
            _requestClient = requestClient;
            _endpoint = endpoint;
        }

        [HttpPost]
        public async Task<UserCreated> Post(string name, string surname)
        {
            var id = Guid.NewGuid();
            var userObj = new
            {
                Id = id,
                Created = DateTime.Now,
                Name = name,
                Surname = surname
            };

            var user = await _requestClient
                .GetResponse<UserCreated>(userObj);

            await _endpoint.Publish<UserCreated>(userObj);


            return user.Message;
        }
    }
}