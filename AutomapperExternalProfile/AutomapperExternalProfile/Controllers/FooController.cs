using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AutomapperExternalProfile.Controllers
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Dto;
    using Microsoft.EntityFrameworkCore;

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