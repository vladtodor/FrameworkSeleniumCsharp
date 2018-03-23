using OpenQA.Selenium;

namespace FrameworkSeleniumCsharp.Pages
{
   public class LoginPage: BasePage
    {
        public LoginPage()
        {
            Driver = Instance.Driver;
        }
        
        public void Login(string username, string password)
        {            
            Driver.Navigate().GoToUrl("http://www.google.ro");
            Driver.FindElement(By.XPath("//a[@href='/Account/Login']")).Click();
            Driver.FindElement(By.Id("Email")).SendKeys(username);
            Driver.FindElement(By.Id("Password")).SendKeys(password);
            Driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            
        }

        public void Logout()
        {
            Driver.FindElement(By.XPath("//a[@class='dropdown-toggle']")).Click();
            Driver.FindElement(By.XPath("//*[@id='logoutForm']/a")).Click();            
        }
    }
}
