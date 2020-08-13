namespace Application.Dto
{
    using Core.Entities;
    using Core.Mapping;

    public class FooDto : IMapFrom<FooEntity>
    {
        public string Title { get; set; }

        public string Category { get; set; }

        public int Views { get; set; }

        public string Notes { get; set; }

        public void Mapping(MappingProfileBase profile)
        {
            profile.CreateMap<FooEntity, FooDto>()
                .ForMember(
                    d =>
                        d.Views,
                    opt =>
                        opt.MapFrom(s => s.Views));
        }
    }
}