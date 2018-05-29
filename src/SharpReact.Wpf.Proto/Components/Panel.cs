
namespace SharpReact.Wpf.Components
{
    public abstract class Panel<TProps, TElement> : FrameworkElement<TProps, TElement>
        where TProps : Props.Panel
        where TElement : System.Windows.Controls.Panel, new()
    {
        public override void AssignProperties(TProps nextProps)
        {
            base.AssignProperties(nextProps);
            //if (!ReferenceEquals(source.Children, null))
            //{
            //    UIElementCollection.Populate(renderer, source.Children, item.Children);
            //}
        }
    }
}
