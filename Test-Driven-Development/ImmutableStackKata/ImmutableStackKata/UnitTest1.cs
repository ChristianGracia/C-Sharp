using NUnit.Framework;

namespace ImmutableStackKata
{
    [TestFixture]
    public class ImmutableStackTests
    {
        [Test]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            var emptyStack = ImmutableStack<int>.Empty;
            Assert.IsTrue(emptyStack.IsEmpty);

        }


     
    }

}