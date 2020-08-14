namespace API.Controllers
{
    using Application.Commands;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class FooController : ControllerBase
    {
        private readonly GetFoo _controller;

        public FooController(GetFoo controller)
        {
            _controller = controller;
        }

        [HttpGet]
        public object Get()
        {
            return new {Data = _controller.GetFooDto().Result};
        }
    }
}