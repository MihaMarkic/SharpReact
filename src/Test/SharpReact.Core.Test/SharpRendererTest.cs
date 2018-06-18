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
            Components.SharpTestComponentTestCounter.ResetCounter();
        }

        protected SharpRenderer<Elements.ContentControl, Elements.UIElement> CreateRenderer(Func<SharpProp> createTree)
        {
            return new MockUIRenderer(createTree, root);
        }
        public class CompareProperties: SharpRendererTest
        {
            [SetUp]
            public new void SetUp()
            {
                renderer = CreateRenderer(null);
            }
            [TestFixture]
            public class ComparingUIElement: CompareProperties
            {
                [Test]
                public void WhenBothAreNull_ReturnsTrue()
                {
                    var actual = renderer.CompareProperties<Props.UIElement>(null, null);

                    Assert.That(actual, Is.True);
                }
                [Test]
                public void WhenFirstHasValueAndOtherIsNull_ReturnsFalse()
                {
                    var actual = renderer.CompareProperties(new Props.UIElement(), null);

                    Assert.That(actual, Is.False);
                }
                [Test]
                public void WhenSecondHasValueAndOtherIsNull_ReturnsFalse()
                {
                    var actual = renderer.CompareProperties(null, new Props.UIElement());

                    Assert.That(actual, Is.False);
                }
                [Test]
                public void WhenBothAreCleanInstances_ReturnsTrue()
                {
                    var actual = renderer.CompareProperties(new Props.UIElement(), new Props.UIElement());

                    Assert.That(actual, Is.True);
                }
                [Test]
                public void WhenFirstHasPropertySetAndOtherDoesNot_ReturnsFalse()
                {
                    var actual = renderer.CompareProperties(new Props.UIElement { IsEnabled = true }, new Props.UIElement());

                    Assert.That(actual, Is.False);
                }
                [Test]
                public void WhenSecondHasPropertySetAndOtherDoesNot_ReturnsFalse()
                {
                    var actual = renderer.CompareProperties(new Props.UIElement(), new Props.UIElement { IsEnabled = true });

                    Assert.That(actual, Is.False);
                }
            }
            [TestFixture]
            public class ComparingButton : CompareProperties
            {
                [Test]
                public void WhenBothAreNull_ReturnsTrue()
                {
                    var actual = renderer.CompareProperties<Props.Button>(null, null);

                    Assert.That(actual, Is.True);
                }
                [Test]
                public void WhenFirstHasValueAndOtherIsNull_ReturnsFalse()
                {
                    var actual = renderer.CompareProperties(new Props.Button(), null);

                    Assert.That(actual, Is.False);
                }
                [Test]
                public void WhenSecondHasValueAndOtherIsNull_ReturnsFalse()
                {
                    var actual = renderer.CompareProperties(null, new Props.Button());

                    Assert.That(actual, Is.False);
                }
                [Test]
                public void WhenBothAreCleanInstances_ReturnsTrue()
                {
                    var actual = renderer.CompareProperties(new Props.Button(), new Props.Button());

                    Assert.That(actual, Is.True);
                }
                [Test]
                public void WhenFirstHasInheritedPropertySetAndOtherDoesNot_ReturnsFalse()
                {
                    var actual = renderer.CompareProperties(new Props.Button { IsEnabled = true }, new Props.Button());

                    Assert.That(actual, Is.False);
                }
                [Test]
                public void WhenSecondHasInheritedPropertySetAndOtherDoesNot_ReturnsFalse()
                {
                    var actual = renderer.CompareProperties(new Props.Button(), new Props.Button { IsEnabled = true });

                    Assert.That(actual, Is.False);
                }
            }
            [TestFixture]
            public class ComparingContentControl: CompareProperties
            {
                [Test]
                public void WhenBothHaveNoChildren_ReturnsTrue()
                {
                    var actual = renderer.CompareProperties(new Props.ContentControl(), new Props.ContentControl());

                    Assert.That(actual, Is.True);
                }
                [Test]
                public void WhenFirstHasChildrenAndOtherDoesNot_ReturnsFalse()
                {
                    var actual = renderer.CompareProperties(new Props.ContentControl {  Content = new Props.UIElement() }, new Props.ContentControl());

                    Assert.That(actual, Is.False);
                }
                [Test]
                public void WhenSecondHasChildrenAndOtherDoesNot_ReturnsFalse()
                {
                    var actual = renderer.CompareProperties(new Props.ContentControl(), new Props.ContentControl { Content = new Props.UIElement() });

                    Assert.That(actual, Is.False);
                }
            }
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
                [Test, Ignore("For now")]
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
            [TestFixture]
            public class SimpleComposite: Render
            {
                [Test]
                public void WhenRender_ElementIsTextBlock()
                {
                    renderer = CreateRenderer(() => new Props.SimpleComposite());
                    renderer.Render(NewState.Empty);

                    var actual = root.Content;

                    Assert.That(actual, Is.TypeOf<Elements.TextBlock>());
                }
                [Test]
                public void WhenRender_ComponentIsCreated()
                {
                    var props = new Props.SimpleComposite();
                    renderer = CreateRenderer(() => props);
                    renderer.Render(NewState.Empty);

                    Assert.That(props.Component, Is.Not.Null);
                }
            }
            [TestFixture]
            public class NestedComposite : Render
            {
                [Test]
                public void WhenRender_ElementIsTextBlock()
                {
                    renderer = CreateRenderer(() => new Props.NestedComposite());
                    renderer.Render(NewState.Empty);

                    var actual = root.Content;

                    Assert.That(actual, Is.TypeOf<Elements.TextBlock>());
                }
                [Test]
                public void WhenRender_RootComponentIsCreated()
                {
                    var props = new Props.NestedComposite();
                    renderer = CreateRenderer(() => props);
                    renderer.Render(NewState.Empty);

                    Assert.That(props.Component, Is.Not.Null);
                }
                [Test]
                public void WhenRender_GeneratedIsAssignedRenderedProperty()
                {
                    var props = new Props.NestedComposite();
                    renderer = CreateRenderer(() => props);
                    renderer.Render(NewState.Empty);

                    Assert.That(props.Generated, Is.TypeOf<Props.SimpleComposite>());
                }
                [Test]
                public void WhenRender_NestedComponentIsCreated()
                {
                    var props = new Props.NestedComposite();
                    renderer = CreateRenderer(() => props);
                    renderer.Render(NewState.Empty);

                    Assert.That(props.Generated.Component, Is.Not.Null);
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
            [Test, Ignore("For now")]
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
                var actual = renderer.VisitAllCollection(0, new NewState(), previous: null, next: null, "sourceProperty", "sourceType");

                Assert.That(actual.Length, Is.Zero);
            }
            [Test]
            public void WhenNullPreviousAndSingleNext_OneElementIsInList()
            {
                var actual = renderer.VisitAllCollection(0, new NewState(), previous: null, next: new List<ISharpProp> { new Props.TextBlock() }, 
                    "sourceProperty", "sourceType");

                Assert.That(actual.Length, Is.EqualTo(1));
            }
            [Test]
            public void WhenNullPreviousAndSingleTextBlock_ElementIsTextBlock()
            {
                var actual = renderer.VisitAllCollection(0, new NewState(), previous: null, next: new List<ISharpProp> { new Props.TextBlock() }, 
                    "sourceProperty", "sourceType");

                Assert.That(actual[0], Is.TypeOf<Elements.TextBlock>());
            }
            [Test]
            public void WhenTextBlockPreviousAndNullNext_NoElementsInList()
            {
                var actual = renderer.VisitAllCollection(0, new NewState(), previous: new List<ISharpProp> { new Props.TextBlock() }, next: null,
                    "sourceProperty", "sourceType");

                Assert.That(actual.Length, Is.Zero);
            }
            [Test]
            public void WhenTextBlockPreviousAndNextIsButton_OneElementInList()
            {
                var textBlockProp = new Props.TextBlock();
                // makes sure component and element are created
                textBlockProp.Init();
                textBlockProp.Component.WillMount();
                var element = (Elements.UIElement)textBlockProp.Component.Element;

                //var elements = new List<Elements.UIElement> { element };
                var actual = renderer.VisitAllCollection(0, new NewState(), 
                    previous: new List<ISharpProp> { textBlockProp }, 
                    next: new List<ISharpProp> { new Props.Button() }, 
                    "sourceProperty", "sourceType");

                Assert.That(actual.Length, Is.EqualTo(1));
            }
        }
        [TestFixture]
        public class UpdateExistingElement: SharpRendererTest
        {
            [SetUp]
            public new void SetUp()
            {
                renderer = CreateRenderer(() => null);

            }
            [Test]
            public void WhenTextBlock_CreatesComponents()
            {
                var element = new Elements.TextBlock();
                var props = new Props.TextBlock();

                renderer.UpdateExistingElement(element, props);

                Assert.That(props.Component, Is.Not.Null);
            }
            [Test]
            public void WhenTextBlock_UpdatesProperties()
            {
                var element = new Elements.TextBlock();
                var props = new Props.TextBlock { Text = "test", IsEnabled = true, Focusable = true };

                renderer.UpdateExistingElement(element, props);

                Assert.That(element.Text, Is.EqualTo(props.Text));
                Assert.That(element.IsEnabled, Is.True);
                Assert.That(element.Focusable, Is.True);
            }
            [Test]
            public void WhenTextBlock_PreviousElementIsRemoved()
            {
                var element = new Elements.TextBlock();
                var props = new Props.TextBlock();
                renderer.UpdateExistingElement(element, props);

                renderer.UpdateExistingElement(new Elements.TextBlock(), props);

                Assert.That(props.Component.Element, Is.Not.SameAs(element));
            }
            [Test]
            public void WhenContentControl_CreatesComponents()
            {
                var element = new Elements.ContentControl { Content = new Elements.TextBlock() };
                var props = new Props.ContentControl { Content = new Props.TextBlock() };

                renderer.UpdateExistingElement(element, props);

                Assert.That(props.Component, Is.Not.Null);
                Assert.That(props.Content.Component, Is.Not.Null);
            }
            [Test]
            public void WhenContentControl_UpdatesProperties()
            {
                var element = new Elements.ContentControl { Content = new Elements.TextBlock() };
                var content = new Props.TextBlock { Text = "test", IsEnabled = true, Focusable = true };
                var props = new Props.ContentControl { Content = content };

                renderer.UpdateExistingElement(element, props);

                var actual = (Elements.TextBlock)element.Content;
                Assert.That(actual.Text, Is.EqualTo(content.Text));
                Assert.That(actual.IsEnabled, Is.True);
                Assert.That(actual.Focusable, Is.True);
            }
            [Test]
            public void WhenContentControl_PreviousElementsAreRemoved()
            {
                var element = new Elements.ContentControl { Content = new Elements.TextBlock() };
                var content = new Props.TextBlock { Text = "test", IsEnabled = true, Focusable = true };
                var props = new Props.ContentControl { Content = content };

                renderer.UpdateExistingElement(element, props);
                renderer.UpdateExistingElement(new Elements.ContentControl { Content = new Elements.TextBlock() }, props);

                var actual = (Elements.TextBlock)element.Content;
                Assert.That(props.Component.Element, Is.Not.SameAs(element));
                Assert.That(content.Component.Element, Is.Not.SameAs(element.Content));
            }
        }
    }
}
