namespace API.Controllers
{
    using Application.Commands;
    using Application.Dto;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class FooController : ControllerBase
    {
        private readonly GetFooCommand _fooCommand;

        public FooController(GetFooCommand fooCommand)
        {
            _fooCommand = fooCommand;
        }

        [HttpGet]
        public FooDto Get()
        {
            return _fooCommand.Get();
        }
    }
}