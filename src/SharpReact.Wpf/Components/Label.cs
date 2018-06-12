using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Label<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.Label
		where TElement : global::System.Windows.Controls.Label, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Target.HasValue)
			{
				Element.Target = nextProps.Target.Value.Value;
			}
		}
	}
}
