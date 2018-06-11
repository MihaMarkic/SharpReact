using System.Collections.Generic;
using System.Linq;
using Terminal.Gui;

namespace SharpReact.Terminal.Gui
{
    public static class ElementSynchronizer
    {
        public static void SyncElements<T>(T owner, View[] next)
            where T: View
        {
            View tempSource;
            if (typeof(T) == typeof(Window))
            {
                tempSource = owner.Subviews[0];
            }
            else
            {
                tempSource = owner;
            }
            foreach (var n in next)
            {
                if (tempSource.Subviews.SingleOrDefault(e => ReferenceEquals(e, n)) == null)
                {
                    owner.Add(n);
                }
            }
            foreach (var o in tempSource.Subviews.ToArray())
            {
                if (next.SingleOrDefault(e => ReferenceEquals(e, o)) == null)
                {
                    owner.Remove(o);
                }
            }
        }
    }
}
