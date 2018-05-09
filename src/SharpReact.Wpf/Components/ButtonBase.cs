
namespace SharpReact.Wpf.Components
{
    public abstract class ButtonBase<TProps, TElement> : ContentControl<TProps, TElement>
        where TProps : Props.ButtonBase
        where TElement : System.Windows.Controls.Primitives.ButtonBase, new()
    {
        public override void AssignProperties(TProps nextProps)
        {
            base.AssignProperties(nextProps);
            if (!ReferenceEquals(Props?.Click, null) && ReferenceEquals(nextProps.Click, null))
            {
                Element.Click -= nextProps.Click;
            }
            if (ReferenceEquals(Props?.Click, null) && !ReferenceEquals(nextProps.Click, null))
            {
                Element.Click += nextProps.Click;
            }
        }
    }
}
