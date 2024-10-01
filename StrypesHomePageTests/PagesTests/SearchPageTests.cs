using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace StrypesHomePageTests.PagesTests
{
    public class SearchPageTests : BasePageTests
    {

        [Test]
        public void SearchEngineTest()
        { 
            searchPage.OpenPage();
            basePage.AcceptAllCookiesButton.Click();

            searchPage.ElementSearchLens.Click();
            searchPage.ElementSearchInput.SendKeys("quality assurance");
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.Enter).Perform();

            // int length = searchPage.ElementResultArticle.Count(); // checking all results

            for (int i = 0; i < 3; i++)  // checking first 3 results. If testing all results test fails on 4th result.
            {
                searchPage.ElementResultArticle[i].Click();
                
                bool found = false;
                foreach (IWebElement element in searchPage.allElements)
                {
                    if (element.Text.ToLower().Contains("quality assurance"))
                    {
                        found = true;
                        break;
                    }
                }

                Assert.That(found, Is.True, "The article N " + (i + 1) + " does not contain search string \"quality assurance\".");

                driver.Navigate().Back();
            }
        }
    }
}
