using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class DocumentReference<TProps>: FrameworkElement<TProps, global::System.Windows.Documents.DocumentReference>
		where TProps : Props.DocumentReference
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Source.HasValue)
			{
				Element.Source = nextProps.Source.Value.Value;
			}
		}
	}
}
