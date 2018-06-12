using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class RadioButton<TProps, TElement>: CompoundButton<TProps, TElement>
		where TProps : Props.RadioButton
		where TElement : global::Android.Widget.RadioButton
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
