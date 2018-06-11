using NStack;
using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using Terminal.Gui;

namespace SharpReact.Terminal.Gui.Props
{
    public abstract class View: SharpNativeProp
    {
        public List<ISharpProp> SubViews { get; set; } = new List<ISharpProp>();
        public ReactParam<ustring>? Id { get; set; }
        public ReactParam<bool>? WantMousePositionReports { get; set; }
        public ReactParam<Rect>? Frame { get; set; }
        public  ReactParam<LayoutStyle>? LayoutStyle { get; set; }
        public ReactParam<Rect>? Bounds { get; set; }
        public ReactParam<Pos>? X { get; set; }
        public ReactParam<Pos>? Y { get; set; }
        public ReactParam<Dim>? Width { get; set; }
        public ReactParam<Dim>? Height { get; set; }
        public ReactParam<bool>? CanFocus { get; set; }
    }
}
