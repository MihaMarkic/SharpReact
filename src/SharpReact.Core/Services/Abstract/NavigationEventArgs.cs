using System;

namespace SharpReact.Core.Services.Abstract
{
    public class NavigationEventArgs: EventArgs
    {
        public NavigationArgs Args { get; }
        public NavigationEventArgs(NavigationArgs args)
        {
            Args = args;
        }
    }
}
