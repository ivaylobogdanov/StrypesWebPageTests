

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace StrypesHomePageTests.PagesTests
{
    public class BaseTests
    {
        protected IWebDriver driver;

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

            driver = new ChromeDriver(options);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
