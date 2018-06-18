using System;
using System.Collections.Generic;

namespace SharpReact.Core.MockUI.Test.Props
{
    public class FrameworkElement: UIElement
    {
        public ReactParam<bool>? Focusable { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            throw new InvalidOperationException();
        }
        public override IEnumerable<IReactParam> AllProperties
        {
            get
            {
                yield return Focusable;
                foreach (var p in base.AllProperties)
                {
                    yield return p;
                }
            }
        }
    }
}
