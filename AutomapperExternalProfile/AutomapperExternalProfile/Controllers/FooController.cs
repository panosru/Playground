namespace AutomapperExternalProfile.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using MyApp.Dto;

    [ApiController]
    [Route("[controller]")]
    public class FooController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public FooController(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public object Get()
        {
            return new { Data = _context.Foo.ProjectTo<FooDto>(_mapper.ConfigurationProvider)};
        }
    }
}