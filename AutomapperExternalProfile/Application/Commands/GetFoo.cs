namespace Application.Commands
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Dto;
    using Microsoft.EntityFrameworkCore;

    public class GetFoo
    {
        private readonly IApplicationDbContext _context;

        private readonly IMapper _mapper;

        public GetFoo(IMapper mapper, IApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public Task<List<FooDto>> GetFooDto()
        {
            return _context.Foo
                .ProjectTo<FooDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}