using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class Chronometer<TProps, TElement>: TextView<TProps, TElement>
		where TProps : Props.Chronometer
		where TElement : global::Android.Widget.Chronometer
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Base.HasValue)
			{
				Element.Base = nextProps.Base.Value.Value;
			}
			if (nextProps.CountDown.HasValue)
			{
				Element.CountDown = nextProps.CountDown.Value.Value;
			}
			if (nextProps.Format.HasValue)
			{
				Element.Format = nextProps.Format.Value.Value;
			}
			if (nextProps.OnChronometerTickListener.HasValue)
			{
				Element.OnChronometerTickListener = nextProps.OnChronometerTickListener.Value.Value;
			}
			if (!ReferenceEquals(previous?.ChronometerTick, null) && ReferenceEquals(nextProps.ChronometerTick, null))
			{
				Element.ChronometerTick -= nextProps.ChronometerTick;
			}
			if (ReferenceEquals(previous?.ChronometerTick, null) && !ReferenceEquals(nextProps.ChronometerTick, null))
			{
				Element.ChronometerTick += nextProps.ChronometerTick;
			}
		}
	}
}
