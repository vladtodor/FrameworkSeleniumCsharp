using FrameworkSeleniumCsharp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkSeleniumCsharp.Scenarios
{
 public class LogOutScenario
    {
        public LoginPage _login;
        public BasePage _base;

        public void LogOutS()
        {
            _login = new LoginPage();
            LogOut();
        }

        public void CloseBrowserPage()
        {
            _base = new BasePage();
            _base.CloseBrowser();
        }

        private void LogOut()
        {
            _login.Logout();
        }
    }

}
