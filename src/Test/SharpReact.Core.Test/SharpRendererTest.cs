using NUnit.Framework;
using Elements = SharpReact.Core.MockUI.Test.Elements;
using Props = SharpReact.Core.MockUI.Test.Props;
using Components = SharpReact.Core.MockUI.Test.Components;
using System;
using SharpReact.Core.Properties;
using SharpReact.Core.MockUI.Test;
using System.Collections.Generic;
using SharpReact.Core.Exceptions;

namespace SharpReact.Core.Test
{
    public class SharpRendererTest
    {
        protected SharpRenderer<Elements.ContentControl, Elements.UIElement> renderer;
        protected Elements.ContentControl root;

        [SetUp]
        public void SetUp()
        {
            root = new Elements.ContentControl();
            // need to reset counters per test, otherwise they will accumulate.
            Components.SharpWpfComponentTestCounter.ResetCounter();
        }

        protected SharpRenderer<Elements.ContentControl, Elements.UIElement> CreateRenderer(Func<SharpProp> createTree)
        {
            return new MockUIRenderer(createTree, root);
        }
        public class Render : SharpRendererTest
        {
            [TestFixture]
            public class SingleButton : Render
            {
                [Test]
                public void NullRender_ResultsInNullElement()
                {
                    renderer = CreateRenderer(() => null);
                    renderer.Render(NewState.Empty);

                    var actual = root.Content;

                    Assert.That(actual, Is.Null);
                }
                [Test]
                public void InitialSimpleButtonRender_CreatesButtonElement()
                {
                    renderer = CreateRenderer(() => new Props.Button());
                    renderer.Render(NewState.Empty);

                    var actual = root.Content;

                    Assert.That(actual, Is.TypeOf<Elements.Button>());
                }
                [Test]
                public void InitialSimpleButtonRender_ComponentEventsAreCalledInCorrectOrder()
                {
                    var button = new Props.Button();
                    renderer = CreateRenderer(() => button);
                    renderer.Render(NewState.Empty);

                    var component = button.Component;

                    Assert.That(component.WillMountCounter(), Is.EqualTo(new int[] { 0 }));
                    Assert.That(component.DidMountCounter(), Is.EqualTo(new int[] { 1 }));
                    Assert.That(component.ShouldUpdateCounter(), Is.EqualTo(new int[] { 2 }));
                    Assert.That(component.WillReceivePropsCounter(), Is.EqualTo(new int[] { 3 }));
                    Assert.That(component.DidUpdateCounter(), Is.EqualTo(new int[] { 4 }));
                }
                [Test]
                public void AfterSecondPassThatYieldsNull_OriginalElementIsRemoved()
                {
                    int pass = 0;
                    renderer = CreateRenderer(() =>
                        {
                            return pass == 0 ? new Props.Button() : null;
                        }
                    );

                    renderer.Render(NewState.Empty);
                    pass++;
                    renderer.Render(NewState.Empty);

                    var actual = root.Content;

                    Assert.That(actual, Is.Null);
                }
                [Test]
                public void AfterSecondPassForSimpleButtonThatYieldsNull_WillUnmountWasCalledOnce()
                {
                    int pass = 0;
                    var button = new Props.Button();
                    renderer = CreateRenderer(() =>
                        {
                            return pass == 0 ? button : null;
                        }
                    );

                    renderer.Render(NewState.Empty);
                    pass++;
                    renderer.Render(NewState.Empty);

                    var component = button.Component;

                    Assert.That(component.WillUnmountCounter().Count, Is.EqualTo(1));
                }
                [Test]
                public void WhenClickIsImplemented_ItRaisesEvent()
                {
                    bool clicked = false;
                    renderer = CreateRenderer(() => new Props.Button { Click = (s, e) => clicked = true });
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.Button)root.Content;
                    actual.OnClick(EventArgs.Empty);

                    Assert.That(clicked, Is.True);
                }
                [Test]
                public void WhenClickIsImplementedAndRemovedOnSecondPass_ItDoesNotRaiseEvent()
                {
                    int pass = 0;
                    bool clicked = false;
                    renderer = CreateRenderer(() => new Props.Button
                    {
                        Click = pass == 0 ? (s, e) => clicked = true : (EventHandler)null
                    });
                    renderer.Render(NewState.Empty);
                    pass++;
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.Button)root.Content;
                    actual.OnClick(EventArgs.Empty);

                    Assert.That(clicked, Is.False);
                }
            }
            [TestFixture]
            public class SingleButtonWithText : Render
            {
                [Test]
                public void AfterSecondPassForButtonThatYieldsNull_ContentWillUnmountWasCalledOnce()
                {
                    int pass = 0;
                    var button = new Props.Button { Content = new Props.TextBlock() };
                    renderer = CreateRenderer(() =>
                    {
                        return pass == 0 ? button : null;
                    }
                    );

                    renderer.Render(NewState.Empty);
                    pass++;
                    renderer.Render(NewState.Empty);

                    var component = (Components.ISharpWpfTestComponent)button.Content.Component;

                    Assert.That(component.WillUnmountCounter.Count, Is.EqualTo(1));
                }

