using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class CompoundButton<TProps, TElement>: Button<TProps, TElement>
		where TProps : Props.CompoundButton
		where TElement : global::Android.Widget.CompoundButton
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.ButtonTintList.HasValue)
			{
				Element.ButtonTintList = nextProps.ButtonTintList.Value.Value;
			}
			if (nextProps.ButtonTintMode.HasValue)
			{
				Element.ButtonTintMode = nextProps.ButtonTintMode.Value.Value;
			}
			if (nextProps.Checked.HasValue)
			{
				Element.Checked = nextProps.Checked.Value.Value;
			}
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
