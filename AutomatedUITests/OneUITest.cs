using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace UnitTest
{
    public class OneUITest : IDisposable
    {
        private readonly IWebDriver _driver;

        public OneUITest()
        {
            _driver = new ChromeDriver();
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }


        [Fact]
        public void Navigation()
        {
            _driver.Navigate().GoToUrl("https://localhost:44314/");
            Assert.Equal("The Best Coffee Subscription - One", _driver.Title);

            _driver.Navigate()
                .GoToUrl("https://localhost:44314/Coffees");
            Assert.Equal("Shop - One", _driver.Title);

            _driver.Navigate()
                .GoToUrl("https://localhost:44314/Home/About");
            Assert.Equal("About - One", _driver.Title);

            Dispose();
        }

        [Fact]
        public void CreateNewCoffee()
        {
            _driver.Navigate()
                .GoToUrl("https://localhost:44314/Coffees/Create");
            _driver.FindElement(By.Id("Name"))
                .SendKeys("Emporium");
            _driver.FindElement(By.Id("Price"))
                .SendKeys("14");
            _driver.FindElement(By.Id("Weight"))
                .SendKeys("14");
            _driver.FindElement(By.Id("Description"))
                .SendKeys("Emporium Coffee");
            _driver.FindElement(By.Id("RoastLevel"))
                .SendKeys("Medium");
            _driver.FindElement(By.Id("Taste"))
                .SendKeys("Earthy");
            _driver.FindElement(By.Id("Img"))
                .SendKeys("emporium.png");
            _driver.FindElement(By.Id("create"))
                .Click();
            var errorMessage = _driver.FindElement(By.Id("Roast")).Text;
            Assert.Equal("The value '' is invalid.", errorMessage);
            Dispose();
        }

    }
}