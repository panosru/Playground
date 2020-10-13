namespace ValueObjectsCS9Failing
{
    public sealed record FullNameVo
    {
        [IgnoreMember]
        public string Name;

        public string Surname;

        [IgnoreMember]
        public string FullName => $"{Name} {Surname}";
    }
}