                [Test]
                public void ButtonWithTextBlockRender_CreatesButtonElementWithTextBlock()
                {
                    renderer = CreateRenderer(() => new Props.Button { Content = new Props.TextBlock() });
                    renderer.Render(NewState.Empty);

                    var actual = root.Content;

                    Assert.That(actual, Is.TypeOf<Elements.Button>());
                    var button = (Elements.Button)actual;
                    Assert.That(button.Content, Is.TypeOf<Elements.TextBlock>());
                }
                [Test]
                public void ButtonWithTextBlockRender_AllEventsAreCalledInCorrectOrder()
                {
                    var textBlock = new Props.TextBlock();
                    var button = new Props.Button { Content = textBlock };
                    renderer = CreateRenderer(() => button);
                    renderer.Render(NewState.Empty);

                    var textBlockComponent = textBlock.Component;
                    var buttonComponent = button.Component;

                    int index = 0;
                    Assert.That(buttonComponent.WillMountCounter(), Is.EqualTo(new int[] { index++ }));
                    Assert.That(buttonComponent.DidMountCounter(), Is.EqualTo(new int[] { index++ }));
                    Assert.That(buttonComponent.ShouldUpdateCounter(), Is.EqualTo(new int[] { index++ }));
                    Assert.That(buttonComponent.WillReceivePropsCounter(), Is.EqualTo(new int[] { index++ }));
                    Assert.That(textBlockComponent.WillMountCounter(), Is.EqualTo(new int[] { index++ }));
                    Assert.That(textBlockComponent.DidMountCounter(), Is.EqualTo(new int[] { index++ }));
                    Assert.That(textBlockComponent.ShouldUpdateCounter(), Is.EqualTo(new int[] { index++ }));
                    Assert.That(textBlockComponent.WillReceivePropsCounter(), Is.EqualTo(new int[] { index++ }));
                    Assert.That(textBlockComponent.DidUpdateCounter(), Is.EqualTo(new int[] { index++ }));
                    Assert.That(buttonComponent.DidUpdateCounter(), Is.EqualTo(new int[] { index++ }));
                }
                [Test]
                public void WhenClickIsImplemented_ItRaisesEvent()
                {
                    bool clicked = false;
                    renderer = CreateRenderer(() => new Props.Button { Content = new Props.TextBlock(), Click = (s, e) => clicked = true });
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.Button)root.Content;
                    actual.OnClick(EventArgs.Empty);

                    Assert.That(clicked, Is.True);
                }
                [Test]
                public void WhenClickIsImplementedAndRemovedOnSecondPass_ItDoesNotRaiseEvent()
                {
                    int pass = 0;
                    bool clicked = false;
                    renderer = CreateRenderer(() => new Props.Button
                    {
                        Content = new Props.TextBlock(),
                        Click = pass == 0 ? (s, e) => clicked = true : (EventHandler)null
                    });
                    renderer.Render(NewState.Empty);
                    pass++;
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.Button)root.Content;
                    actual.OnClick(EventArgs.Empty);

