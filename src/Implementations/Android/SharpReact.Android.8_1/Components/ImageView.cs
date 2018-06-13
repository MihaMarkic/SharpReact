using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ImageView<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.ImageView
		where TElement : global::Android.Widget.ImageView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ImageView(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.BaselineAlignBottom.HasValue)
			{
				Element.BaselineAlignBottom = nextProps.BaselineAlignBottom.Value.Value;
			}
			if (nextProps.CropToPadding.HasValue)
			{
				Element.CropToPadding = nextProps.CropToPadding.Value.Value;
			}
			if (nextProps.ImageAlpha.HasValue)
			{
				Element.ImageAlpha = nextProps.ImageAlpha.Value.Value;
			}
			if (nextProps.ImageMatrix.HasValue)
			{
				Element.ImageMatrix = nextProps.ImageMatrix.Value.Value;
			}
			if (nextProps.ImageTintList.HasValue)
			{
				Element.ImageTintList = nextProps.ImageTintList.Value.Value;
			}
			if (nextProps.ImageTintMode.HasValue)
			{
				Element.ImageTintMode = nextProps.ImageTintMode.Value.Value;
			}
		}
	}
}
