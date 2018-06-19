using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class ImageView<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.ImageView
		where TElement : global::Android.Widget.ImageView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ImageView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateImageViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignImageViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignImageViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateImageViewWithInstanceProperties(element, null, props);
		}
		static void UpdateImageViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.BaselineAlignBottom.HasValue)
			{
				element.BaselineAlignBottom = nextProps.BaselineAlignBottom.Value.Value;
			}
			if (nextProps.CropToPadding.HasValue)
			{
				element.CropToPadding = nextProps.CropToPadding.Value.Value;
			}
			if (nextProps.ImageAlpha.HasValue)
			{
				element.ImageAlpha = nextProps.ImageAlpha.Value.Value;
			}
			if (nextProps.ImageMatrix.HasValue)
			{
				element.ImageMatrix = nextProps.ImageMatrix.Value.Value;
			}
			if (nextProps.ImageTintList.HasValue)
			{
				element.ImageTintList = nextProps.ImageTintList.Value.Value;
			}
			if (nextProps.ImageTintMode.HasValue)
			{
				element.ImageTintMode = nextProps.ImageTintMode.Value.Value;
			}
		}
	}
}
