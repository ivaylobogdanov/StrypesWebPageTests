

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
            driver = new ChromeDriver();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
