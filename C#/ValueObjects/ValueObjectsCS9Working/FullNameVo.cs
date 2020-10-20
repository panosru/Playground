namespace ValueObjectsCS9Working
{
    public sealed record FullNameVo : ValueObject
    {
        [IgnoreMember]
        public string? Name;

        public string? Surname;

        [IgnoreMember]
        public string FullName => $"{Name} {Surname}";

        public bool Equals(FullNameVo? other) =>
            base.Equals(other);
    }
}