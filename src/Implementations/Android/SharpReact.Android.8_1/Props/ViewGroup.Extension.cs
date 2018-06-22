namespace SharpReact.Android.Props
{
    partial class ViewGroup
	{
        public static class MatchX
        {
            public static global::Android.Views.ViewGroup.LayoutParams WrapY()
            {
                return new global::Android.Views.ViewGroup.LayoutParams(global::Android.Views.ViewGroup.LayoutParams.MatchParent, global::Android.Views.ViewGroup.LayoutParams.WrapContent);
            }
            public static global::Android.Views.ViewGroup.LayoutParams MatchY()
            {
                return new global::Android.Views.ViewGroup.LayoutParams(global::Android.Views.ViewGroup.LayoutParams.MatchParent, global::Android.Views.ViewGroup.LayoutParams.MatchParent);
            }
        }
        public static class WrapX
        {
            public static global::Android.Views.ViewGroup.LayoutParams WrapY()
            {
                return new global::Android.Views.ViewGroup.LayoutParams(global::Android.Views.ViewGroup.LayoutParams.WrapContent, global::Android.Views.ViewGroup.LayoutParams.WrapContent);
            }
            public static global::Android.Views.ViewGroup.LayoutParams MatchY()
            {
                return new global::Android.Views.ViewGroup.LayoutParams(global::Android.Views.ViewGroup.LayoutParams.WrapContent, global::Android.Views.ViewGroup.LayoutParams.MatchParent);
            }
        }
    }
}
