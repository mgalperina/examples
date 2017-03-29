using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace Task1Project
{
    [Binding]
    public class GoogleSteps
    {
        private IWebDriver _driver;
        private GoogleHomePage _googleHomePage;
        private ResultsPage _resultsPage;
      
        public GoogleSteps()
        {
            _driver = (IWebDriver)ScenarioContext.Current["driver"];
            _googleHomePage = new GoogleHomePage(_driver);
            _resultsPage = new ResultsPage(_driver);
        }
        
        [When(@"I type (.*) into a search field")]
        public void WhenITypeIntoASearchField(string searchField)
        {
            _googleHomePage.SearchField = searchField;
            _googleHomePage.ClickSearch();
        }
        
        [Then(@"I should see (.*) link in results")]
        public void ThenIShouldSeeLinkInResults(string firstResult)
        {
            _resultsPage.FindText(firstResult);
        }

        [When(@"I upload (.*) picture into a search field")]
        public void WhenIUploadPictureIntoASearchField(string pathToPicture)
        {
            _googleHomePage.ClickImagesToUpload();
            _googleHomePage.UploadImage(pathToPicture);
        }

        [Then(@"I should see (.*) word in results")]
        public void ThenIShouldSeeWordInResults(string firstResult)
        {
            _resultsPage.FindText(firstResult); 
        }

        [Then(@"I should see (.*) image in results")]
        public void ThenIShouldSeeImageInResults(string p0)
        {
            Assert.IsTrue(_driver.FindElement(By.XPath("//div[4]/div/div/div/div/div/div/a/g-img/img")).Displayed);
        }

        [When(@"I change the language to (.*)")]
        public void WhenIChangeTheLanguageTo(string language)
        {
            _googleHomePage.ClickMaoriLanguageButton(language);
        }

        [Then(@"I should see (.*) link")]
        public void ThenIShouldSeeLink(string p0)
        {
            Assert.IsTrue(_driver.FindElement(By.LinkText("Atahanga")).Displayed);
        }

        [Then(@"I should see (.*) text in results")]
        public void ThenIShouldSeeTextInResults(string wikiResult)
        {
            _resultsPage.FindText(wikiResult);
        }



    }
}
