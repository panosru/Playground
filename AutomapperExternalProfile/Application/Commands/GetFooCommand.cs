namespace Application.Commands
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Application;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Dto;
    using MediatR;
    using Microsoft.EntityFrameworkCore;


    public class GetFooCommand : IRequest<FooDto>
    {
        public GetFooCommand()
        {
        }
    }
    
    public class GetFooCommandHandler : IRequestHandler<GetFooCommand, FooDto>
    {
        private readonly IApplicationDbContext _context;

        private readonly IMapper _mapper;

        public GetFooCommandHandler(IMapper mapper, IApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public Task<FooDto> Handle(GetFooCommand request, CancellationToken cancellationToken)
        {
            return _context.Foo
                .ProjectTo<FooDto>(_mapper.ConfigurationProvider)
                .FirstAsync(cancellationToken);
        }
    }
}