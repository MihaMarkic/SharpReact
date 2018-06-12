using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class RadioGroup<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.RadioGroup
		where TElement : global::Android.Widget.RadioGroup
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (!ReferenceEquals(previous?.CheckedChange, null) && ReferenceEquals(nextProps.CheckedChange, null))
			{
				Element.CheckedChange -= nextProps.CheckedChange;
			}
			if (ReferenceEquals(previous?.CheckedChange, null) && !ReferenceEquals(nextProps.CheckedChange, null))
			{
				Element.CheckedChange += nextProps.CheckedChange;
			}
		}
	}
}
