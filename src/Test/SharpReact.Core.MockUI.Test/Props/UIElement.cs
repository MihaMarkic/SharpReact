using SharpReact.Core.Properties;
using System;
using System.Collections.Generic;

namespace SharpReact.Core.MockUI.Test.Props
{
    public class UIElement: SharpNativeProp
    {
        public ReactParam<bool>? IsEnabled { get; set; }
        //public Visibility? Visibility { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            throw new InvalidOperationException();
        }
        public override IEnumerable<IReactParam> AllProperties
        {
            get
            {
                yield return IsEnabled;
                foreach (var p in base.AllProperties)
                {
                    yield return p;
                }
            }
        }
    }
}
