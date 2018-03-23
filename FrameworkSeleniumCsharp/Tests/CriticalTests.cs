using NUnit.Framework;
using FrameworkSeleniumCsharp.Scenarios;

namespace FrameworkSeleniumCsharp.Tests
{
[TestFixture]
  public  class CriticalTests
    {
        public LoginScenario _loginTest;
        public DashBoardScenario _dashboard;
        public LogOutScenario _logOut;


        [Test]
        public void TestLogInApplication()
        {   
            //login in app
            _loginTest = new LoginScenario();            
            _loginTest.LoginS();

            //close browser
            _logOut = new LogOutScenario();
            _logOut.CloseBrowserPage();

        }

        [Test]
        public void TestCheckIfDashboardIsPresent()
        {    
            //login in app
            _loginTest = new LoginScenario();
            _loginTest.LoginS();

            //scenario test
            _dashboard = new DashBoardScenario();
            _dashboard.TestScenario();

            //close browser
            _logOut = new LogOutScenario();
            _logOut.CloseBrowserPage();
        }

        [Test]
        public void TestLogOut()
        {   
            //login in app
            _loginTest = new LoginScenario();
            _loginTest.LoginS();

            //scenario test
            _logOut = new LogOutScenario();
            _logOut.LogOutS();

            //close browser
            _logOut = new LogOutScenario();
            _logOut.CloseBrowserPage();
        }
    }
}
