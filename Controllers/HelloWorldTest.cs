using NUnit.Framework;

namespace todo_raw.Controllers{
    [TestFixture]
    public class HelloWorldTest{
        [Test]
        public void ItShouldBeTrueWhenHelloEqualHello(){
            Assert.AreEqual("Hello", "Hello");
        }
    }
}