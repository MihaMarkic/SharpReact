
namespace SharpReact.Wpf.Components
{
	public  class MediaElement<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.MediaElement
		where TElement : System.Windows.Controls.MediaElement
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.MediaElement();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Source.HasValue)
			{
				Element.Source = nextProps.Source.Value.Value;
			}
			if (nextProps.Clock.HasValue)
			{
				Element.Clock = nextProps.Clock.Value.Value;
			}
			if (nextProps.Stretch.HasValue)
			{
				Element.Stretch = nextProps.Stretch.Value.Value;
			}
			if (nextProps.StretchDirection.HasValue)
			{
				Element.StretchDirection = nextProps.StretchDirection.Value.Value;
			}
			if (nextProps.Volume.HasValue)
			{
				Element.Volume = nextProps.Volume.Value.Value;
			}
			if (nextProps.Balance.HasValue)
			{
				Element.Balance = nextProps.Balance.Value.Value;
			}
			if (nextProps.IsMuted.HasValue)
			{
				Element.IsMuted = nextProps.IsMuted.Value.Value;
			}
			if (nextProps.ScrubbingEnabled.HasValue)
			{
				Element.ScrubbingEnabled = nextProps.ScrubbingEnabled.Value.Value;
			}
			if (nextProps.UnloadedBehavior.HasValue)
			{
				Element.UnloadedBehavior = nextProps.UnloadedBehavior.Value.Value;
			}
			if (nextProps.LoadedBehavior.HasValue)
			{
				Element.LoadedBehavior = nextProps.LoadedBehavior.Value.Value;
			}
			if (nextProps.Position.HasValue)
			{
				Element.Position = nextProps.Position.Value.Value;
			}
			if (nextProps.SpeedRatio.HasValue)
			{
				Element.SpeedRatio = nextProps.SpeedRatio.Value.Value;
			}
			if (!ReferenceEquals(Props?.MediaFailed, null) && ReferenceEquals(nextProps.MediaFailed, null))
			{
				Element.MediaFailed -= nextProps.MediaFailed;
			}
			if (ReferenceEquals(Props?.MediaFailed, null) && !ReferenceEquals(nextProps.MediaFailed, null))
			{
				Element.MediaFailed += nextProps.MediaFailed;
			}
			if (!ReferenceEquals(Props?.MediaOpened, null) && ReferenceEquals(nextProps.MediaOpened, null))
			{
				Element.MediaOpened -= nextProps.MediaOpened;
			}
			if (ReferenceEquals(Props?.MediaOpened, null) && !ReferenceEquals(nextProps.MediaOpened, null))
			{
				Element.MediaOpened += nextProps.MediaOpened;
			}
			if (!ReferenceEquals(Props?.BufferingStarted, null) && ReferenceEquals(nextProps.BufferingStarted, null))
			{
				Element.BufferingStarted -= nextProps.BufferingStarted;
			}
			if (ReferenceEquals(Props?.BufferingStarted, null) && !ReferenceEquals(nextProps.BufferingStarted, null))
			{
				Element.BufferingStarted += nextProps.BufferingStarted;
			}
			if (!ReferenceEquals(Props?.BufferingEnded, null) && ReferenceEquals(nextProps.BufferingEnded, null))
			{
				Element.BufferingEnded -= nextProps.BufferingEnded;
			}
			if (ReferenceEquals(Props?.BufferingEnded, null) && !ReferenceEquals(nextProps.BufferingEnded, null))
			{
				Element.BufferingEnded += nextProps.BufferingEnded;
			}
			if (!ReferenceEquals(Props?.ScriptCommand, null) && ReferenceEquals(nextProps.ScriptCommand, null))
			{
				Element.ScriptCommand -= nextProps.ScriptCommand;
			}
			if (ReferenceEquals(Props?.ScriptCommand, null) && !ReferenceEquals(nextProps.ScriptCommand, null))
			{
				Element.ScriptCommand += nextProps.ScriptCommand;
			}
			if (!ReferenceEquals(Props?.MediaEnded, null) && ReferenceEquals(nextProps.MediaEnded, null))
			{
				Element.MediaEnded -= nextProps.MediaEnded;
			}
			if (ReferenceEquals(Props?.MediaEnded, null) && !ReferenceEquals(nextProps.MediaEnded, null))
			{
				Element.MediaEnded += nextProps.MediaEnded;
			}
		}
	}
}