namespace API.Controllers
{
    using Application.Dto;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Infrastructure;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class FooController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public FooController(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public object Get()
        {
            return new {Data = _context.Foo.ProjectTo<FooDto>(_mapper.ConfigurationProvider)};
        }
    }
}