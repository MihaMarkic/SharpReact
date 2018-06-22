using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using SharpReact.Android;
using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Threading.Tasks;
using Props = SharpReact.Android.Props;

namespace SharpReact.Droid.Sample
{
    [Activity(Label = "@string/simple")]
    public class SimpleActivity : AppCompatActivity
    {
        AndroidTreeRenderer<SimpleActivity> renderer;
        int clicked = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            renderer = new AndroidTreeRenderer<SimpleActivity>(
                context: this,
                CreateTree,
                this,
                attachChildToRoot: (r, c) => r.SetContentView(c),
                detachChildFromRoot: (r, c) => r.SetContentView(null),
                TaskScheduler.FromCurrentSynchronizationContext()
                );
            renderer.Render(NewState.Empty);
        }

        SharpProp CreateTree()
        {
            return new Props.LinearLayout
            {
                LayoutParameters = Props.LinearLayout.MatchX.MatchY(),
                Orientation = Orientation.Vertical,
                Views =
                {
                    new Props.TextView
                    {
                        LayoutParameters = Props.LinearLayout.MatchX.WrapY(),
                        TextAlignment = TextAlignment.Center,
                        Text = "Sharp React!",
                    },
                    new Props.TextView
                    {
                        LayoutParameters = Props.LinearLayout.MatchX.WrapY().TopMargin(29),
                        TextAlignment = TextAlignment.Center,
                        Text = $"Clicked {clicked}"
                    },
                    new Props.Button
                    {
                        LayoutParameters = Props.LinearLayout.WrapX.WrapY().TopMargin(29).Gravity(GravityFlags.Center),
                        Text = "Click me",
                        Click = (s, e) =>
                        {
                            clicked++;
                            renderer.Render(NewState.Empty);
                        }
                    }
                }
            };
        }
    }
}

