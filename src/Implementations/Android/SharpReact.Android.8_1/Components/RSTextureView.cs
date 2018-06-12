using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class RSTextureView<TProps, TElement>: TextureView<TProps, TElement>
		where TProps : Props.RSTextureView
		where TElement : global::Android.Renderscripts.RSTextureView
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
