namespace Core.Mapping
{
    public interface IMapFrom<T>
    {
        void Mapping(MappingProfileBase profile)
        {
            profile.CreateMap(typeof(T), GetType());
        }
    }
}