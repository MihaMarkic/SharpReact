using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class DataGridRowHeader<TProps, TElement>: ButtonBase<TProps, TElement>
		where TProps : Props.DataGridRowHeader
		where TElement : global::System.Windows.Controls.Primitives.DataGridRowHeader, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
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
