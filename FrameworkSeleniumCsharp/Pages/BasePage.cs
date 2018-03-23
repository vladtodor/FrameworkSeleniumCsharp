using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace FrameworkSeleniumCsharp.Pages
{
    public enum BrowerType
    {
        Chrome,
        Firefox,
        Edge
    }
    
    public class BasePage: Base
    {
        private BrowerType _browserType;

        private static BasePage instance = null;
        private static readonly object Padlock = new object();

        public static BasePage Instance
        {
            get
            {
                lock (Padlock)
                {
                    if (instance == null)
                    {
                        instance = new BasePage();
                        instance.InitializeTest();
                    }
                        return instance;
                }
            }
        }

        public void InitializeTest()
        {
            var browserType = TestContext.Parameters.Get("Browser", "Chrome");
            _browserType = (BrowerType)Enum.Parse(typeof(BrowerType), browserType);
            ChooseDriverInstance(_browserType);
        }

        private void ChooseDriverInstance(BrowerType browserType)
        {
            if (browserType == BrowerType.Chrome)
                Driver = new ChromeDriver("C:/GitHub/FrameworkSeleniumCsharp/FrameworkSeleniumCsharp/bin/Debug");
            else if (browserType == BrowerType.Firefox)
            {
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                service.HideCommandPromptWindow = true;
                service.SuppressInitialDiagnosticInformation = true;
                Driver = new FirefoxDriver(service);
            }
            else if (browserType == BrowerType.Edge)
            {
                Driver = new EdgeDriver();
            }
            Instance.Driver = Driver;
        }   
        
        public void CloseBrowser()
        {
            Instance.Driver.Quit();
        }
    }
}
