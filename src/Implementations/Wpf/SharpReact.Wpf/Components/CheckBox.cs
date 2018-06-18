using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class CheckBox<TProps, TElement>: ToggleButton<TProps, TElement>
		where TProps : Props.CheckBox
		where TElement : global::System.Windows.Controls.CheckBox, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
