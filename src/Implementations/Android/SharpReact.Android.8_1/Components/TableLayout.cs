using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class TableLayout<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.TableLayout
		where TElement : global::Android.Widget.TableLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TableLayout(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.ShrinkAllColumns.HasValue)
			{
				Element.ShrinkAllColumns = nextProps.ShrinkAllColumns.Value.Value;
			}
			if (nextProps.StretchAllColumns.HasValue)
			{
				Element.StretchAllColumns = nextProps.StretchAllColumns.Value.Value;
			}
		}
	}
}
