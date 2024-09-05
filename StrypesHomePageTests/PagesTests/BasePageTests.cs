using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using StrypesHomePageTests.Pages;

namespace StrypesHomePageTests.PagesTests
{
    public class BasePageTests
    {

        protected IWebDriver driver;
        public BasePage basePage;
        public CareersPage careersPage;
        public SearchPage searchPage;
        public ContactPage contactPage;

        [OneTimeSetUp]

        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("headless");
            options.AddArguments("no-sandbox");
            options.AddArguments("disable-dev-shm-usage");
            options.AddArguments("disable-gpu");
            options.AddArguments("window-size=1920x1080");
            options.AddArguments("disable-extensions");
            options.AddArguments("remote-debugging-port=9222");
            options.AddArguments("--disable-search-engine-choice-screen");


            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            basePage = new BasePage(driver);
            careersPage = new CareersPage(driver);
            searchPage = new SearchPage(driver);
            contactPage = new ContactPage(driver);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
