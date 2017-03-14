using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;

namespace Task1Project
{
    [Binding]
    public class ScenariosTask1Steps
     {
        private IWebDriver _driver;
        private GoogleHomePage _googleHomePage;
        private ResultsPage _resultsPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new FirefoxDriver();
            _driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }

        [Given(@"I'm on Google Home page")]
        public void GivenIMOnGoogleHomePage()
        {
            _googleHomePage = GoogleHomePage.NavigateTo(_driver);
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
            _resultsPage = new ResultsPage(_driver);

            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
           
            //Assert.Equals(firstResult, _resultsPage.FirstResultText);
            _resultsPage.FindText(firstResult);
        }
    }
}
