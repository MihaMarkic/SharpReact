using SharpReact.Core.Properties;

namespace SharpReact.Routing.Props
{
    public interface IRoute: ISharpProp
    {
        bool IsMatch();
    }
}
