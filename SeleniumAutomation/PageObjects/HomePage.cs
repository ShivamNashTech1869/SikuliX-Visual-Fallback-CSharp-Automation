using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MyNamespace.PageObjects;
public class HomePage
{
    private readonly IWebDriver driver;
    private readonly WebDriverWait wait;
    private IWebElement SearchBox => driver.FindElement(By.Name("q"));

    public HomePage(IWebDriver driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
    }

    public void EnterSearchText(string text)
    {
        wait.Until(ExpectedConditions.ElementIsVisible((By)SearchBox));
        SearchBox.SendKeys(text);
    }

    public void SubmitSearch()
    {
        SearchBox.Submit();
    }

    public bool IsSearchResultDisplayed(string expectedText)
        {
            var result = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h3[contains(text(),'" + expectedText + "')]")));
            return result.Displayed;
        }
}
