namespace ValueObjectsCS9Failing
{
    using System;

    public sealed record SimpleVo
        : IEquatable<SimpleVo>
    {
        public bool Equals(SimpleVo other) =>
            throw new System.NotImplementedException();

        public override bool Equals(object obj) =>
            obj is SimpleVo other && Equals(other);

        public override int GetHashCode() =>
            throw new System.NotImplementedException();

        public static bool operator ==(SimpleVo left, SimpleVo right) =>
            left.Equals(right);

        public static bool operator !=(SimpleVo left, SimpleVo right) =>
            !left.Equals(right);
    }
}