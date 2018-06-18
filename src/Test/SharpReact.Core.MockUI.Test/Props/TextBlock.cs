
using System.Collections.Generic;

namespace SharpReact.Core.MockUI.Test.Props
{
    public class TextBlock: FrameworkElement
    {
        public ReactParam<string>? Text { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.TextBlock<TextBlock, Core.MockUI.Test.Elements.TextBlock>();
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
