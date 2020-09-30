using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using One.Controllers;

namespace One.Controllers.Tests
{

    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod]
        public void HomeIndexView()
        {
            var controller = new HomeController();
            var res = controller.Index() as ViewResult;

            Assert.AreEqual("Jaewon Jeong", res.ViewName);
        }
    }
}