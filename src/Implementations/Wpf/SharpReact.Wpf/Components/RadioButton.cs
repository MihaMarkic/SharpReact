using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class RadioButton<TProps, TElement>: ToggleButton<TProps, TElement>
		where TProps : Props.RadioButton
		where TElement : global::System.Windows.Controls.RadioButton, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.GroupName.HasValue)
			{
				Element.GroupName = nextProps.GroupName.Value.Value;
			}
		}
	}
}
