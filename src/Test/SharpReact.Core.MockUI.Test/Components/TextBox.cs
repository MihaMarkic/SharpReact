using SharpReact.Core;

namespace SharpReact.Core.MockUI.Test.Components
{
    public class TextBox<TProps, TElement> : TextBoxBase<TProps, TElement>
        where TProps : Props.TextBox
        where TElement : Elements.TextBox, new()
    {
        //bool isUpdating;
        //int lastCaretIndex;
        //string oldText = "";

        public override void AssignProperties(ISharpCreator<Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            //if (!ReferenceEquals(Props?.TextChanged, null) && ReferenceEquals(nextProps.TextChanged, null))
            //{
            //    Element.TextChanged -= Element_TextChanged;
            //}
            //if (ReferenceEquals(Props?.TextChanged, null) && !ReferenceEquals(nextProps.TextChanged, null))
            //{
            //    Element.TextChanged += Element_TextChanged;
            //}
            //UpdateValue(nextProps.Text);
        }

        //private void Element_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (!isUpdating)
        //    {
        //        isUpdating = true;
        //        //string text = Element.Text;
        //        var newLastCaretIndex = Element.CaretIndex;
        //        //Element.Text = "";
        //        Props.TextChanged.Invoke(sender, e);
        //        Element.Text = oldText;
        //        Element.CaretIndex = lastCaretIndex;
        //        lastCaretIndex = newLastCaretIndex;
        //        isUpdating = false;
        //    }
        //}

        //public void UpdateValue(string value)
        //{
        //    isUpdating = true;
        //    Element.Text = value;
        //    Element.CaretIndex = lastCaretIndex;
        //    oldText = value;
        //    isUpdating = false;
        //}
    }
}
