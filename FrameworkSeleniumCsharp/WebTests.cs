using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace FrameworkSeleniumCsharp
{
    [TestFixture]
    public class WebTests
    {
        [Test]
        public void Login()
        {
            IWebDriver driverF = new ChromeDriver("C:/VisualStudioProjects/FrameworkSeleniumCsharp");
            driverF.Navigate().GoToUrl("https://www.google.ro");
            driverF.FindElement(By.Id("lst-ib")).SendKeys("Test");
            driverF.FindElement(By.XPath("//input[@name='btnK']")).Click();
            driverF.Close();            
        }
    }
}
