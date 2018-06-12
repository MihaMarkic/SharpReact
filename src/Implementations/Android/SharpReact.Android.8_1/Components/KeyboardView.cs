using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class KeyboardView<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.KeyboardView
		where TElement : global::Android.InputMethodServices.KeyboardView
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Keyboard.HasValue)
			{
				Element.Keyboard = nextProps.Keyboard.Value.Value;
			}
			if (nextProps.OnKeyboardActionListener.HasValue)
			{
				Element.OnKeyboardActionListener = nextProps.OnKeyboardActionListener.Value.Value;
			}
			if (nextProps.PreviewEnabled.HasValue)
			{
				Element.PreviewEnabled = nextProps.PreviewEnabled.Value.Value;
			}
			if (nextProps.ProximityCorrectionEnabled.HasValue)
			{
				Element.ProximityCorrectionEnabled = nextProps.ProximityCorrectionEnabled.Value.Value;
			}
			if (!ReferenceEquals(previous?.Key, null) && ReferenceEquals(nextProps.Key, null))
			{
				Element.Key -= nextProps.Key;
			}
			if (ReferenceEquals(previous?.Key, null) && !ReferenceEquals(nextProps.Key, null))
			{
				Element.Key += nextProps.Key;
			}
			if (!ReferenceEquals(previous?.Press, null) && ReferenceEquals(nextProps.Press, null))
			{
				Element.Press -= nextProps.Press;
			}
			if (ReferenceEquals(previous?.Press, null) && !ReferenceEquals(nextProps.Press, null))
			{
				Element.Press += nextProps.Press;
			}
			if (!ReferenceEquals(previous?.Release, null) && ReferenceEquals(nextProps.Release, null))
			{
				Element.Release -= nextProps.Release;
			}
			if (ReferenceEquals(previous?.Release, null) && !ReferenceEquals(nextProps.Release, null))
			{
				Element.Release += nextProps.Release;
			}
			if (!ReferenceEquals(previous?.Text, null) && ReferenceEquals(nextProps.Text, null))
			{
				Element.Text -= nextProps.Text;
			}
			if (ReferenceEquals(previous?.Text, null) && !ReferenceEquals(nextProps.Text, null))
			{
				Element.Text += nextProps.Text;
			}
			if (!ReferenceEquals(previous?.SwipeDownEvent, null) && ReferenceEquals(nextProps.SwipeDownEvent, null))
			{
				Element.SwipeDownEvent -= nextProps.SwipeDownEvent;
			}
			if (ReferenceEquals(previous?.SwipeDownEvent, null) && !ReferenceEquals(nextProps.SwipeDownEvent, null))
			{
				Element.SwipeDownEvent += nextProps.SwipeDownEvent;
			}
			if (!ReferenceEquals(previous?.SwipeLeftEvent, null) && ReferenceEquals(nextProps.SwipeLeftEvent, null))
			{
				Element.SwipeLeftEvent -= nextProps.SwipeLeftEvent;
			}
			if (ReferenceEquals(previous?.SwipeLeftEvent, null) && !ReferenceEquals(nextProps.SwipeLeftEvent, null))
			{
				Element.SwipeLeftEvent += nextProps.SwipeLeftEvent;
			}
			if (!ReferenceEquals(previous?.SwipeRightEvent, null) && ReferenceEquals(nextProps.SwipeRightEvent, null))
			{
				Element.SwipeRightEvent -= nextProps.SwipeRightEvent;
			}
			if (ReferenceEquals(previous?.SwipeRightEvent, null) && !ReferenceEquals(nextProps.SwipeRightEvent, null))
			{
				Element.SwipeRightEvent += nextProps.SwipeRightEvent;
			}
			if (!ReferenceEquals(previous?.SwipeUpEvent, null) && ReferenceEquals(nextProps.SwipeUpEvent, null))
			{
				Element.SwipeUpEvent -= nextProps.SwipeUpEvent;
			}
			if (ReferenceEquals(previous?.SwipeUpEvent, null) && !ReferenceEquals(nextProps.SwipeUpEvent, null))
			{
				Element.SwipeUpEvent += nextProps.SwipeUpEvent;
			}
		}
	}
}
