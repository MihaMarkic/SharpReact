using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Core
{
    public interface ISharpRenderer
    {
        void StateChanged(NewState newState);
        void Redraw();
    }
}
