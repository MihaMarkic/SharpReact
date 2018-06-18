using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class AbsSpinner<TProps, TElement>: AdapterView<global::Android.Widget.ISpinnerAdapter, TProps, TElement>
		where TProps : Props.AbsSpinner
		where TElement : global::Android.Widget.AbsSpinner
	{
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Adapter.HasValue)
			{
				Element.Adapter = nextProps.Adapter.Value.Value;
			}
		}
	}
}
