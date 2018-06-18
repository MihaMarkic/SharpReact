using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class DataGridColumnHeader<TProps, TElement>: ButtonBase<TProps, TElement>
		where TProps : Props.DataGridColumnHeader
		where TElement : global::System.Windows.Controls.Primitives.DataGridColumnHeader, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.SeparatorBrush.HasValue)
			{
				Element.SeparatorBrush = nextProps.SeparatorBrush.Value.Value;
			}
			if (nextProps.SeparatorVisibility.HasValue)
			{
				Element.SeparatorVisibility = nextProps.SeparatorVisibility.Value.Value;
			}
		}
	}
}
