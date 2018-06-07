using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Routing.Props
{
    public class Router : SharpCompositeProp<Components.Router>
    { 
        public List<IRoute> Children { get; set; } = new List<IRoute>();
        protected override void UnmountComponent()
        {
            // TODO think of better approach to have both strong typed routes and collection generator
            UnmountComponents(Children);
            base.UnmountComponent();
        }
    }
}
