using NUnit.Framework;

namespace SharpReact.Core.Test
{
    public class ReactParamTest
    {
        [TestFixture]
        public class EqualityEquals: ReactParamTest
        {
            [Test]
            public void WhenBothNull_ReturnsTrue()
            {
                ReactParam<int>? a = null;
                ReactParam<int>? b = null;

                Assert.That(a.Equals(b), Is.True);
            }
            [Test]
            public void WhenSecondIsNull_ReturnsFalse()
            {
                ReactParam<int>? a = new ReactParam<int>();
                ReactParam<int>? b = null;

                Assert.That(a.Equals(b), Is.False);
            }
            [Test]
            public void WhenFirstIsNull_ReturnsFalse()
            {
                ReactParam<int>? a = null;
                ReactParam<int>? b = new ReactParam<int>();

                Assert.That(a.Equals(b), Is.False);
            }
            [Test]
            public void WhenValuesAreEqual_ReturnsTrue()
            {
                ReactParam<int> a = new ReactParam<int> { Value = 1 };
                ReactParam<int> b = new ReactParam<int> { Value = 1 };

                Assert.That(a.Equals(b), Is.True);
            }
            [Test]
            public void WhenValuesAreNotEqual_ReturnsFalse()
            {
                ReactParam<int> a = new ReactParam<int> { Value = 1 };
                ReactParam<int> b = new ReactParam<int> { Value = 2 };

                Assert.That(a.Equals(b), Is.False);
            }
            [Test]
            public void WhenValuesImplicitAndAreEqual_ReturnsTrue()
            {
                ReactParam<int>? a = 1;
                ReactParam<int>? b = 1;

                Assert.That(a.Equals(b), Is.True);
            }
            [Test]
            public void WhenValuesImplicitAndAreNotEqual_ReturnsFalse()
            {
                ReactParam<int> a = 1;
                ReactParam<int> b = 2;

                Assert.That(a.Equals(b), Is.False);
            }
            [Test]
            public void WhenClassTypeAndBothNull_ReturnsTrue()
            {
                ReactParam<object>? a = null;
                ReactParam<object>? b = null;

                Assert.That(a.Equals(b), Is.True);
            }
            [Test]
            public void WhenClassTypeAndSecondIsNull_ReturnsFalse()
            {
                ReactParam<object>? a = new ReactParam<int>();
                ReactParam<object>? b = null;

                Assert.That(a.Equals(b), Is.False);
            }
            [Test]
            public void WhenClassTypeAndFirstIsNull_ReturnsFalse()
            {
                ReactParam<object>? a = null;
                ReactParam<object>? b = new ReactParam<int>();

                Assert.That(a.Equals(b), Is.False);
            }
        }
        [TestFixture]
        public class EqualOperator: ReactParamTest
        {
            [Test]
            public void WhenBothReactParamAndEqual_ReturnsTrue()
            {
                ReactParam<int> a = 1;
                ReactParam<int> b = 1;

                Assert.That(a == b, Is.True);
            }
            [Test]
            public void WhenBothReactParamNullableAndEqual_ReturnsTrue()
            {
                ReactParam<int>? a = 1;
                ReactParam<int>? b = 1;

                Assert.That(a == b, Is.True);
            }
            [Test]
            public void WhenBothReactParamAndNotEqual_ReturnsFalse()
            {
                ReactParam<int> a = 1;
                ReactParam<int> b = 2;

                Assert.That(a == b, Is.False);
            }
            [Test]
            public void WhenSecondIsNull_ReturnsFalse()
            {
                ReactParam<int>? a = 1;
                ReactParam<int>? b = null;

                Assert.That(a == b, Is.False);
            }
            [Test]
            public void WhenFirstIsNull_ReturnsFalse()
            {
                ReactParam<int>? a = null;
                ReactParam<int>? b = 1;

                Assert.That(a == b, Is.False);
            }
            [Test]
            public void WhenFirstIsParamAndOtherIsSameValue_ReturnsTrue()
            {
                ReactParam<int> a = 1;
                int b = 1;

                Assert.That(a == b, Is.True);
            }
            [Test]
            public void WhenSecondIsParamAndFirstIsSameValue_ReturnsTrue()
            {
                int a = 1;
                ReactParam<int> b = 1;

                Assert.That(a == b, Is.True);
            }
        }
        [TestFixture]
        public class NotEqualOperator : ReactParamTest
        {
            [Test]
            public void WhenBothReactParamAndEqual_ReturnsFalse()
            {
                ReactParam<int> a = 1;
                ReactParam<int> b = 1;

                Assert.That(a != b, Is.False);
            }
            [Test]
            public void WhenBothReactParamNullableAndEqual_ReturnsFalse()
            {
                ReactParam<int>? a = 1;
                ReactParam<int>? b = 1;

                Assert.That(a != b, Is.False);
            }
            [Test]
            public void WhenBothReactParamAndNotEqual_ReturnsTrue()
            {
                ReactParam<int> a = 1;
                ReactParam<int> b = 2;

                Assert.That(a != b, Is.True);
            }
            [Test]
            public void WhenSecondIsNull_ReturnsTrue()
            {
                ReactParam<int>? a = 1;
                ReactParam<int>? b = null;

                Assert.That(a != b, Is.True);
            }
            [Test]
            public void WhenFirstIsNull_ReturnsTrue()
            {
                ReactParam<int>? a = null;
                ReactParam<int>? b = 1;

                Assert.That(a != b, Is.True);
            }
        }
    }
}
