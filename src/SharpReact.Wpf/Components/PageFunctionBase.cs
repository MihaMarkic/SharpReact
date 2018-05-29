
namespace SharpReact.Wpf.Components
{
	public abstract class PageFunctionBase<TProps, TElement>: Page<TProps, TElement>
		where TProps : Props.PageFunctionBase
		where TElement : System.Windows.Navigation.PageFunctionBase
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.RemoveFromJournal.HasValue)
			{
				Element.RemoveFromJournal = nextProps.RemoveFromJournal.Value.Value;
			}
		}
	}
}
