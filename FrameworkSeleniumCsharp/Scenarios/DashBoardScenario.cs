using FrameworkSeleniumCsharp.Pages;

namespace FrameworkSeleniumCsharp.Scenarios
{
   public class DashBoardScenario
    {
        
        public DashBoardScenario()
        {
            homePage = new HomePage();
        }
        public HomePage homePage;

        public void TestScenario()
        {
            homePage.ClickOnDashBoardButton();
        }
    }
}
