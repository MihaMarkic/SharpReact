using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class DocumentViewerBase<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.DocumentViewerBase
		where TElement : global::System.Windows.Controls.Primitives.DocumentViewerBase, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Document.HasValue)
			{
				Element.Document = nextProps.Document.Value.Value;
			}
			if (!ReferenceEquals(previous?.PageViewsChanged, null) && ReferenceEquals(nextProps.PageViewsChanged, null))
			{
				Element.PageViewsChanged -= nextProps.PageViewsChanged;
			}
			if (ReferenceEquals(previous?.PageViewsChanged, null) && !ReferenceEquals(nextProps.PageViewsChanged, null))
			{
				Element.PageViewsChanged += nextProps.PageViewsChanged;
			}
		}
	}
}
