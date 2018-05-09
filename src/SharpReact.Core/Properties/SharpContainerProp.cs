namespace SharpReact.Core.Properties
{
    public abstract class SharpContainerProp<TContent, TComponent> : SharpCompositeProp<TComponent>, IContainer
        where TContent: ISharpProp
        where TComponent : ISharpComponent, new()
    {
        public TContent Content { get; set; }
        ISharpProp IContainer.Content => Content;
    }
}
