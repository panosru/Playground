namespace AutomapperExternalProfile.Dto
{
    using AutoMapper;
    using Entities;
    using InternalLibrary.Mapping;

    public class FooDto : IMapFrom<FooEntity>
    {
        public string Title { get; set; }

        public string Category { get; set; }

        public int Views { get; set; }
        
        public string Notes { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<FooEntity, FooDto>()
                .ForMember(d => 
                        d.Views, 
                    opt => 
                        opt.MapFrom(s => (int) s.Views));
        }
    }
}