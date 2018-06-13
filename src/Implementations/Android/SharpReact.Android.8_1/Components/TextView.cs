using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class TextView<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.TextView
		where TElement : global::Android.Widget.TextView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TextView(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.AutoLinkMask.HasValue)
			{
				Element.AutoLinkMask = nextProps.AutoLinkMask.Value.Value;
			}
			if (nextProps.BreakStrategy.HasValue)
			{
				Element.BreakStrategy = nextProps.BreakStrategy.Value.Value;
			}
			if (nextProps.CompoundDrawablePadding.HasValue)
			{
				Element.CompoundDrawablePadding = nextProps.CompoundDrawablePadding.Value.Value;
			}
			if (nextProps.CompoundDrawableTintList.HasValue)
			{
				Element.CompoundDrawableTintList = nextProps.CompoundDrawableTintList.Value.Value;
			}
			if (nextProps.CompoundDrawableTintMode.HasValue)
			{
				Element.CompoundDrawableTintMode = nextProps.CompoundDrawableTintMode.Value.Value;
			}
			if (nextProps.CustomInsertionActionModeCallback.HasValue)
			{
				Element.CustomInsertionActionModeCallback = nextProps.CustomInsertionActionModeCallback.Value.Value;
			}
			if (nextProps.CustomSelectionActionModeCallback.HasValue)
			{
				Element.CustomSelectionActionModeCallback = nextProps.CustomSelectionActionModeCallback.Value.Value;
			}
			if (nextProps.Ellipsize.HasValue)
			{
				Element.Ellipsize = nextProps.Ellipsize.Value.Value;
			}
			if (nextProps.ErrorFormatted.HasValue)
			{
				Element.ErrorFormatted = nextProps.ErrorFormatted.Value.Value;
			}
			if (nextProps.Error.HasValue)
			{
				Element.Error = nextProps.Error.Value.Value;
			}
			if (nextProps.FontFeatureSettings.HasValue)
			{
				Element.FontFeatureSettings = nextProps.FontFeatureSettings.Value.Value;
			}
			if (nextProps.FreezesText.HasValue)
			{
				Element.FreezesText = nextProps.FreezesText.Value.Value;
			}
			if (nextProps.Gravity.HasValue)
			{
				Element.Gravity = nextProps.Gravity.Value.Value;
			}
			if (nextProps.HintFormatted.HasValue)
			{
				Element.HintFormatted = nextProps.HintFormatted.Value.Value;
			}
			if (nextProps.Hint.HasValue)
			{
				Element.Hint = nextProps.Hint.Value.Value;
			}
			if (nextProps.HyphenationFrequency.HasValue)
			{
				Element.HyphenationFrequency = nextProps.HyphenationFrequency.Value.Value;
			}
			if (nextProps.ImeHintLocales.HasValue)
			{
				Element.ImeHintLocales = nextProps.ImeHintLocales.Value.Value;
			}
			if (nextProps.ImeOptions.HasValue)
			{
				Element.ImeOptions = nextProps.ImeOptions.Value.Value;
			}
			if (nextProps.InputType.HasValue)
			{
				Element.InputType = nextProps.InputType.Value.Value;
			}
			if (nextProps.JustificationMode.HasValue)
			{
				Element.JustificationMode = nextProps.JustificationMode.Value.Value;
			}
			if (nextProps.KeyListener.HasValue)
			{
				Element.KeyListener = nextProps.KeyListener.Value.Value;
			}
			if (nextProps.LetterSpacing.HasValue)
			{
				Element.LetterSpacing = nextProps.LetterSpacing.Value.Value;
			}
			if (nextProps.LinksClickable.HasValue)
			{
				Element.LinksClickable = nextProps.LinksClickable.Value.Value;
			}
			if (nextProps.MovementMethod.HasValue)
			{
				Element.MovementMethod = nextProps.MovementMethod.Value.Value;
			}
			if (nextProps.PaintFlags.HasValue)
			{
				Element.PaintFlags = nextProps.PaintFlags.Value.Value;
			}
			if (nextProps.PrivateImeOptions.HasValue)
			{
				Element.PrivateImeOptions = nextProps.PrivateImeOptions.Value.Value;
			}
			if (nextProps.ShowSoftInputOnFocus.HasValue)
			{
				Element.ShowSoftInputOnFocus = nextProps.ShowSoftInputOnFocus.Value.Value;
			}
			if (nextProps.TextFormatted.HasValue)
			{
				Element.TextFormatted = nextProps.TextFormatted.Value.Value;
			}
			if (nextProps.Text.HasValue)
			{
				Element.Text = nextProps.Text.Value.Value;
			}
			if (nextProps.TextClassifier.HasValue)
			{
				Element.TextClassifier = nextProps.TextClassifier.Value.Value;
			}
			if (nextProps.TextLocale.HasValue)
			{
				Element.TextLocale = nextProps.TextLocale.Value.Value;
			}
			if (nextProps.TextLocales.HasValue)
			{
				Element.TextLocales = nextProps.TextLocales.Value.Value;
			}
			if (nextProps.TextScaleX.HasValue)
			{
				Element.TextScaleX = nextProps.TextScaleX.Value.Value;
			}
			if (nextProps.TextSize.HasValue)
			{
				Element.TextSize = nextProps.TextSize.Value.Value;
			}
			if (nextProps.TransformationMethod.HasValue)
			{
				Element.TransformationMethod = nextProps.TransformationMethod.Value.Value;
			}
			if (nextProps.Typeface.HasValue)
			{
				Element.Typeface = nextProps.Typeface.Value.Value;
			}
			if (!ReferenceEquals(previous?.AfterTextChanged, null) && ReferenceEquals(nextProps.AfterTextChanged, null))
			{
				Element.AfterTextChanged -= nextProps.AfterTextChanged;
			}
			if (ReferenceEquals(previous?.AfterTextChanged, null) && !ReferenceEquals(nextProps.AfterTextChanged, null))
			{
				Element.AfterTextChanged += nextProps.AfterTextChanged;
			}
			if (!ReferenceEquals(previous?.BeforeTextChanged, null) && ReferenceEquals(nextProps.BeforeTextChanged, null))
			{
				Element.BeforeTextChanged -= nextProps.BeforeTextChanged;
			}
			if (ReferenceEquals(previous?.BeforeTextChanged, null) && !ReferenceEquals(nextProps.BeforeTextChanged, null))
			{
				Element.BeforeTextChanged += nextProps.BeforeTextChanged;
			}
			if (!ReferenceEquals(previous?.TextChanged, null) && ReferenceEquals(nextProps.TextChanged, null))
			{
				Element.TextChanged -= nextProps.TextChanged;
			}
			if (ReferenceEquals(previous?.TextChanged, null) && !ReferenceEquals(nextProps.TextChanged, null))
			{
				Element.TextChanged += nextProps.TextChanged;
			}
			if (!ReferenceEquals(previous?.EditorAction, null) && ReferenceEquals(nextProps.EditorAction, null))
			{
				Element.EditorAction -= nextProps.EditorAction;
			}
			if (ReferenceEquals(previous?.EditorAction, null) && !ReferenceEquals(nextProps.EditorAction, null))
			{
				Element.EditorAction += nextProps.EditorAction;
			}
		}
	}
}
