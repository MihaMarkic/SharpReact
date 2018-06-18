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
			UpdateAbsSpinnerWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateAbsSpinnerWithInstanceProperties(element, null, props);
		}
		static void UpdateAbsSpinnerWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Adapter.HasValue)
			{
				element.Adapter = nextProps.Adapter.Value.Value;
			}
		}
	}
}
