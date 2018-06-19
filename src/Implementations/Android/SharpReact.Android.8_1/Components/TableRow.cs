using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class TableRow<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.TableRow
		where TElement : global::Android.Widget.TableRow
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TableRow(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignTableRowProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
