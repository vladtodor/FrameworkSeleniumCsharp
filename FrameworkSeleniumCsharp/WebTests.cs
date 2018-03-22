﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace FrameworkSeleniumCsharp
{
    [TestFixture]
    public class WebTests
    {
        [Test]
        public void Login()
        {
            //IWebDriver driverF = new ChromeDriver("C:/GitHub/FrameworkSeleniumCsharp/FrameworkSeleniumCsharp/bin\Debug");
            IWebDriver driverF = new FirefoxDriver("C:/GitHub/FrameworkSeleniumCsharp/FrameworkSeleniumCsharp/bin/Debug");
            driverF.Navigate().GoToUrl("https://www.google.ro");
            driverF.FindElement(By.Id("lst-ib")).SendKeys("Test");
            driverF.FindElement(By.XPath("//input[@name='btnK']")).Click();
            driverF.Close();            
        }
    }
}
