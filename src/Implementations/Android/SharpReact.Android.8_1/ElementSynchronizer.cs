using Android.Views;
using System;

namespace SharpReact.Android
{
    public static class ElementSynchronizer
    {
        public static void SyncElements(IViewManager viewManager, View[] elements)
        {
            if (viewManager is ViewGroup viewGroup)
            {
                for (int i = 0; i < Math.Min(elements.Length, viewGroup.ChildCount); i++)
                {
                    var current = viewGroup.GetChildAt(i);
                    if (!ReferenceEquals(current, elements[i]))
                    {
                        viewGroup.RemoveViewAt(i);
                        viewGroup.AddView(elements[i], i);
                    }
                }
                if (viewGroup.ChildCount > elements.Length)
                {
                    for (int i = 0; i < viewGroup.ChildCount - elements.Length; i++)
                    {
                        viewGroup.RemoveViewAt(viewGroup.ChildCount - 1);
                    }
                }
                else
                {
                    for (int i = viewGroup.ChildCount; i < elements.Length; i++)
                    {
                        viewGroup.AddView(elements[i]);
                    }
                }
            }
        }
    }
}