namespace SharpReact.Core
{
    public interface ISharpComponent: ISharpStatefulComponent
    {
        void AssignProperties(object nextProps);
    }
}
