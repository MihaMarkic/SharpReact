using SharpReact.Core.Properties;

namespace SharpReact.Core
{
    public interface ISharpStatefulComponent<TElement>: ISharpStatefulComponent
    {
        void UpdateElement(ISharpRenderer<TElement> renderer, TElement element, ISharpProp prop);
    }
}
