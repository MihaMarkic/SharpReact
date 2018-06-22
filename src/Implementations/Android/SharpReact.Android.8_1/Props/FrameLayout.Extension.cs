namespace SharpReact.Android.Props
{
    partial class FrameLayout
    {
        public new static class MatchX
        {
            public static global::Android.Widget.FrameLayout.LayoutParams WrapY()
            {
                return new global::Android.Widget.FrameLayout.LayoutParams(global::Android.Widget.FrameLayout.LayoutParams.MatchParent, global::Android.Widget.FrameLayout.LayoutParams.WrapContent);
            }
            public static global::Android.Widget.FrameLayout.LayoutParams MatchY()
            {
                return new global::Android.Widget.FrameLayout.LayoutParams(global::Android.Widget.FrameLayout.LayoutParams.MatchParent, global::Android.Widget.FrameLayout.LayoutParams.MatchParent);
            }
        }
        public new static class WrapX
        {
            public static global::Android.Widget.FrameLayout.LayoutParams WrapY()
            {
                return new global::Android.Widget.FrameLayout.LayoutParams(global::Android.Widget.LinearLayout.LayoutParams.WrapContent, global::Android.Widget.FrameLayout.LayoutParams.WrapContent);
            }
            public static global::Android.Widget.FrameLayout.LayoutParams MatchY()
            {
                return new global::Android.Widget.FrameLayout.LayoutParams(global::Android.Widget.LinearLayout.LayoutParams.WrapContent, global::Android.Widget.FrameLayout.LayoutParams.MatchParent);
            }
        }
    }
}