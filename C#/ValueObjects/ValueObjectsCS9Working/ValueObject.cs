namespace ValueObjectsCS9Working
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public abstract record ValueObject : IValueObject
    {
        private List<FieldInfo>? _fields;

        private List<PropertyInfo>? _properties;

        #region IValueObject Members

        public override int GetHashCode()
        {
            var hash = GetProperties()
               .Select(property => property.GetValue(this, null))
               .Aggregate(17, HashValue);

            return GetFields()
               .Select(field => field.GetValue(this))
               .Aggregate(hash, HashValue);
        }

        public int HashValue(int seed, object? value)
        {
            var currentHash = value?.GetHashCode() ?? 0;

            return seed * 23 + currentHash;
        }

        public virtual bool Equals(ValueObject? other) =>
            EqualityCheck(other);

        #endregion

        private bool EqualityCheck(object? obj)
        {
            if (obj           == null
             || obj.GetType() != GetType()) return false;

            return GetProperties().All(p => PropertiesAreEqual(obj, p))
                && GetFields().All(f => FieldsAreEqual(obj, f));
        }

        private bool PropertiesAreEqual(object obj, PropertyInfo p) =>
            Equals(p.GetValue(this, null), p.GetValue(obj, null));

        private bool FieldsAreEqual(object obj, FieldInfo f) => Equals(f.GetValue(this), f.GetValue(obj));

        private IEnumerable<PropertyInfo> GetProperties()
        {
            return _properties ??= GetType()
               .GetProperties(BindingFlags.Instance | BindingFlags.Public)
               .Where(p => p.GetCustomAttribute(typeof(IgnoreMemberAttribute)) is null)
               .ToList();
        }

        private IEnumerable<FieldInfo> GetFields()
        {
            return _fields ??= GetType()
               .GetFields(BindingFlags.Instance | BindingFlags.Public)
               .Where(f => f.GetCustomAttribute(typeof(IgnoreMemberAttribute)) is null)
               .ToList();
        }
    }
}