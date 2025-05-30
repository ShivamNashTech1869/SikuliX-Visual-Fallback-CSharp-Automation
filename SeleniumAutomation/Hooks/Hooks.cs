using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using BoDi;
using MyNamespace.Base;

[Binding]
public class Hooks
{
    private readonly IObjectContainer objectContainer;
    private IWebDriver driver= null!;

    public Hooks(IObjectContainer objectContainer)
    {
        this.objectContainer = objectContainer;
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        objectContainer.RegisterInstanceAs<IWebDriver>(driver);
    }

    [AfterScenario]
    public void AfterScenario()
    {
        driver.Quit();
    }
}
