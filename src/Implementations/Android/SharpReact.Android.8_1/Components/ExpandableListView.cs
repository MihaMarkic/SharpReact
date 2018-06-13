using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ExpandableListView<TProps, TElement>: ListView<TProps, TElement>
		where TProps : Props.ExpandableListView
		where TElement : global::Android.Widget.ExpandableListView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ExpandableListView(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.ExpandableListView.Views), nameof(SharpReact.Android.Props.ExpandableListView));
				ElementSynchronizer.SyncElements(Element, elements);
			}
			if (!ReferenceEquals(previous?.ChildClick, null) && ReferenceEquals(nextProps.ChildClick, null))
			{
				Element.ChildClick -= nextProps.ChildClick;
			}
			if (ReferenceEquals(previous?.ChildClick, null) && !ReferenceEquals(nextProps.ChildClick, null))
			{
				Element.ChildClick += nextProps.ChildClick;
			}
			if (!ReferenceEquals(previous?.GroupClick, null) && ReferenceEquals(nextProps.GroupClick, null))
			{
				Element.GroupClick -= nextProps.GroupClick;
			}
			if (ReferenceEquals(previous?.GroupClick, null) && !ReferenceEquals(nextProps.GroupClick, null))
			{
				Element.GroupClick += nextProps.GroupClick;
			}
			if (!ReferenceEquals(previous?.GroupCollapse, null) && ReferenceEquals(nextProps.GroupCollapse, null))
			{
				Element.GroupCollapse -= nextProps.GroupCollapse;
			}
			if (ReferenceEquals(previous?.GroupCollapse, null) && !ReferenceEquals(nextProps.GroupCollapse, null))
			{
				Element.GroupCollapse += nextProps.GroupCollapse;
			}
			if (!ReferenceEquals(previous?.GroupExpand, null) && ReferenceEquals(nextProps.GroupExpand, null))
			{
				Element.GroupExpand -= nextProps.GroupExpand;
			}
			if (ReferenceEquals(previous?.GroupExpand, null) && !ReferenceEquals(nextProps.GroupExpand, null))
			{
				Element.GroupExpand += nextProps.GroupExpand;
			}
		}
	}
}
