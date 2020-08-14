namespace API.Controllers
{
    using System.Threading.Tasks;
    using Application.Commands;
    using Application.Dto;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class FooController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FooController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<FooDto> Get()
        {
            return await _mediator.Send(new GetFooCommand());
        }
    }
}