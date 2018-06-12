using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class DocumentReference: FrameworkElement
	{
		public ReactParam<global::System.Uri>? Source { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DocumentReference<DocumentReference>();
		}
	}
}
