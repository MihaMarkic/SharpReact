namespace SharpReact.Core
{
    public interface ISharpComponent: ISharpStatefulComponent
    {
        void AssignElement(object element);
    }
}
