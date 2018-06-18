using SharpReact.Core.Properties;

namespace SharpReact.Core.MockUI.Test
{
    public class ReactAdapter
    {
        readonly ISharpRenderer<Elements.UIElement> renderer;
        SharpProp[] items;
        public ReactAdapter(ISharpRenderer<Elements.UIElement> renderer)
        {
            this.renderer = renderer;
        }
        public void AssignItems(SharpProp[] items)
        {
            this.items = items;
        }
        public SharpProp this[int position] => items[position];
        public int Count => items.Length;
        public long GetItemId(int position) => position;
        public Elements.UIElement GetView(int position, Elements.UIElement convertView)
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
