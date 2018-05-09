using SharpReact.Core;
using SharpReact.Core.Services.Abstract;

namespace SharpReact.Routing.Props
{
    public class TypeRoute<T> : Route<Components.TypeRoute<T>>
        where T: NavigationArgs
    {
        public T Args { get; set; }
        public override bool IsMatch()
        {
            return ReactServices.Navigation.Current?.GetType() == typeof(T);
        }
    }
}
