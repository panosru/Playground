namespace ValueObjectsCS9
{
    public sealed record FullNameVo
    {
        public string Name { get; init; }

        public string Surname { get; init; }

        public string FullName => $"{Name} {Surname}";
    }
}