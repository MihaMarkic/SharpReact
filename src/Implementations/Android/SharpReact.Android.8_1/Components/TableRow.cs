using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class TableRow<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.TableRow
		where TElement : global::Android.Widget.TableRow
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
