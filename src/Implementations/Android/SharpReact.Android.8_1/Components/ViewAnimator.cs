using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ViewAnimator<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.ViewAnimator
		where TElement : global::Android.Widget.ViewAnimator
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ViewAnimator(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateViewAnimatorWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateViewAnimatorWithInstanceProperties(element, null, props);
		}
		static void UpdateViewAnimatorWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.DisplayedChild.HasValue)
			{
				element.DisplayedChild = nextProps.DisplayedChild.Value.Value;
			}
			if (nextProps.InAnimation.HasValue)
			{
				element.InAnimation = nextProps.InAnimation.Value.Value;
			}
			if (nextProps.OutAnimation.HasValue)
			{
				element.OutAnimation = nextProps.OutAnimation.Value.Value;
			}
		}
	}
}
