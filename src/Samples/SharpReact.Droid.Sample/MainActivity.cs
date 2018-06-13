using Android.App;
using Android.OS;
using Android.Support.V7.App;
using SharpReact.Android;
using SharpReact.Android.Props;
using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Threading.Tasks;
using Widget = Android.Widget;
using Views = Android.Views;

namespace SharpReact.Droid.Sample
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        AndroidTreeRenderer<MainActivity> renderer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            renderer = new AndroidTreeRenderer<MainActivity>(
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
            return new TextView
            {
                LayoutParameters = new Widget.LinearLayout.LayoutParams(
                    Views.ViewGroup.LayoutParams.MatchParent, 
                    Views.ViewGroup.LayoutParams.MatchParent),
                TextAlignment = Views.TextAlignment.Center,
                Text = "Sharp React!"
            };
        }
    }
}

