using NStack;
using SharpReact.Core;
using SharpReact.Core.Properties;
using SharpReact.Terminal.Gui;
using SharpReact.Terminal.Gui.Props;
using System.Threading.Tasks;
using Term = Terminal.Gui;

namespace SharpReact.TerminalGui.Sample
{
    class Program
    {
        static Term.Toplevel top = Term.Application.Top;
        static ustring currentText = "";
        static int clickedCount = 0;
        static TerminalGuiTreeRenderer<Term.Toplevel> renderer;
        static void Main()
        {
            Term.Application.Init();
            var top = Term.Application.Top;
            renderer = new TerminalGuiTreeRenderer<Term.Toplevel>(CreateTree, top,
                (r, c) => r.Add(c),
                (r, c) => r.Remove(c),
                TaskScheduler.Current);
            renderer.Render(NewState.Empty);
            Term.Application.Run();
        }
        static SharpProp CreateTree()
        {
            return new Window
            {
                Bounds = new Term.Rect(0, 1, top.Frame.Width, top.Frame.Height - 1),
                Title = (ustring)"Hello from SharpReact",
                SubViews =
                {
                    new Label
                    {
                        Text = (ustring)$"Typed text: {currentText}",
                        X = (Term.Pos)3,
                        Y = (Term.Pos)6,
                        Width = (Term.Dim)50,
                        Height = (Term.Dim)1,
                    },
                    new TextField
                    {
                        X = (Term.Pos)3,
                        Y = (Term.Pos)8,
                        Width = (Term.Dim)50,
                        Height = (Term.Dim)1,
                        Changed = (s, e) =>
                        {
                            currentText = ((Term.TextField)s).Text;
                            renderer.Redraw();
                        }
                    },
                    new Button
                    {
                        Text = (ustring)$"Clicked count: {clickedCount}",
                        X = (Term.Pos)3,
                        Y = (Term.Pos)10,
                        Width = (Term.Dim)20,
                        Height = (Term.Dim)1,
                        Clicked = () =>
                        {
                            clickedCount++;
                            renderer.Redraw();
                        }
                    }
                }
            };
        }
    }
}
