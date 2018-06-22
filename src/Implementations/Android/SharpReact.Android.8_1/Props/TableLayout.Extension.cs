namespace SharpReact.Android.Props
{
    partial class TableLayout
    {
        public new static class MatchX
        {
            public static global::Android.Widget.TableLayout.LayoutParams WrapY()
            {
                return new global::Android.Widget.TableLayout.LayoutParams(global::Android.Widget.TableLayout.LayoutParams.MatchParent, global::Android.Widget.TableLayout.LayoutParams.WrapContent);
            }
            public static global::Android.Widget.TableLayout.LayoutParams MatchY()
            {
                return new global::Android.Widget.TableLayout.LayoutParams(global::Android.Widget.TableLayout.LayoutParams.MatchParent, global::Android.Widget.TableLayout.LayoutParams.MatchParent);
            }
        }
        public new static class WrapX
        {
            public static global::Android.Widget.TableLayout.LayoutParams WrapY()
            {
                return new global::Android.Widget.TableLayout.LayoutParams(global::Android.Widget.TableLayout.LayoutParams.WrapContent, global::Android.Widget.TableLayout.LayoutParams.WrapContent);
            }
            public static global::Android.Widget.TableLayout.LayoutParams MatchY()
            {
                return new global::Android.Widget.TableLayout.LayoutParams(global::Android.Widget.TableLayout.LayoutParams.WrapContent, global::Android.Widget.TableLayout.LayoutParams.MatchParent);
            }
        }
    }
}