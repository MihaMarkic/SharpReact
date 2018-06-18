using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class RatingBar<TProps, TElement>: AbsSeekBar<TProps, TElement>
		where TProps : Props.RatingBar
		where TElement : global::Android.Widget.RatingBar
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.RatingBar(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateRatingBarWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateRatingBarWithInstanceProperties(element, null, props);
		}
		static void UpdateRatingBarWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.IsIndicator.HasValue)
			{
				element.IsIndicator = nextProps.IsIndicator.Value.Value;
			}
			if (nextProps.NumStars.HasValue)
			{
				element.NumStars = nextProps.NumStars.Value.Value;
			}
			if (nextProps.OnRatingBarChangeListener.HasValue)
			{
				element.OnRatingBarChangeListener = nextProps.OnRatingBarChangeListener.Value.Value;
			}
			if (nextProps.Rating.HasValue)
			{
				element.Rating = nextProps.Rating.Value.Value;
			}
			if (nextProps.StepSize.HasValue)
			{
				element.StepSize = nextProps.StepSize.Value.Value;
			}
			if (!(previous?.RatingBarChange is null) && nextProps.RatingBarChange is null)
			{
				element.RatingBarChange -= nextProps.RatingBarChange;
			}
			if (previous?.RatingBarChange is null && !(nextProps.RatingBarChange is null))
			{
				element.RatingBarChange += nextProps.RatingBarChange;
			}
		}
	}
}
