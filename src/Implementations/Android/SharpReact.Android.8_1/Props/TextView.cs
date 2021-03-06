using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class TextView: View
	{
		public ReactParam<global::Android.Text.Util.MatchOptions>? AutoLinkMask { get; set; }
		public ReactParam<global::Android.Text.BreakStrategy>? BreakStrategy { get; set; }
		public ReactParam<global::System.Int32>? CompoundDrawablePadding { get; set; }
		public ReactParam<global::Android.Content.Res.ColorStateList>? CompoundDrawableTintList { get; set; }
		public ReactParam<global::Android.Graphics.PorterDuff.Mode>? CompoundDrawableTintMode { get; set; }
		public ReactParam<global::Android.Views.ActionMode.ICallback>? CustomInsertionActionModeCallback { get; set; }
		public ReactParam<global::Android.Views.ActionMode.ICallback>? CustomSelectionActionModeCallback { get; set; }
		public ReactParam<global::Android.Text.TextUtils.TruncateAt>? Ellipsize { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? ErrorFormatted { get; set; }
		public ReactParam<global::System.String>? Error { get; set; }
		public ReactParam<global::System.String>? FontFeatureSettings { get; set; }
		public ReactParam<global::System.Boolean>? FreezesText { get; set; }
		public ReactParam<global::Android.Views.GravityFlags>? Gravity { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? HintFormatted { get; set; }
		public ReactParam<global::System.String>? Hint { get; set; }
		public ReactParam<global::Android.Text.HyphenationFrequency>? HyphenationFrequency { get; set; }
		public ReactParam<global::Android.OS.LocaleList>? ImeHintLocales { get; set; }
		public ReactParam<global::Android.Views.InputMethods.ImeAction>? ImeOptions { get; set; }
		public ReactParam<global::Android.Text.InputTypes>? InputType { get; set; }
		public ReactParam<global::Android.Text.JustificationMode>? JustificationMode { get; set; }
		public ReactParam<global::Android.Text.Method.IKeyListener>? KeyListener { get; set; }
		public ReactParam<global::System.Single>? LetterSpacing { get; set; }
		public ReactParam<global::System.Boolean>? LinksClickable { get; set; }
		public ReactParam<global::Android.Text.Method.IMovementMethod>? MovementMethod { get; set; }
		public ReactParam<global::Android.Graphics.PaintFlags>? PaintFlags { get; set; }
		public ReactParam<global::System.String>? PrivateImeOptions { get; set; }
		public ReactParam<global::System.Boolean>? ShowSoftInputOnFocus { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? TextFormatted { get; set; }
		public ReactParam<global::System.String>? Text { get; set; }
		public ReactParam<global::Android.Views.TextClassifiers.ITextClassifier>? TextClassifier { get; set; }
		public ReactParam<global::Java.Util.Locale>? TextLocale { get; set; }
		public ReactParam<global::Android.OS.LocaleList>? TextLocales { get; set; }
		public ReactParam<global::System.Single>? TextScaleX { get; set; }
		public ReactParam<global::System.Single>? TextSize { get; set; }
		public ReactParam<global::Android.Text.Method.ITransformationMethod>? TransformationMethod { get; set; }
		public ReactParam<global::Android.Graphics.Typeface>? Typeface { get; set; }
		public System.EventHandler<global::Android.Text.AfterTextChangedEventArgs> AfterTextChanged { get; set; }
		public System.EventHandler<global::Android.Text.TextChangedEventArgs> BeforeTextChanged { get; set; }
		public System.EventHandler<global::Android.Text.TextChangedEventArgs> TextChanged { get; set; }
		public System.EventHandler<global::Android.Widget.TextView.EditorActionEventArgs> EditorAction { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TextView<TextView, global::Android.Widget.TextView>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return AutoLinkMask;
				yield return BreakStrategy;
				yield return CompoundDrawablePadding;
				yield return CompoundDrawableTintList;
				yield return CompoundDrawableTintMode;
				yield return CustomInsertionActionModeCallback;
				yield return CustomSelectionActionModeCallback;
				yield return Ellipsize;
				yield return ErrorFormatted;
				yield return Error;
				yield return FontFeatureSettings;
				yield return FreezesText;
				yield return Gravity;
				yield return HintFormatted;
				yield return Hint;
				yield return HyphenationFrequency;
				yield return ImeHintLocales;
				yield return ImeOptions;
				yield return InputType;
				yield return JustificationMode;
				yield return KeyListener;
				yield return LetterSpacing;
				yield return LinksClickable;
				yield return MovementMethod;
				yield return PaintFlags;
				yield return PrivateImeOptions;
				yield return ShowSoftInputOnFocus;
				yield return TextFormatted;
				yield return Text;
				yield return TextClassifier;
				yield return TextLocale;
				yield return TextLocales;
				yield return TextScaleX;
				yield return TextSize;
				yield return TransformationMethod;
				yield return Typeface;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
