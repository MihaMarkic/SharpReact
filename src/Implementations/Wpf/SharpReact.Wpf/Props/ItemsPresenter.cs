using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ItemsPresenter: FrameworkElement
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ItemsPresenter<ItemsPresenter, System.Windows.Controls.ItemsPresenter>();
		}
	}
}
