namespace ValueObjectsCS9
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public abstract record ValueObject : IValueObject
    {
        public static IEqualityComparer<ValueObject> EqualityComparer { get; } = new ValueObjectEqualityComparer();

        private sealed class ValueObjectEqualityComparer : IEqualityComparer<ValueObject>
        {
            private List<FieldInfo>? _fields;

            private List<PropertyInfo>? _properties;

            public bool Equals(ValueObject? left, ValueObject? right)
            {
                if (left is null
                 || right is null
                 || left.GetType() != right.GetType()) return false;

                return GetProperties(left)
                          .All(
                               p => PropertiesAreEqual(left, right, p))
                    && GetFields(left)
                          .All(
                               f => FieldsAreEqual(left, right, f));
            }

            private static bool PropertiesAreEqual(
                object       left,
                object       right,
                PropertyInfo p) =>
                Equals(p.GetValue(left, null), p.GetValue(right, null));

            private static bool FieldsAreEqual(
                object    left,
                object    right,
                FieldInfo f) =>
                Equals(f.GetValue(left), f.GetValue(right));

            private IEnumerable<PropertyInfo> GetProperties(object valueObject)
            {
                return _properties ??= valueObject.GetType()
                   .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                   .Where(p => p.GetCustomAttribute(typeof(IgnoreMemberAttribute)) is null)
                   .ToList();
            }

            private IEnumerable<FieldInfo> GetFields(object valueObject)
            {
                return _fields ??= valueObject.GetType()
                   .GetFields(BindingFlags.Instance | BindingFlags.Public)
                   .Where(f => f.GetCustomAttribute(typeof(IgnoreMemberAttribute)) is null)
                   .ToList();
            }

            public int GetHashCode(ValueObject obj)
            {
                var hash = obj.GetType()
                   .GetProperties()
                   .Select(property => property.GetValue(this, null))
                   .Aggregate(17, HashValue);

                return obj.GetType()
                   .GetFields()
                   .Select(field => field.GetValue(this))
                   .Aggregate(hash, HashValue);
            }

            private static int HashValue(int seed, object? value)
            {
                var currentHash = value?.GetHashCode() ?? 0;

                return seed * 23 + currentHash;
            }
        }
    }
}