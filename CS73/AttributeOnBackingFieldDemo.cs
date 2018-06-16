using System;

namespace CS73
{
    public class AttributeOnBackingFieldDemo2
    {
        [field: FieldOnly]
        public string SomeProperty { get; set; }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class FieldOnlyAttribute : Attribute
    {
    }
}
