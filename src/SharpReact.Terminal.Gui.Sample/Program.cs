using NStack;
using SharpReact.Core;
using SharpReact.Core.Properties;
using SharpReact.Terminal.Gui.NetCore;
using SharpReact.Terminal.Gui.NetCore.Props;
using System.Threading.Tasks;

namespace SharpReact.Terminal.Gui.Sample
{
    class Program
    {
        static global::Terminal.Gui.Toplevel top = global::Terminal.Gui.Application.Top;
        static void Main()
        {
            global::Terminal.Gui.Application.Init();
            var top = global::Terminal.Gui.Application.Top;
            var render = new TerminalGuiTreeRenderer<global::Terminal.Gui.Toplevel>(CreateTree, top,
                (r, c) => r.Add(c),
                (r, c) => r.Remove(c),
                TaskScheduler.Current);
            render.Render(NewState.Empty);
            global::Terminal.Gui.Application.Run();
        }
        static SharpProp CreateTree()
        {
            return new Window
            {
                Bounds = new global::Terminal.Gui.Rect  (0, 1, top.Frame.Width, top.Frame.Height - 1),
                Title = (ustring)"Hello from SharpReact",
                SubViews =
                {
                    new Label
                    {
                        Text = (ustring)"Typed text:",
                        X = (global::Terminal.Gui.Pos)3,
                        Y = (global::Terminal.Gui.Pos)6
                    }
                }
            };
        }
    }
}
