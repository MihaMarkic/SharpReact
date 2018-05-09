
namespace SharpReact.Wpf.Components
{
    public abstract class TextBoxBase<TProps, TElement> : Control<TProps, TElement>
        where TProps : Props.TextBoxBase
        where TElement : System.Windows.Controls.Primitives.TextBoxBase, new()
    {
        public override void AssignProperties(TProps nextProps)
        {
            base.AssignProperties(nextProps);
            if (nextProps.IsReadOnly.HasValue)
            {
                Element.IsReadOnly = nextProps.IsReadOnly.Value;
            }
        }
    }
}
