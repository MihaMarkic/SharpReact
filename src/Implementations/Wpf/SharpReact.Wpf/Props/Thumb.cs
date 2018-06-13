using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class Thumb: Control
	{
		public System.Windows.Controls.Primitives.DragStartedEventHandler DragStarted { get; set; }
		public System.Windows.Controls.Primitives.DragDeltaEventHandler DragDelta { get; set; }
		public System.Windows.Controls.Primitives.DragCompletedEventHandler DragCompleted { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Thumb<Thumb, System.Windows.Controls.Primitives.Thumb>();
		}
	}
}
