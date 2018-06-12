using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ResizeGrip<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.ResizeGrip
		where TElement : global::System.Windows.Controls.Primitives.ResizeGrip, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
