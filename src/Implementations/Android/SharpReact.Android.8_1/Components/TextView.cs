using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class TextView<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.TextView
		where TElement : global::Android.Widget.TextView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TextView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateTextViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignTextViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignTextViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateTextViewWithInstanceProperties(element, null, props);
		}
		static void UpdateTextViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.AutoLinkMask.HasValue)
			{
				element.AutoLinkMask = nextProps.AutoLinkMask.Value.Value;
			}
			if (nextProps.BreakStrategy.HasValue)
			{
				element.BreakStrategy = nextProps.BreakStrategy.Value.Value;
			}
			if (nextProps.CompoundDrawablePadding.HasValue)
			{
				element.CompoundDrawablePadding = nextProps.CompoundDrawablePadding.Value.Value;
			}
			if (nextProps.CompoundDrawableTintList.HasValue)
			{
				element.CompoundDrawableTintList = nextProps.CompoundDrawableTintList.Value.Value;
			}
			if (nextProps.CompoundDrawableTintMode.HasValue)
			{
				element.CompoundDrawableTintMode = nextProps.CompoundDrawableTintMode.Value.Value;
			}
			if (nextProps.CustomInsertionActionModeCallback.HasValue)
			{
				element.CustomInsertionActionModeCallback = nextProps.CustomInsertionActionModeCallback.Value.Value;
			}
			if (nextProps.CustomSelectionActionModeCallback.HasValue)
			{
				element.CustomSelectionActionModeCallback = nextProps.CustomSelectionActionModeCallback.Value.Value;
			}
			if (nextProps.Ellipsize.HasValue)
			{
				element.Ellipsize = nextProps.Ellipsize.Value.Value;
			}
			if (nextProps.ErrorFormatted.HasValue)
			{
				element.ErrorFormatted = nextProps.ErrorFormatted.Value.Value;
			}
			if (nextProps.Error.HasValue)
			{
				element.Error = nextProps.Error.Value.Value;
			}
			if (nextProps.FontFeatureSettings.HasValue)
			{
				element.FontFeatureSettings = nextProps.FontFeatureSettings.Value.Value;
			}
			if (nextProps.FreezesText.HasValue)
			{
				element.FreezesText = nextProps.FreezesText.Value.Value;
			}
			if (nextProps.Gravity.HasValue)
			{
				element.Gravity = nextProps.Gravity.Value.Value;
			}
			if (nextProps.HintFormatted.HasValue)
			{
				element.HintFormatted = nextProps.HintFormatted.Value.Value;
			}
			if (nextProps.Hint.HasValue)
			{
				element.Hint = nextProps.Hint.Value.Value;
			}
			if (nextProps.HyphenationFrequency.HasValue)
			{
				element.HyphenationFrequency = nextProps.HyphenationFrequency.Value.Value;
			}
			if (nextProps.ImeHintLocales.HasValue)
			{
				element.ImeHintLocales = nextProps.ImeHintLocales.Value.Value;
			}
			if (nextProps.ImeOptions.HasValue)
			{
				element.ImeOptions = nextProps.ImeOptions.Value.Value;
			}
			if (nextProps.InputType.HasValue)
			{
				element.InputType = nextProps.InputType.Value.Value;
			}
			if (nextProps.JustificationMode.HasValue)
			{
				element.JustificationMode = nextProps.JustificationMode.Value.Value;
			}
			if (nextProps.KeyListener.HasValue)
			{
				element.KeyListener = nextProps.KeyListener.Value.Value;
			}
			if (nextProps.LetterSpacing.HasValue)
			{
				element.LetterSpacing = nextProps.LetterSpacing.Value.Value;
			}
			if (nextProps.LinksClickable.HasValue)
			{
				element.LinksClickable = nextProps.LinksClickable.Value.Value;
			}
			if (nextProps.MovementMethod.HasValue)
			{
				element.MovementMethod = nextProps.MovementMethod.Value.Value;
			}
			if (nextProps.PaintFlags.HasValue)
			{
				element.PaintFlags = nextProps.PaintFlags.Value.Value;
			}
			if (nextProps.PrivateImeOptions.HasValue)
			{
				element.PrivateImeOptions = nextProps.PrivateImeOptions.Value.Value;
			}
			if (nextProps.ShowSoftInputOnFocus.HasValue)
			{
				element.ShowSoftInputOnFocus = nextProps.ShowSoftInputOnFocus.Value.Value;
			}
			if (nextProps.TextFormatted.HasValue)
			{
				element.TextFormatted = nextProps.TextFormatted.Value.Value;
			}
			if (nextProps.Text.HasValue)
			{
				element.Text = nextProps.Text.Value.Value;
			}
			if (nextProps.TextClassifier.HasValue)
			{
				element.TextClassifier = nextProps.TextClassifier.Value.Value;
			}
			if (nextProps.TextLocale.HasValue)
			{
				element.TextLocale = nextProps.TextLocale.Value.Value;
			}
			if (nextProps.TextLocales.HasValue)
			{
				element.TextLocales = nextProps.TextLocales.Value.Value;
			}
			if (nextProps.TextScaleX.HasValue)
			{
				element.TextScaleX = nextProps.TextScaleX.Value.Value;
			}
			if (nextProps.TextSize.HasValue)
			{
				element.TextSize = nextProps.TextSize.Value.Value;
			}
			if (nextProps.TransformationMethod.HasValue)
			{
				element.TransformationMethod = nextProps.TransformationMethod.Value.Value;
			}
			if (nextProps.Typeface.HasValue)
			{
				element.Typeface = nextProps.Typeface.Value.Value;
			}
			if (!(previous?.AfterTextChanged is null) && nextProps.AfterTextChanged is null)
			{
				element.AfterTextChanged -= nextProps.AfterTextChanged;
			}
			if (previous?.AfterTextChanged is null && !(nextProps.AfterTextChanged is null))
			{
				element.AfterTextChanged += nextProps.AfterTextChanged;
			}
			if (!(previous?.BeforeTextChanged is null) && nextProps.BeforeTextChanged is null)
			{
				element.BeforeTextChanged -= nextProps.BeforeTextChanged;
			}
			if (previous?.BeforeTextChanged is null && !(nextProps.BeforeTextChanged is null))
			{
				element.BeforeTextChanged += nextProps.BeforeTextChanged;
			}
			if (!(previous?.TextChanged is null) && nextProps.TextChanged is null)
			{
				element.TextChanged -= nextProps.TextChanged;
			}
			if (previous?.TextChanged is null && !(nextProps.TextChanged is null))
			{
				element.TextChanged += nextProps.TextChanged;
			}
			if (!(previous?.EditorAction is null) && nextProps.EditorAction is null)
			{
				element.EditorAction -= nextProps.EditorAction;
			}
			if (previous?.EditorAction is null && !(nextProps.EditorAction is null))
			{
				element.EditorAction += nextProps.EditorAction;
			}
		}
	}
}