                    Assert.That(clicked, Is.False);
                }
            }
            [TestFixture]
            public class Panel: Render
            {
                [Test]
                public void WhenNoChildren_NoChildrenAreCreated()
                {
                    renderer = CreateRenderer(() => new Props.StackPanel());
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.StackPanel)root.Content;

                    Assert.That(actual.Children.Count, Is.Zero);
                }
                [Test]
                public void WhenHasASingleChild_ChildIsCreated()
                {
                    var content = new Props.StackPanel { Children = { new Props.TextBlock() } };
                    renderer = CreateRenderer(() => new Props.StackPanel { Children = { new Props.TextBlock() } });
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.StackPanel)root.Content;

                    Assert.That(actual.Children.Count, Is.EqualTo(1));
                    Assert.That(actual.Children[0], Is.TypeOf<Elements.TextBlock>());
                }
                [Test]
                public void WhenHasASingleChildAndRecreatedSameType_ChildIsRetained()
                {
                    renderer = CreateRenderer(() => new Props.StackPanel { Children = { new Props.TextBlock() } });
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.StackPanel)root.Content;

                    Assert.That(actual.Children.Count, Is.EqualTo(1));
                    Assert.That(actual.Children[0], Is.TypeOf<Elements.TextBlock>());
                }
                [Test]
                public void WhenHasASingleChildAndRecreatedSameType_ElementIsRetained()
                {
                    renderer = CreateRenderer(() => new Props.StackPanel { Children = { new Props.TextBlock() } });
                    renderer.Render(NewState.Empty);
                    var original = ((Elements.StackPanel)root.Content).Children[0];
                    renderer.Render(NewState.Empty);

                    var actual = ((Elements.StackPanel)root.Content).Children[0];

                    Assert.That(actual, Is.SameAs(original));
                }
                [Test]
                public void WhenHasASingleChildAndRecreatedDifferentType_SingleElementChild()
                {
                    int pass = 0;
                    renderer = CreateRenderer(() =>
                        new Props.StackPanel
                        {
                            Children =
                            {
                                pass == 0 ? (Props.UIElement)new Props.TextBlock() : new Props.Button()
                            }
                        }
                    );
                    renderer.Render(NewState.Empty);
                    pass++;
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.StackPanel)root.Content;

                    Assert.That(actual.Children.Count, Is.EqualTo(1));
                }
                [Test]
                public void WhenHasASingleChildAndRecreatedToButton_ElementChildIsButton()
                {
                    int pass = 0;
                    renderer = CreateRenderer(() =>
                        new Props.StackPanel
                        {
                            Children =
                            {
                                pass == 0 ? (Props.UIElement)new Props.TextBlock() : new Props.Button()
                            }
                        }
                    );
                    renderer.Render(NewState.Empty);
                    pass++;
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.StackPanel)root.Content;
                    var child = actual.Children[0];

                    Assert.That(child, Is.TypeOf<Elements.Button>());
                }
                [Test]
                public void WhenMoreThanOneChild_KeysAreRequired()
                {
                    renderer = CreateRenderer(() => new Props.StackPanel { Children = { new Props.TextBlock(), new Props.Button() } });
                    Assert.Throws<DuplicateKeyException>(() => renderer.Render(NewState.Empty));
                }
                [Test]
                public void WhenMoreThanOneChildAndKeysAreUnique_NoExceptionIsThrown()
                {
                    renderer = CreateRenderer(() => new Props.StackPanel { Children = { new Props.TextBlock { Key = 0 }, new Props.Button { Key = 1 } } });
                    renderer.Render(NewState.Empty);
                }
                [Test]
                public void WhenTwoChildren_TwoElementsAreInList()
                {
                    renderer = CreateRenderer(() => new Props.StackPanel { Children = { new Props.TextBlock { Key = 0 }, new Props.Button { Key = 1 } } });
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.StackPanel)root.Content;

                    Assert.That(actual.Children.Count, Is.EqualTo(2));
                }
                [Test]
                public void WhenTwoChildren_ElementsAreInCorrectOrder()
                {
                    renderer = CreateRenderer(() => new Props.StackPanel { Children = { new Props.TextBlock { Key = 0 }, new Props.Button { Key = 1 } } });
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.StackPanel)root.Content;

                    Assert.That(actual.Children[0], Is.TypeOf<Elements.TextBlock>());
                    Assert.That(actual.Children[1], Is.TypeOf<Elements.Button>());
                }
                [Test]
                public void WhenTwoChildrenAndFirstIsRemoved_SingleElementRemains()
                {
                    int pass = 0;
                    var panel1 = new Props.StackPanel
                    {
                        Children = { new Props.TextBlock { Key = 0 }, new Props.Button { Key = 1 } }
                    };
                    var panel2 = new Props.StackPanel
                    {
                        Children = { new Props.TextBlock { Key = 0 } }
                    };
                    renderer = CreateRenderer(() => pass == 0 ? panel1: panel2);
                    renderer.Render(NewState.Empty);
                    pass++;
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.StackPanel)root.Content;

                    Assert.That(actual.Children.Count, Is.EqualTo(1));
                }
                [Test]
                public void WhenTwoChildrenAndFirstIsRemoved_RemainingElementIsTextBlock()
                {
                    int pass = 0;
                    var panel1 = new Props.StackPanel
                    {
                        Children = { new Props.TextBlock { Key = 0 }, new Props.Button { Key = 1 } }
                    };
                    var panel2 = new Props.StackPanel
                    {
                        Children = { new Props.TextBlock { Key = 0 } }
                    };
                    renderer = CreateRenderer(() => pass == 0 ? panel1 : panel2);
                    renderer.Render(NewState.Empty);
                    pass++;
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.StackPanel)root.Content;

                    Assert.That(actual.Children[0], Is.TypeOf<Elements.TextBlock>());
                }
                [Test]
                public void WhenTwoChildrenAndSecondIsRemoved_SingleElementRemains()
                {
                    int pass = 0;
                    var panel1 = new Props.StackPanel
                    {
                        Children = { new Props.TextBlock { Key = 0 }, new Props.Button { Key = 1 } }
                    };
                    var panel2 = new Props.StackPanel
                    {
                        Children = { new Props.Button { Key = 1 } }
                    };
                    renderer = CreateRenderer(() => pass == 0 ? panel1 : panel2);
                    renderer.Render(NewState.Empty);
                    pass++;
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.StackPanel)root.Content;

                    Assert.That(actual.Children.Count, Is.EqualTo(1));
                }
                [Test]
                public void WhenTwoChildrenAndSecondIsRemoved_RemainingElementIsButton()
                {
                    int pass = 0;
                    var panel1 = new Props.StackPanel
                    {
                        Children = { new Props.TextBlock { Key = 0 }, new Props.Button { Key = 1 } }
                    };
                    var panel2 = new Props.StackPanel
                    {
                        Children = { new Props.Button { Key = 1 } }
                    };
                    renderer = CreateRenderer(() => pass == 0 ? panel1 : panel2);
                    renderer.Render(NewState.Empty);
                    pass++;
                    renderer.Render(NewState.Empty);

                    var actual = (Elements.StackPanel)root.Content;

                    Assert.That(actual.Children[0], Is.TypeOf<Elements.Button>());
                }
            }
        }
        [TestFixture]
        public class CheckPropertyListKeys: SharpRendererTest
        {
            [Test]
            public void WhenPropsIsNull_DoesNotThrow()
            {
                MockUIRenderer.CheckPropertyListKeys(null, "sourceProperty", "sourceType");
            }
            [Test]
            public void WhenSinglePropWithKey_DoesNotThrow()
            {
                MockUIRenderer.CheckPropertyListKeys(new List<ISharpProp> { new Props.TextBlock { Key = 1 } }, 
                    "sourceProperty", "sourceType");
            }
            [Test]
            public void WhenTwoPropsWithDifferentKeys_DoesNotThrow()
            {
                MockUIRenderer.CheckPropertyListKeys(new List<ISharpProp> { new Props.TextBlock { Key = 1 }, new Props.TextBlock { Key = 2 } }, 
                    "sourceProperty", "sourceType");
            }
            [Test]
            public void WhenTwoPropsWithEqualKeys_DoesThrowException()
            {
                Assert.Throws<DuplicateKeyException>(() =>
                    MockUIRenderer.CheckPropertyListKeys(new List<ISharpProp> { new Props.TextBlock { Key = 1 }, new Props.TextBlock { Key = 1 } },
                        "sourceProperty", "sourceType")
                );
            }
        }
        [TestFixture]
        public class VisitAllCollection: SharpRendererTest
        {
            [SetUp]
            public new void SetUp()
            {
                // no need to render anything for these tests
                renderer = CreateRenderer(() => null);
            }
            [Test]
            public void WhenPreviousIsNullAndNextIsNull_ElementsListIsEmpty()
            {
                var elements = new List<Elements.UIElement>();
                renderer.VisitAllCollection(0, new NewState(), previous: null, next: null, elements, "sourceProperty", "sourceType");

                Assert.That(elements.Count, Is.Zero);
            }
            [Test]
            public void WhenNullPreviousAndSingleNext_OneElementIsInList()
            {
                var elements = new List<Elements.UIElement>();
                renderer.VisitAllCollection(0, new NewState(), previous: null, next: new List<ISharpProp> { new Props.TextBlock() }, elements, 
                    "sourceProperty", "sourceType");

                Assert.That(elements.Count, Is.EqualTo(1));
            }
            [Test]
            public void WhenNullPreviousAndSingleTextBlock_ElementIsTextBlock()
            {
                var elements = new List<Elements.UIElement>();
                renderer.VisitAllCollection(0, new NewState(), previous: null, next: new List<ISharpProp> { new Props.TextBlock() }, elements,
                    "sourceProperty", "sourceType");

                Assert.That(elements[0], Is.TypeOf<Elements.TextBlock>());
            }
            [Test]
            public void WhenTextBlockPreviousAndNullNext_NoElementsInList()
            {
                var elements = new List<Elements.UIElement> { new Elements.TextBlock() };
                renderer.VisitAllCollection(0, new NewState(), previous: new List<ISharpProp> { new Props.TextBlock() }, next: null, elements,
                    "sourceProperty", "sourceType");

                Assert.That(elements.Count, Is.Zero);
            }
            [Test]
            public void WhenTextBlockPreviousAndNextIsButton_OneElementInList()
            {
                var textBlockProp = new Props.TextBlock();
                // makes sure component and element are created
                textBlockProp.Init();
                textBlockProp.Component.WillMount();
                var element = (Elements.UIElement)textBlockProp.Component.Element;

                var elements = new List<Elements.UIElement> { element };
                renderer.VisitAllCollection(0, new NewState(), 
                    previous: new List<ISharpProp> { textBlockProp }, 
                    next: new List<ISharpProp> { new Props.Button() }, 
                    elements,
                    "sourceProperty", "sourceType");

                Assert.That(elements.Count, Is.EqualTo(1));
            }
        }
    }
}
