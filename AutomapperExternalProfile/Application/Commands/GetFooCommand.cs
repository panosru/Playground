namespace Application.Commands
{
    using System.Linq;
    using Application;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Dto;


    public class GetFooCommand
    {
        private readonly IApplicationDbContext _context;

        private readonly IMapper _mapper;

        public GetFooCommand(IMapper mapper, IApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public FooDto Get()
        {
            return _context.Foo
                .ProjectTo<FooDto>(_mapper.ConfigurationProvider)
                .First();
        }
    }
}