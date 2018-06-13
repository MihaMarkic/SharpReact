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
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.IsIndicator.HasValue)
			{
				Element.IsIndicator = nextProps.IsIndicator.Value.Value;
			}
			if (nextProps.NumStars.HasValue)
			{
				Element.NumStars = nextProps.NumStars.Value.Value;
			}
			if (nextProps.OnRatingBarChangeListener.HasValue)
			{
				Element.OnRatingBarChangeListener = nextProps.OnRatingBarChangeListener.Value.Value;
			}
			if (nextProps.Rating.HasValue)
			{
				Element.Rating = nextProps.Rating.Value.Value;
			}
			if (nextProps.StepSize.HasValue)
			{
				Element.StepSize = nextProps.StepSize.Value.Value;
			}
			if (!ReferenceEquals(previous?.RatingBarChange, null) && ReferenceEquals(nextProps.RatingBarChange, null))
			{
				Element.RatingBarChange -= nextProps.RatingBarChange;
			}
			if (ReferenceEquals(previous?.RatingBarChange, null) && !ReferenceEquals(nextProps.RatingBarChange, null))
			{
				Element.RatingBarChange += nextProps.RatingBarChange;
			}
		}
	}
}
