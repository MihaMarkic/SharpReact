using SharpReact.Core.Properties;

namespace SharpReact.Sample.Redux.Props
{
    public class Header : SharpCompositeProp<Components.Header>
    {
        public string PageTitle { get; set; }
    }
}
