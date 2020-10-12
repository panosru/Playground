namespace ValueObjectsCS9
{
    public sealed record FullNameVo
    {
        public FullNameVo(string name, string surname)
        {
            Name    = name;
            Surname = surname;
        }

        public string Name { get; }

        public string Surname { get; }

        public string FullName => $"{Name} {Surname}";
    }
}