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

            searchPage.ElementSearchInput.Click();
            searchPage.ElementSearchInput.SendKeys("Quality Assurance");
            searchPage.ElementSearchButton.Click();

            var elementResultArticle = searchPage.ElementResultArticle[0];
            Actions actions = new Actions(driver);
            actions.MoveToElement(elementResultArticle).Perform();

            searchPage.ElementResultArticle[0].Click();

            Assert.That(searchPage.ElementResultArticleHeading.Text, Does.Contain("Quality Assurance"), "There is no artical that meets search criteria.");
        }
    }
}
