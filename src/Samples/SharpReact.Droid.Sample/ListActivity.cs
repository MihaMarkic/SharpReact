
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using SharpReact.Android;
using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Props = SharpReact.Android.Props;

namespace SharpReact.Droid.Sample
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class ListActivity : Activity
    {
        AndroidTreeRenderer<ListActivity> renderer;
        int counter = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            renderer = new AndroidTreeRenderer<ListActivity>(
                context: this,
                CreateTree,
                this,
                attachChildToRoot: (r, c) => r.SetContentView(c),
                detachChildFromRoot: (r, c) => r.SetContentView(null),
                TaskScheduler.FromCurrentSynchronizationContext()
                );
            renderer.Render(NewState.Empty);
        }

        List<ISharpProp> CreateListItem()
        {
            return Enumerable.Range(0, 100).Select(
                i => (ISharpProp)new Props.TextView
                {
                    LayoutParameters = new LinearLayout.LayoutParams(
                                        ViewGroup.LayoutParams.MatchParent,
                                        ViewGroup.LayoutParams.WrapContent),
                    Text = $"Tubo {counter * 100 + i}"
                })
                .ToList();
        }

        SharpProp CreateTree()
        {
            return new Props.LinearLayout
            {
                LayoutParameters = new LinearLayout.LayoutParams(
                            ViewGroup.LayoutParams.MatchParent,
                            ViewGroup.LayoutParams.MatchParent),
                Orientation = Orientation.Vertical,
                Views =
                {
                    new Props.ListView
                    {
                        LayoutParameters = new LinearLayout.LayoutParams(
                                    ViewGroup.LayoutParams.MatchParent,
                                    ViewGroup.LayoutParams.MatchParent)
                        {
                            Weight = 1
                        },
                        Items = CreateListItem()
                    },
                    new Props.LinearLayout
                    {
                         LayoutParameters = new LinearLayout.LayoutParams(
                            ViewGroup.LayoutParams.MatchParent,
                            ViewGroup.LayoutParams.WrapContent),
                        Orientation = Orientation.Horizontal,
                        Views =
                        {
                            new Props.Button
                            {
                                LayoutParameters = new LinearLayout.LayoutParams(
                                    ViewGroup.LayoutParams.WrapContent,
                                    ViewGroup.LayoutParams.WrapContent),
                                Text = "Increase",
                                Click = (s, e) =>
                                {
                                    counter++;
                                    renderer.Render(NewState.Empty);
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}