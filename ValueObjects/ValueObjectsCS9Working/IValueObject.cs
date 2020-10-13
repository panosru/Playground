namespace ValueObjectsCS9Working
{
    internal interface IValueObject
    {
        public int GetHashCode();

        public int HashValue(int seed, object value);
    }
}