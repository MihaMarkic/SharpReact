using Terminal.Gui;

namespace SharpReact.Terminal.Gui
{
    public static class ConversionExtensions
    {
        public static Pos AsPos(this int i)
        {
            return (Pos)i;
        }
        public static Dim AsDim(this int i)
        {
            return (Dim)i;
        }
    }
}
