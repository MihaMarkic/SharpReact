using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Routing.Props
{
    public abstract class Route<TComponent> : SharpCompositeProp<TComponent>, IRoute
                where TComponent : ISharpComponent, new()
    {
        public ISharpProp Content { get; set; }
        public abstract bool IsMatch();
        protected override void UnmountComponent()
        {
            UnmountComponent(Content);
            base.UnmountComponent();
        }
    }
}
