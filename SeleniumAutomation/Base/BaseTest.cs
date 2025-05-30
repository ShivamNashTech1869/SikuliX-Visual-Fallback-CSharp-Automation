using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class BaseTest
{
    public static IWebDriver InitializeWebDriver()
    {
        var driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        return driver;
    }

    public static void CloseWebDriver(IWebDriver driver)
    {
        driver.Quit();
    }

    public static string TakeScreenshot(IWebDriver driver, string scenarioTitle)
    {
        Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
        string filePath = $"Screenshots/{scenarioTitle}_{DateTime.Now:yyyyMMdd_HHmmss}.png";
        ss.SaveAsFile(filePath);
        return filePath;
    }
}
