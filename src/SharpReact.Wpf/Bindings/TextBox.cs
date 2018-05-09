//using Sharp = SharpReact.Wpf.Models;
//using Controls = System.Windows.Controls;
//using System;
//using SharpReact.Core.Models;

//namespace SharpReact.Wpf.Bindings
//{
//    public static class TextBox
//    {
//        public class Handler: ElementHandler
//        {
//            public Controls.TextBox Target;
//            public Action<string> TextChanged;
//            private bool isUpdating;
//            private int lastCaretIndex;
//            public Handler(WpfTreeRenderer renderer) : base(renderer)
//            {}
//            public void UpdateValue(string value)
//            {
//                isUpdating = true;
//                Target.Text = value;
//                Target.CaretIndex = lastCaretIndex;
//                isUpdating = false;
//            }
//            public override void Bind()
//            {
//                Target.TextChanged += (sender, e) =>
//                {
//                    if (!isUpdating)
//                    {
//                        isUpdating = true;
//                        string text = Target.Text;
//                        lastCaretIndex = Target.CaretIndex;
//                        Target.Text = "";
//                        isUpdating = false;
//                        TextChanged(text);
//                    }
//                };
//            }
//        }

//        public static void Populate(WpfTreeRenderer renderer, Sharp.TextBox source, Controls.TextBox item)
//        {
//            TextBoxBase.Populate(renderer, source, item);
//            Handler handler;
//            if (source.Operation == ModelOperation.Insert && source.TextChanged != null)
//            {
//                handler = new Handler(renderer) { Target = item, TextChanged = source.TextChanged };
//                handler.Bind();
//                Attached.Handler(item, handler);
//            }
//            else
//            {
//                handler = (Handler)Attached.Handler(item);
//            }
//            handler.UpdateValue(source.Text);
//        }
//    }
//}
