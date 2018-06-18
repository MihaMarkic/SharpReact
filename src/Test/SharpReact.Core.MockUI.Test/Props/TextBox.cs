using System;
using System.Collections.Generic;

namespace SharpReact.Core.MockUI.Test.Props
{
    public class TextBox: TextBoxBase
    {
        public EventHandler TextChanged { get; set; }
        public ReactParam<string>? Text { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.TextBox<TextBox, Elements.TextBox>();
        }
        public override IEnumerable<IReactParam> AllProperties
        {
            get
            {
                yield return Text;
                foreach (var p in base.AllProperties)
                {
                    yield return p;
                }
            }
        }
    }
}
