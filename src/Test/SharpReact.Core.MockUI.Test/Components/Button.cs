﻿using SharpReact.Core.MockUI.Test.Props;

namespace SharpReact.Core.MockUI.Test.Components
{
    public class Button<TProps, TElement> : ButtonBase<TProps, TElement>
        where TProps : Button
        where TElement : Core.MockUI.Test.Elements.Button, new()
    {
    }
}
