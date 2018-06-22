using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using SharpReact.Android;
using SharpReact.Core;
using SharpReact.Core.Properties;
using SharpReact.Support.v7.AppCompat.Props;
using System;
using System.Linq;
using System.Threading.Tasks;
using Props = SharpReact.Android.Props;

namespace SharpReact.Droid.Sample
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
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
            var activities = new(string Name, Type Activity)[] 
            {
                ("Simple", typeof(SimpleActivity)),
                ("List", typeof(ListActivity))
            };
            return new Props.LinearLayout
            {
                LayoutParameters = Props.LinearLayout.MatchX.MatchY(),
                Orientation = Orientation.Vertical,
                AddViews = activities.Select(a =>
                    new AppCompatButton
                    {
                        LayoutParameters = Props.LinearLayout.WrapX.WrapY().TopMargin(29).Gravity(GravityFlags.Center),
                        Text = a.Name,
                        Click = (s, e) =>
                        {
                            StartActivity(a.Activity);
                        }
                    })
            };
        }
    }
}

