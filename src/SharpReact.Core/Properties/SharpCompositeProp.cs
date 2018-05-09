using System;

namespace SharpReact.Core.Properties
{
    public abstract class SharpCompositeProp<TComponent> : SharpProp, ISharpCompositeProp
            where TComponent : ISharpComponent, new()
    {
        public ISharpProp Generated { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new TComponent();
        }
    }
}
