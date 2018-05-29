
namespace SharpReact.Wpf.Components
{
	public  class WebBrowser<TProps>: ActiveXHost<TProps, System.Windows.Controls.WebBrowser>
		where TProps : Props.WebBrowser
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Controls.WebBrowser();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Source.HasValue)
			{
				Element.Source = nextProps.Source.Value.Value;
			}
			if (nextProps.ObjectForScripting.HasValue)
			{
				Element.ObjectForScripting = nextProps.ObjectForScripting.Value.Value;
			}
			if (!ReferenceEquals(Props?.Navigating, null) && ReferenceEquals(nextProps.Navigating, null))
			{
				Element.Navigating -= nextProps.Navigating;
			}
			if (ReferenceEquals(Props?.Navigating, null) && !ReferenceEquals(nextProps.Navigating, null))
			{
				Element.Navigating += nextProps.Navigating;
			}
			if (!ReferenceEquals(Props?.Navigated, null) && ReferenceEquals(nextProps.Navigated, null))
			{
				Element.Navigated -= nextProps.Navigated;
			}
			if (ReferenceEquals(Props?.Navigated, null) && !ReferenceEquals(nextProps.Navigated, null))
			{
				Element.Navigated += nextProps.Navigated;
			}
			if (!ReferenceEquals(Props?.LoadCompleted, null) && ReferenceEquals(nextProps.LoadCompleted, null))
			{
				Element.LoadCompleted -= nextProps.LoadCompleted;
			}
			if (ReferenceEquals(Props?.LoadCompleted, null) && !ReferenceEquals(nextProps.LoadCompleted, null))
			{
				Element.LoadCompleted += nextProps.LoadCompleted;
			}
		}
	}
}
