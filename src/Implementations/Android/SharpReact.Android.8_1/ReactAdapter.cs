using Android.Views;
using Android.Widget;
using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Android
{
    public class ReactAdapter : BaseAdapter<ISharpProp>
    {
        readonly ISharpRenderer<View> renderer;
        ISharpProp[] items;
        public ReactAdapter(ISharpRenderer<View> renderer)
        {
            this.renderer = renderer;
        }
        public void AssignItems(ISharpProp[] items)
        {
            bool different = renderer.ComparePropertyLists(this.items, items);
            this.items = items;
            if (different)
            {
                NotifyDataSetChanged();
            }
        }
        public override ISharpProp this[int position] => items[position];
        public override int Count => items?.Length ?? 0;
        public override long GetItemId(int position) => position;
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var prop = items[position];
            if (convertView == null)
            {
                convertView = renderer.ProcessPair(0, NewState.Empty, null, prop);
            }
            else
            {
                renderer.RemoveElement(convertView, prop);
                renderer.UpdateExistingElement(convertView, prop);
            }
            return convertView;
        }
    }
}