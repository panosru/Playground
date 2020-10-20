namespace ValueObjectsCS9
{
    public sealed record FullNameVo : ValueObject
    {
        [IgnoreMember]
        public string Name;

        public string Surname;

        [IgnoreMember]
        public string FullName => $"{Name} {Surname}";
    }
}