using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MyNamespace.PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }


        // Locators
        private By UsernameField => By.Id("user[email]");
        private By PasswordField => By.Id("user[password]");
        private By LoginButton => By.XPath("//button[normalize-space(text())='Sign in']");
        private By SuccessMessageLocator = By.XPath("//p[text()='Signed in successfully.']");


        // Methods
        public void EnterUsername(string username)
        {
            driver.FindElement(UsernameField).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(PasswordField).SendKeys(password);
        }

        public void ClickLogin()
        {
            driver.FindElement(LoginButton).Click();
        }

        public void Login(string username, string password)
        {
            driver.FindElement(UsernameField).SendKeys(username);
            driver.FindElement(PasswordField).SendKeys(password);
            driver.FindElement(LoginButton).Click();
        }


        public bool IsLoginSuccessful()
        {
            try
            {
                IWebElement SuccessMessageElement = wait.Until(ExpectedConditions.ElementIsVisible(SuccessMessageLocator));
                return SuccessMessageElement.Displayed;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

    }
}
