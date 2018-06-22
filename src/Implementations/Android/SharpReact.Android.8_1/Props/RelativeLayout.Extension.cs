using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SharpReact.Android.Props
{
    partial class RelativeLayout
    {
        public new static class MatchX
        {
            public static global::Android.Widget.RelativeLayout.LayoutParams WrapY()
            {
                return new global::Android.Widget.RelativeLayout.LayoutParams(global::Android.Widget.RelativeLayout.LayoutParams.MatchParent, global::Android.Widget.RelativeLayout.LayoutParams.WrapContent);
            }
            public static global::Android.Widget.RelativeLayout.LayoutParams MatchY()
            {
                return new global::Android.Widget.RelativeLayout.LayoutParams(global::Android.Widget.RelativeLayout.LayoutParams.MatchParent, global::Android.Widget.RelativeLayout.LayoutParams.MatchParent);
            }
        }
        public new static class WrapX
        {
            public static global::Android.Widget.RelativeLayout.LayoutParams WrapY()
            {
                return new global::Android.Widget.RelativeLayout.LayoutParams(global::Android.Widget.LinearLayout.LayoutParams.WrapContent, global::Android.Widget.RelativeLayout.LayoutParams.WrapContent);
            }
            public static global::Android.Widget.RelativeLayout.LayoutParams MatchY()
            {
                return new global::Android.Widget.RelativeLayout.LayoutParams(global::Android.Widget.LinearLayout.LayoutParams.WrapContent, global::Android.Widget.RelativeLayout.LayoutParams.MatchParent);
            }
        }
    }
}