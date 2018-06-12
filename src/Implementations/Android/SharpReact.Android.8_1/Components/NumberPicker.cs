using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class NumberPicker<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.NumberPicker
		where TElement : global::Android.Widget.NumberPicker
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.MaxValue.HasValue)
			{
				Element.MaxValue = nextProps.MaxValue.Value.Value;
			}
			if (nextProps.MinValue.HasValue)
			{
				Element.MinValue = nextProps.MinValue.Value.Value;
			}
			if (nextProps.Value.HasValue)
			{
				Element.Value = nextProps.Value.Value.Value;
			}
			if (nextProps.WrapSelectorWheel.HasValue)
			{
				Element.WrapSelectorWheel = nextProps.WrapSelectorWheel.Value.Value;
			}
			if (!ReferenceEquals(previous?.Scroll, null) && ReferenceEquals(nextProps.Scroll, null))
			{
				Element.Scroll -= nextProps.Scroll;
			}
			if (ReferenceEquals(previous?.Scroll, null) && !ReferenceEquals(nextProps.Scroll, null))
			{
				Element.Scroll += nextProps.Scroll;
			}
			if (!ReferenceEquals(previous?.ValueChanged, null) && ReferenceEquals(nextProps.ValueChanged, null))
			{
				Element.ValueChanged -= nextProps.ValueChanged;
			}
			if (ReferenceEquals(previous?.ValueChanged, null) && !ReferenceEquals(nextProps.ValueChanged, null))
			{
				Element.ValueChanged += nextProps.ValueChanged;
			}
		}
	}
}