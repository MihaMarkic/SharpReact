using Android.Views;
using static Android.Views.ViewGroup;

namespace SharpReact.Android
{
    public static class PropsExtensions
    {
        public static T TopMargin<T>(this T source, int value)
            where T: MarginLayoutParams
        {
            source.TopMargin = value;
            return source;
        }
        public static T LeftMargin<T>(this T source, int value)
            where T : MarginLayoutParams
        {
            source.LeftMargin = value;
            return source;
        }
        public static T RightMargin<T>(this T source, int value)
            where T : MarginLayoutParams
        {
            source.RightMargin = value;
            return source;
        }
        public static T BottomMargin<T>(this T source, int value)
            where T : MarginLayoutParams
        {
            source.BottomMargin = value;
            return source;
        }
        public static T SetMargins<T>(this T source, int left, int top, int right, int bottom)
            where T : MarginLayoutParams
        {
            source.SetMargins(left, top, right, bottom);
            return source;
        }
        public static T Gravity<T>(this T source, GravityFlags value)
            where T : global::Android.Widget.LinearLayout.LayoutParams
        {
            source.Gravity = value;
            return source;
        }
        public static T Weight<T>(this T source, float value)
            where T : global::Android.Widget.LinearLayout.LayoutParams
        {
            source.Weight = value;
            return source;
        }
        public static global::Android.Widget.FrameLayout.LayoutParams Gravity(this global::Android.Widget.FrameLayout.LayoutParams source, GravityFlags value)
        {
            source.Gravity = value;
            return source;
        }
        public static T AlignWithParent<T>(this T source, bool value)
            where T : global::Android.Widget.RelativeLayout.LayoutParams
        {
            source.AlignWithParent = value;
            return source;
        }
        public static T AddRule<T>(this T source, global::Android.Widget.LayoutRules value)
            where T : global::Android.Widget.RelativeLayout.LayoutParams
        {
            source.AddRule(value);
            return source;
        }
        public static T AddRule<T>(this T source, global::Android.Widget.LayoutRules value, int subject)
            where T : global::Android.Widget.RelativeLayout.LayoutParams
        {
            source.AddRule(value, subject);
            return source;
        }
    }
}