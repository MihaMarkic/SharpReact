namespace SharpReact.Core
{
    public interface ISharpComponent: ISharpStatefulComponent
    {
        void AssignElement(object element);
        void AssignProperties(object nextProps);
    }
}
