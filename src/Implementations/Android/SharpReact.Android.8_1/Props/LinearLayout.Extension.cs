namespace SharpReact.Android.Props
{
    partial class LinearLayout
	{
        public new static class MatchX
        {
            public static global::Android.Widget.LinearLayout.LayoutParams WrapY()
            {
                return new global::Android.Widget.LinearLayout.LayoutParams(global::Android.Widget.LinearLayout.LayoutParams.MatchParent, global::Android.Widget.LinearLayout.LayoutParams.WrapContent);
            }
            public static global::Android.Widget.LinearLayout.LayoutParams MatchY()
            {
                return new global::Android.Widget.LinearLayout.LayoutParams(global::Android.Widget.LinearLayout.LayoutParams.MatchParent, global::Android.Widget.LinearLayout.LayoutParams.MatchParent);
            }
        }
        public new static class WrapX
        {
            public static global::Android.Widget.LinearLayout.LayoutParams WrapY()
            {
                return new global::Android.Widget.LinearLayout.LayoutParams(global::Android.Widget.LinearLayout.LayoutParams.WrapContent, global::Android.Widget.LinearLayout.LayoutParams.WrapContent);
            }
            public static global::Android.Widget.LinearLayout.LayoutParams MatchY()
            {
                return new global::Android.Widget.LinearLayout.LayoutParams(global::Android.Widget.LinearLayout.LayoutParams.WrapContent, global::Android.Widget.LinearLayout.LayoutParams.MatchParent);
            }
        }
    }
}
