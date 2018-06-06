using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class GridViewRowPresenter: GridViewRowPresenterBase
	{
		public ISharpProp Content { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.GridViewRowPresenter<GridViewRowPresenter, System.Windows.Controls.GridViewRowPresenter>();
		}
		protected override void UnmountComponent()
		{
			UnmountComponent(Content);
			base.UnmountComponent();
		}
	}
}
