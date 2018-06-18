using System;
using System.Collections.Generic;

namespace SharpReact.Core.MockUI.Test.Props
{
    public abstract class TextBoxBase: Control
    {
        public ReactParam<bool>? IsReadOnly { get; set; }
        //public TextChangedEventHandler TextChanged { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            throw new InvalidOperationException();
        }
        public override IEnumerable<IReactParam> AllProperties
        {
            get
            {
                yield return IsReadOnly;
                foreach (var p in base.AllProperties)
                {
                    yield return p;
                }
            }
        }
    }
}
