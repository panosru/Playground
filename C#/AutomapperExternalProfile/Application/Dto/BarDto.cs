namespace Application.Dto
{
    using AutoMapper;
    using Core.Entities;

    public class BarDto
    {
        public string Title { get; set; }

        public string Category { get; set; }

        // public void Mapping(Profile profile)
        // {
        //     profile.CreateMap<FooEntity, FooDto>()
        //         .ForMember(
        //             dest => dest.ReadTimes,
        //             opt =>
        //                 opt.MapFrom(src => src.Views));
        // }
    }
}