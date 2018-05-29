
namespace SharpReact.Wpf.Components
{
	public  class PageFunction<T, TProps, TElement>: PageFunctionBase<TProps, TElement>
		where TProps : Props.PageFunction<T>
		where TElement : System.Windows.Navigation.PageFunction<T>
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Navigation.PageFunction<T>();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (!ReferenceEquals(Props?.Return, null) && ReferenceEquals(nextProps.Return, null))
			{
				Element.Return -= nextProps.Return;
			}
			if (ReferenceEquals(Props?.Return, null) && !ReferenceEquals(nextProps.Return, null))
			{
				Element.Return += nextProps.Return;
			}
		}
	}
}
