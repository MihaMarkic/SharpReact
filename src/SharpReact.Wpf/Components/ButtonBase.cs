
namespace SharpReact.Wpf.Components
{
	public abstract class ButtonBase<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.ButtonBase
		where TElement : System.Windows.Controls.Primitives.ButtonBase
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
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
			if (!ReferenceEquals(Props?.Click, null) && ReferenceEquals(nextProps.Click, null))
			{
				Element.Click -= nextProps.Click;
			}
			if (ReferenceEquals(Props?.Click, null) && !ReferenceEquals(nextProps.Click, null))
			{
				Element.Click += nextProps.Click;
			}
		}
	}
}
