using MvcContrib.TestHelper;
using NUnit.Framework;
using why_am_i_a_developer.Controllers;

namespace why_am_i_a_developer.unit.Controllers
{
    [TestFixture]
    public class HelloControllerTest
    {
        [Test]
        public void ShouldReturnStringHello()
        {
            var controller = new HelloController();
            var result = controller.Index();
            Assert.AreEqual("", result.AssertViewRendered().ViewName);
        }
    }
}
