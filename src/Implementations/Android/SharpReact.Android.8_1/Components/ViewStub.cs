using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ViewStub<TProps>: View<TProps, global::Android.Views.ViewStub>
		where TProps : Props.ViewStub
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = new global::Android.Views.ViewStub(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateViewStubWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, global::Android.Views.ViewStub element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateViewStubWithInstanceProperties(element, null, props);
		}
		static void UpdateViewStubWithInstanceProperties(global::Android.Views.ViewStub element, TProps previous, TProps nextProps)
		{
			if (nextProps.InflatedId.HasValue)
			{
				element.InflatedId = nextProps.InflatedId.Value.Value;
			}
			if (nextProps.LayoutInflater.HasValue)
			{
				element.LayoutInflater = nextProps.LayoutInflater.Value.Value;
			}
			if (nextProps.LayoutResource.HasValue)
			{
				element.LayoutResource = nextProps.LayoutResource.Value.Value;
			}
			if (!(previous?.InflateEvent is null) && nextProps.InflateEvent is null)
			{
				element.InflateEvent -= nextProps.InflateEvent;
			}
			if (previous?.InflateEvent is null && !(nextProps.InflateEvent is null))
			{
				element.InflateEvent += nextProps.InflateEvent;
			}
		}
	}
}
