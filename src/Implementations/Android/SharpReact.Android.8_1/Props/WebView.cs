using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class WebView: AbsoluteLayout
	{
		public ReactParam<global::Android.Net.Http.SslCertificate>? Certificate { get; set; }
		public ReactParam<global::Android.Views.TextClassifiers.ITextClassifier>? TextClassifier { get; set; }
		public System.EventHandler<global::Android.Webkit.DownloadEventArgs> Download { get; set; }
		public System.EventHandler<global::Android.Webkit.WebView.FindEventArgs> Find { get; set; }
		public System.EventHandler<global::Android.Webkit.WebView.PictureEventArgs> Picture { get; set; }
	}
}
