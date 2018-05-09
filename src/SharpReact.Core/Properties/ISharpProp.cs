namespace SharpReact.Core.Properties
{
    public interface ISharpProp
    {
        void Init();
        void Transfer(ISharpStatefulComponent previous);
        ISharpStatefulComponent Component { get; }
        object Key { get; set; }
    }
}
