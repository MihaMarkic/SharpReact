using Android.Views;
using Android.Widget;
using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Android
{
    public class ReactAdapter : BaseAdapter<SharpProp>
    {
        readonly ISharpRenderer<View> renderer;
        SharpProp[] items;
        public ReactAdapter(ISharpRenderer<View> renderer)
        {
            this.renderer = renderer;
        }
        public void AssignItems(SharpProp[] items)
        {
            this.items = items;
        }
        public override SharpProp this[int position] => items[position];
        public override int Count => items.Length;
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