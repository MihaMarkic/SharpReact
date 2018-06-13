using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class WebView: AbsoluteLayout
	{
		public ReactParam<global::Android.Net.Http.SslCertificate>? Certificate { get; set; }
		public ReactParam<global::Android.Views.TextClassifiers.ITextClassifier>? TextClassifier { get; set; }
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		public System.EventHandler<global::Android.Webkit.DownloadEventArgs> Download { get; set; }
		public System.EventHandler<global::Android.Webkit.WebView.FindEventArgs> Find { get; set; }
		public System.EventHandler<global::Android.Webkit.WebView.PictureEventArgs> Picture { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.WebView<WebView, global::Android.Webkit.WebView>();
		}
	}
}
