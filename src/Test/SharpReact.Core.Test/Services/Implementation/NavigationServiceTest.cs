using NUnit.Framework;
using SharpReact.Core.Services.Implementation;

namespace SharpReact.Core.Test.Services.Implementation
{
    public class NavigationServiceTest
    {
        protected NavigationService target;

        [SetUp]
        public  void Setup()
        {
            target = new NavigationService();
        }

        [TestFixture]
        public class Back: NavigationServiceTest
        {
            [Test]
            public void WhenStackIsEmpty_BackReturnsFalse()
            {
                bool actual = target.Back();

                Assert.That(actual, Is.False);
            }
        }
    }
}
