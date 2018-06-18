
using System.Collections.Generic;

namespace SharpReact.Core.MockUI.Test.Props
{
    public class StackPanel: Panel
    {
        public ReactParam<Orientation>? Orientation { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.StackPanel<StackPanel, Elements.StackPanel>();
        }
        public override IEnumerable<IReactParam> AllProperties
        {
            get
            {
                yield return Orientation;
                foreach (var p in base.AllProperties)
                {
                    yield return p;
                }
            }
        }
    }
}
