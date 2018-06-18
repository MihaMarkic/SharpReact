using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class PageFunction<T, TProps, TElement>: PageFunctionBase<TProps, TElement>
		where TProps : Props.PageFunction<T>
		where TElement : global::System.Windows.Navigation.PageFunction<T>, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (!ReferenceEquals(previous?.Return, null) && ReferenceEquals(nextProps.Return, null))
			{
				Element.Return -= nextProps.Return;
			}
			if (ReferenceEquals(previous?.Return, null) && !ReferenceEquals(nextProps.Return, null))
			{
				Element.Return += nextProps.Return;
			}
		}
	}
}
