using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Button<TProps, TElement>: ButtonBase<TProps, TElement>
		where TProps : Props.Button
		where TElement : global::System.Windows.Controls.Button, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.IsDefault.HasValue)
			{
				Element.IsDefault = nextProps.IsDefault.Value.Value;
			}
			if (nextProps.IsCancel.HasValue)
			{
				Element.IsCancel = nextProps.IsCancel.Value.Value;
			}
		}
	}
}
