using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class TableRow<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.TableRow
		where TElement : global::Android.Widget.TableRow
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TableRow(context);
		}
	}
}
