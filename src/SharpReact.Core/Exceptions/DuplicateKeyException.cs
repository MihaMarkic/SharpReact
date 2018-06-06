using SharpReact.Core.Properties;
using System;

namespace SharpReact.Core.Exceptions
{
    public class DuplicateKeyException: Exception
    {
        public ISharpProp Property { get; }
        public string SourceProperty { get; }
        public string SourceType { get; }
        public DuplicateKeyException(ISharpProp property, string sourceProperty, string sourceType): 
            base($"Key {property.Key} is a duplicate in property list {sourceProperty} for {sourceType}")
        {
            Property = property;
            SourceProperty = sourceProperty;
            SourceType = sourceType;
        }
    }
}
