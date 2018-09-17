using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace MSTestProject_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new FirefoxDriver(".");
            driver.Navigate().GoToUrl("https://yandex.by");
            Thread.Sleep(10000);
            driver.Close();
            Assert.IsTrue(true, "Test failed.");
        }
    }
}
