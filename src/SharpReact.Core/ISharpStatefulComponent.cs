using SharpReact.Core.Properties;

namespace SharpReact.Core
{
    public interface ISharpStatefulComponent
    {
        ISharpRenderer Renderer { get; set; }
        object Element { get; }
        object State { get; }
        object Props { get;  }
        void WillMount();
        void DidMount();
        void WillReceiveProps(object nextProps);
        bool ShouldUpdate(object nextProps, object nextState);
        void WillUpdate();
        void DidUpdate(object nextProps, object nextState);
        void WillUnmount();
        /// <summary>
        /// Returns a tree when composite, otherwise returns null.
        /// </summary>
        /// <returns></returns>
        ISharpProp Render();
        void UpdateElement(ISharpRenderer renderer, object element, ISharpProp props);
    }
}
