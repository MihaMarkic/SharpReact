using SharpReact.Core;

namespace SharpReact.Routing.Props
{
    public class HomeRoute : Route<Components.HomeRoute>
    {
        public override bool IsMatch()
        {
            return ReactServices.Navigation.Current == null;
        }
    }
}
