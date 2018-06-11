using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class ButtonBase<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.ButtonBase
		where TElement : System.Windows.Controls.Primitives.ButtonBase, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Command.HasValue)
			{
				Element.Command = nextProps.Command.Value.Value;
			}
			if (nextProps.CommandParameter.HasValue)
			{
				Element.CommandParameter = nextProps.CommandParameter.Value.Value;
			}
			if (nextProps.CommandTarget.HasValue)
			{
				Element.CommandTarget = nextProps.CommandTarget.Value.Value;
			}
			if (nextProps.ClickMode.HasValue)
			{
				Element.ClickMode = nextProps.ClickMode.Value.Value;
			}
			if (!ReferenceEquals(previous?.Click, null) && ReferenceEquals(nextProps.Click, null))
			{
				Element.Click -= nextProps.Click;
			}
			if (ReferenceEquals(previous?.Click, null) && !ReferenceEquals(nextProps.Click, null))
			{
				Element.Click += nextProps.Click;
			}
		}
	}
}
