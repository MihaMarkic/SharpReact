using System;

namespace SharpReact.Core.MockUI.Test.Elements
{
    public class ButtonBase : ContentControl {
        public event EventHandler Click;
        public void OnClick(EventArgs e) => Click?.Invoke(this, e);
    }
}
