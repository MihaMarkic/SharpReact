using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ProgressBar<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.ProgressBar
		where TElement : global::Android.Widget.ProgressBar
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ProgressBar(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Indeterminate.HasValue)
			{
				Element.Indeterminate = nextProps.Indeterminate.Value.Value;
			}
			if (nextProps.IndeterminateDrawable.HasValue)
			{
				Element.IndeterminateDrawable = nextProps.IndeterminateDrawable.Value.Value;
			}
			if (nextProps.IndeterminateTintList.HasValue)
			{
				Element.IndeterminateTintList = nextProps.IndeterminateTintList.Value.Value;
			}
			if (nextProps.IndeterminateTintMode.HasValue)
			{
				Element.IndeterminateTintMode = nextProps.IndeterminateTintMode.Value.Value;
			}
			if (nextProps.Interpolator.HasValue)
			{
				Element.Interpolator = nextProps.Interpolator.Value.Value;
			}
			if (nextProps.Max.HasValue)
			{
				Element.Max = nextProps.Max.Value.Value;
			}
			if (nextProps.Min.HasValue)
			{
				Element.Min = nextProps.Min.Value.Value;
			}
			if (nextProps.Progress.HasValue)
			{
				Element.Progress = nextProps.Progress.Value.Value;
			}
			if (nextProps.ProgressBackgroundTintList.HasValue)
			{
				Element.ProgressBackgroundTintList = nextProps.ProgressBackgroundTintList.Value.Value;
			}
			if (nextProps.ProgressBackgroundTintMode.HasValue)
			{
				Element.ProgressBackgroundTintMode = nextProps.ProgressBackgroundTintMode.Value.Value;
			}
			if (nextProps.ProgressDrawable.HasValue)
			{
				Element.ProgressDrawable = nextProps.ProgressDrawable.Value.Value;
			}
			if (nextProps.ProgressTintList.HasValue)
			{
				Element.ProgressTintList = nextProps.ProgressTintList.Value.Value;
			}
			if (nextProps.ProgressTintMode.HasValue)
			{
				Element.ProgressTintMode = nextProps.ProgressTintMode.Value.Value;
			}
			if (nextProps.SecondaryProgress.HasValue)
			{
				Element.SecondaryProgress = nextProps.SecondaryProgress.Value.Value;
			}
			if (nextProps.SecondaryProgressTintList.HasValue)
			{
				Element.SecondaryProgressTintList = nextProps.SecondaryProgressTintList.Value.Value;
			}
			if (nextProps.SecondaryProgressTintMode.HasValue)
			{
				Element.SecondaryProgressTintMode = nextProps.SecondaryProgressTintMode.Value.Value;
			}
		}
	}
}
