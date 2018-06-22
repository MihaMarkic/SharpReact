
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using SharpReact.Android;
using SharpReact.Core;
using SharpReact.Core.Properties;
using SharpReact.Support.v7.AppCompat.Props;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Props = SharpReact.Android.Props;

namespace SharpReact.Droid.Sample
{
    [Activity(Label = "@string/list")]
    public class ListActivity : AppCompatActivity
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
                i => (ISharpProp)new AppCompatTextView
                {
                    LayoutParameters = Props.LinearLayout.MatchX.WrapY(),
                    Text = $"Tubo {counter * 100 + i}"
                })
                .ToList();
        }

        SharpProp CreateTree()
        {
            return new Props.LinearLayout
            {
                LayoutParameters = Props.LinearLayout.MatchX.MatchY(),
                Orientation = Orientation.Vertical,
                Views =
                {
                    new Props.ListView
                    {
                        LayoutParameters = Props.LinearLayout.MatchX.MatchY().Weight(1),
                        Items = CreateListItem()
                    },
                    new Props.LinearLayout
                    {
                         LayoutParameters = Props.LinearLayout.MatchX.WrapY(),
                        Orientation = Orientation.Horizontal,
                        Views =
                        {
                            new AppCompatButton
                            {
                                LayoutParameters = Props.LinearLayout.WrapX.WrapY(),
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