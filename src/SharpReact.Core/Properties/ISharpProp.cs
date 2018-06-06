namespace SharpReact.Core.Properties
{
    public interface ISharpProp: IKeyedItem
    {
        void Init();
        void Transfer(ISharpStatefulComponent previous);
        ISharpStatefulComponent Component { get; }
    }
}
