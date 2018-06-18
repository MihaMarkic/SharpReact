using SharpReact.Core.Properties;

namespace SharpReact.Core
{
    public interface ISharpRenderer
    {
        (ISharpStatefulComponent Stateful, ISharpNativeComponent Native) CreateNewComponent(ISharpProp next);
        void StateChanged(NewState newState);
        void Redraw();
        bool CompareProperties<T>(T left, T right)
            where T : ISharpProp;
        void UpdateExistingElement(object element, ISharpProp prop);
    }
}
