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
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateProgressBarWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateProgressBarWithInstanceProperties(element, null, props);
		}
		static void UpdateProgressBarWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Indeterminate.HasValue)
			{
				element.Indeterminate = nextProps.Indeterminate.Value.Value;
			}
			if (nextProps.IndeterminateDrawable.HasValue)
			{
				element.IndeterminateDrawable = nextProps.IndeterminateDrawable.Value.Value;
			}
			if (nextProps.IndeterminateTintList.HasValue)
			{
				element.IndeterminateTintList = nextProps.IndeterminateTintList.Value.Value;
			}
			if (nextProps.IndeterminateTintMode.HasValue)
			{
				element.IndeterminateTintMode = nextProps.IndeterminateTintMode.Value.Value;
			}
			if (nextProps.Interpolator.HasValue)
			{
				element.Interpolator = nextProps.Interpolator.Value.Value;
			}
			if (nextProps.Max.HasValue)
			{
				element.Max = nextProps.Max.Value.Value;
			}
			if (nextProps.Min.HasValue)
			{
				element.Min = nextProps.Min.Value.Value;
			}
			if (nextProps.Progress.HasValue)
			{
				element.Progress = nextProps.Progress.Value.Value;
			}
			if (nextProps.ProgressBackgroundTintList.HasValue)
			{
				element.ProgressBackgroundTintList = nextProps.ProgressBackgroundTintList.Value.Value;
			}
			if (nextProps.ProgressBackgroundTintMode.HasValue)
			{
				element.ProgressBackgroundTintMode = nextProps.ProgressBackgroundTintMode.Value.Value;
			}
			if (nextProps.ProgressDrawable.HasValue)
			{
				element.ProgressDrawable = nextProps.ProgressDrawable.Value.Value;
			}
			if (nextProps.ProgressTintList.HasValue)
			{
				element.ProgressTintList = nextProps.ProgressTintList.Value.Value;
			}
			if (nextProps.ProgressTintMode.HasValue)
			{
				element.ProgressTintMode = nextProps.ProgressTintMode.Value.Value;
			}
			if (nextProps.SecondaryProgress.HasValue)
			{
				element.SecondaryProgress = nextProps.SecondaryProgress.Value.Value;
			}
			if (nextProps.SecondaryProgressTintList.HasValue)
			{
				element.SecondaryProgressTintList = nextProps.SecondaryProgressTintList.Value.Value;
			}
			if (nextProps.SecondaryProgressTintMode.HasValue)
			{
				element.SecondaryProgressTintMode = nextProps.SecondaryProgressTintMode.Value.Value;
			}
		}
	}
}
