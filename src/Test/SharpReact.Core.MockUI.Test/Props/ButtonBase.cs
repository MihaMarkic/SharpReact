using System;

namespace SharpReact.Core.MockUI.Test.Props
{
    public abstract class ButtonBase: ContentControl
    {
        public EventHandler Click { get; set; }
    }
}
