using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class AdapterView<T, TProps, TElement>: AdapterView<TProps, TElement>
		where TProps : Props.AdapterView<T>
		where TElement : global::Android.Widget.AdapterView<T>
		where T: global::Android.Widget.IAdapter 
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Adapter.HasValue)
			{
				Element.Adapter = nextProps.Adapter.Value.Value;
			}
		}
	}
}
