using SharpReact.Core;
using Terminal.Gui;

namespace SharpReact.Terminal.Gui.Components
{
    public abstract class View<TProps, TElement> : SharpTerminalGuiComponent<TProps, TElement>
        where TProps : Props.View
        where TElement : View
    {
        public override void AssignProperties(ISharpCreator<View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            if (nextProps.Id.HasValue)
            {
                Element.Id = nextProps.Id.Value;
            }
            if (nextProps.WantMousePositionReports.HasValue)
            {
                Element.WantMousePositionReports = nextProps.WantMousePositionReports.Value;
            }
            if (nextProps.Frame.HasValue)
            {
                Element.Frame = nextProps.Frame.Value;
            }
            if (nextProps.LayoutStyle.HasValue)
            {
                Element.LayoutStyle = nextProps.LayoutStyle.Value;
            }
            if (nextProps.Bounds.HasValue)
            {
                Element.Bounds = nextProps.Bounds.Value;
            }
            if (nextProps.X.HasValue)
            {
                Element.X = nextProps.X.Value;
            }
            if (nextProps.Y.HasValue)
            {
                Element.Y = nextProps.Y.Value;
            }
            if (nextProps.Width.HasValue)
            {
                Element.Width = nextProps.Width.Value;
            }
            if (nextProps.Height.HasValue)
            {
                Element.Height = nextProps.Height.Value;
            }
            if (nextProps.CanFocus.HasValue)
            {
                Element.CanFocus = nextProps.CanFocus.Value;
            }
            var elements = renderer.VisitAllCollection(level, newState, previous?.SubViews, nextProps.SubViews, nameof(nextProps.SubViews), nameof(View));
            ElementSynchronizer.SyncElements(Element, elements);
        }
    }
}
