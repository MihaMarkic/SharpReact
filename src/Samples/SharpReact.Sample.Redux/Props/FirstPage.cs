using SharpReact.Core.Properties;

namespace SharpReact.Sample.Redux.Props
{
    public class FirstPage : SharpCompositeProp<Components.FirstPage>
    {
        public string Title { get; set; }
        public int Number { get; set; }
    }
}
