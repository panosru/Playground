namespace ValueObjectsCS8
{
    using System;

    // source: https://github.com/jhewlett/ValueObject
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    internal sealed class IgnoreMemberAttribute : Attribute
    { }
}