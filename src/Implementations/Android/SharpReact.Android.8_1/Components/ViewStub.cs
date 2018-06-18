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
			if (nextProps.InflatedId.HasValue)
			{
				Element.InflatedId = nextProps.InflatedId.Value.Value;
			}
			if (nextProps.LayoutInflater.HasValue)
			{
				Element.LayoutInflater = nextProps.LayoutInflater.Value.Value;
			}
			if (nextProps.LayoutResource.HasValue)
			{
				Element.LayoutResource = nextProps.LayoutResource.Value.Value;
			}
			if (!ReferenceEquals(previous?.InflateEvent, null) && ReferenceEquals(nextProps.InflateEvent, null))
			{
				Element.InflateEvent -= nextProps.InflateEvent;
			}
			if (ReferenceEquals(previous?.InflateEvent, null) && !ReferenceEquals(nextProps.InflateEvent, null))
			{
				Element.InflateEvent += nextProps.InflateEvent;
			}
		}
	}
}
