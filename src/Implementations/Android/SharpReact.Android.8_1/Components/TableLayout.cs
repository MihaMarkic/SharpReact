using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class TableLayout<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.TableLayout
		where TElement : global::Android.Widget.TableLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TableLayout(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateTableLayoutWithInstanceProperties(Element, previous, nextProps);
			PostAssignTableLayoutProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignTableLayoutProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateTableLayoutWithInstanceProperties(element, null, props);
		}
		static void UpdateTableLayoutWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.ShrinkAllColumns.HasValue)
			{
				element.ShrinkAllColumns = nextProps.ShrinkAllColumns.Value.Value;
			}
			if (nextProps.StretchAllColumns.HasValue)
			{
				element.StretchAllColumns = nextProps.StretchAllColumns.Value.Value;
			}
		}
	}
}
