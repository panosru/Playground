namespace ValueObjectsCS9
{
    public sealed record FullNameVo : ValueObject
    {
        [IgnoreMember]
        public string Name { get; init; }

        public string Surname { get; init; }

        [IgnoreMember]
        public string FullName => $"{Name} {Surname}";
    }
}