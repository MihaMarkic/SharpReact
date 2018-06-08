using SharpReact.Core;
using System;
using Elements = SharpReact.Core.MockUI.Test.Elements;
using Props = SharpReact.Core.MockUI.Test.Props;
using RoutingProps = SharpReact.Core.MockUI.Routing.Test.Props;
using Components = SharpReact.Core.MockUI.Test.Components;
using NUnit.Framework;
using SharpReact.Core.Test;
using SharpReact.Core.Properties;
using SharpReact.Core.MockUI.Routing.Test.Navigation;

namespace SharpReact.Routing.Test
{
    public class SharpRendererRoutingTest
    {
        protected SharpRenderer<Elements.ContentControl, Elements.UIElement> renderer;
        protected Elements.ContentControl rootElement;
        [SetUp]
        public void SetUp()
        {
            rootElement = new Elements.ContentControl();
            // need to reset counters per test, otherwise they will accumulate.
            SharpReact.Core.MockUI.Test.Components.SharpWpfComponentTestCounter.ResetCounter();
        }

        protected SharpRenderer<Elements.ContentControl, Elements.UIElement> CreateRenderer(Func<SharpProp> createTree)
        {
            return new MockUIRenderer(createTree, rootElement);
        }
        public class Render : SharpRendererRoutingTest
        {
            [TestFixture]
            public class SampleConfiguration: Render
            {
                protected Props.Router root;
                protected Props.HomeRoute homeRoute;
                protected Props.TypeRoute<FirstPageNavigationArgs> firstPageRoute;
                protected Props.TypeRoute<SecondPageNavigationArgs> secondPageRoute;
                SharpProp CreateTree()
                {
                    homeRoute = new Props.HomeRoute { Content = new RoutingProps.FirstPage() };
                    firstPageRoute = new Props.TypeRoute<FirstPageNavigationArgs> { Content = new RoutingProps.FirstPage() };
                    secondPageRoute = new Props.TypeRoute<SecondPageNavigationArgs> { Content = new RoutingProps.SecondPage() };
                    root = new Props.Router
                    {
                        Children =
                        {
                            homeRoute,
                            firstPageRoute,
                            secondPageRoute
                        }
                    };
                    return root;
                }
                [SetUp]
                public new void SetUp()
                {
                    renderer = CreateRenderer(CreateTree);
                }
                [Test]
                public void WhenDefault_HomeRouteIsGenerated()
                {
                    renderer.Render(NewState.Empty);

                    Assert.That(root.Generated, Is.TypeOf<Props.HomeRoute>());
                }
                [Test]
                public void WhenDefault_FirstPageComponentIsPresent()
                {
                    renderer.Render(NewState.Empty);

                    Assert.That(homeRoute.Content.Component, Is.Not.Null);
                }
                [Test]
                public void WhenDefault_SecondPageComponentIsNotCreated()
                {
                    renderer.Render(NewState.Empty);
                    
                    Assert.That(secondPageRoute.Content.Component, Is.Null);
                }
                [Test]
                public void WhenNavigatingToSecondPage_SecondPageRouteIsGenerated()
                {
                    renderer.Render(NewState.Empty);
                    ReactServices.Navigation.NavigateTo(new SecondPageNavigationArgs());

                    Assert.That(root.Generated, Is.SameAs(secondPageRoute));
                }
            }
        }
    }
}
