namespace Application.Commands
{
    using System.Linq;
    using Application;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Core.Entities;
    using Dto;


    public class GetBarCommand
    {
        private readonly IApplicationDbContext _context;

        private readonly IMapper _mapper;

        public GetBarCommand(IMapper mapper, IApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public BarDto Get()
        {
            return _mapper.Map<FooEntity, BarDto>(_context.Foo.First());
        }
    }
}