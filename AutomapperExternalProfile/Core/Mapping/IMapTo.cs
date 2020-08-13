namespace Core.Mapping
{
    public interface IMapTo<T>
    {
        void Mapping(MappingProfileBase profile)
        {
            profile.CreateMap(GetType(), typeof(T));
        }
    }
}