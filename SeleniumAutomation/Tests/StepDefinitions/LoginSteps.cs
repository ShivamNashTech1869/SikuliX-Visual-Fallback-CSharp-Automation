using OpenQA.Selenium;
using MyNamespace.PageObjects;
using TechTalk.SpecFlow;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace MyNamespace.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver driver;
        private readonly LoginPage loginPage;


        public LoginSteps(IWebDriver driver)
        {
            this.driver = driver;
            loginPage = new LoginPage(driver);
        }

        [Given(@"I open the login page")]
        public void GivenIOpenTheLoginPage()
        {
            driver.Navigate().GoToUrl("https://courses.ultimateqa.com/users/sign_in");
        }

        [When(@"I enter valid username and password")]
        public void WhenIEnterValidUsernameAndPassword()
        {
            loginPage.EnterUsername("testuser@gamil.com");
            loginPage.EnterPassword("test@123");
        }

        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            loginPage.ClickLogin();
        }

        [Then(@"I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
           ClassicAssert.IsTrue(loginPage.IsLoginSuccessful(), "Login was not successful.");
        }
    }
}
