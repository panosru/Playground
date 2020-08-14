namespace API.Controllers
{
    using Application.Commands;
    using Application.Dto;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]/[action]")]
    public class DemoController : ControllerBase
    {
        private readonly GetFooCommand _fooCommand;
        private readonly GetBarCommand _barCommand;

        public DemoController(
            GetFooCommand fooCommand,
            GetBarCommand barCommand)
        {
            _fooCommand = fooCommand;
            _barCommand = barCommand;
        }

        [HttpGet]
        public FooDto GetFoo()
        {
            return _fooCommand.Get();
        }

        [HttpGet]
        public BarDto GetBar()
        {
            return _barCommand.Get();
        }
    }
}