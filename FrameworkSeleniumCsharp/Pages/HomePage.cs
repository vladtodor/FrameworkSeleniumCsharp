using OpenQA.Selenium;

namespace FrameworkSeleniumCsharp.Pages
{
  public  class HomePage:BasePage
    {
        public HomePage()
        {
            Driver = Instance.Driver;
        }

        public void ClickOnDashBoardButton()
        {
            Driver.FindElement(By.XPath("//a[@href='/Dashboard']")).Click();
        }
    }
}
