using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using One.Controllers;
using One.Data;
using Microsoft.Extensions.Logging;

namespace One.Controllers.Tests
{

    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var mock = new Mock<ILogger<HomeController>>();
            ILogger<HomeController> logger = mock.Object;
            var controller = new HomeController(logger);

            // Act
            ViewResult res = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            var mock = new Mock<ILogger<HomeController>>();
            ILogger<HomeController> logger = mock.Object;
            var controller = new HomeController(logger);

            // Act
            ViewResult res = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(res);
        }


    }
}