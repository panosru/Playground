namespace ValueObjectsCS8
{
    public sealed class FullNameVo : ValueObject
    {
        public FullNameVo(string name, string surname)
        {
            Name    = name;
            Surname = surname;
        }

        [IgnoreMember]
        public string Name { get; }

        public string Surname { get; }

        [IgnoreMember]
        public string FullName => $"{Name} {Surname}";
    }
}