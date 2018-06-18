using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class Chronometer<TProps, TElement>: TextView<TProps, TElement>
		where TProps : Props.Chronometer
		where TElement : global::Android.Widget.Chronometer
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.Chronometer(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateChronometerWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateChronometerWithInstanceProperties(element, null, props);
		}
		static void UpdateChronometerWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Base.HasValue)
			{
				element.Base = nextProps.Base.Value.Value;
			}
			if (nextProps.CountDown.HasValue)
			{
				element.CountDown = nextProps.CountDown.Value.Value;
			}
			if (nextProps.Format.HasValue)
			{
				element.Format = nextProps.Format.Value.Value;
			}
			if (nextProps.OnChronometerTickListener.HasValue)
			{
				element.OnChronometerTickListener = nextProps.OnChronometerTickListener.Value.Value;
			}
			if (!(previous?.ChronometerTick is null) && nextProps.ChronometerTick is null)
			{
				element.ChronometerTick -= nextProps.ChronometerTick;
			}
			if (previous?.ChronometerTick is null && !(nextProps.ChronometerTick is null))
			{
				element.ChronometerTick += nextProps.ChronometerTick;
			}
		}
	}
}
