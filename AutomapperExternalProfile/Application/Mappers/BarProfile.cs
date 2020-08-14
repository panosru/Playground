namespace Application.Mappers
{
    using AutoMapper;
    using Core.Entities;
    using Dto;

    public class BarProfile : Profile
    {
        public BarProfile()
        {
            CreateMap<FooEntity, BarDto>();
        }
    }
}