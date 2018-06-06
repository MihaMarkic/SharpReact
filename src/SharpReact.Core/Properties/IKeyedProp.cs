namespace SharpReact.Core.Properties
{
    public interface IKeyedItem
    {
        object Key { get; }
        ExtendedKey ExtendedKey { get; }
    }
}
