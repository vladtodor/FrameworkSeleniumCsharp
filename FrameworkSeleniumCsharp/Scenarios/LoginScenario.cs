using FrameworkSeleniumCsharp.Pages;
namespace FrameworkSeleniumCsharp.Scenarios

{
    public class LoginScenario
    {
        public LoginPage _login;

        public void LoginS()
        {
            _login = new LoginPage();
            Login();            
        }

        private void Login()
        {                
            _login.Login("manageronlinehr@gmail.com", "Test123$");                
        }
    }
}
