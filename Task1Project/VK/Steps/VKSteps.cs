using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Task1Project
{
    [Binding]
    public class VKSteps
    {
        private IWebDriver _driver;
        private VKHomePage _vkHomePage;
        private PasswordRetrievalPage _passwordRetrievalPage;

        public VKSteps()
        {
            _driver = (IWebDriver)ScenarioContext.Current["driver"];
            _vkHomePage = new VKHomePage(_driver);
            _passwordRetrievalPage = new PasswordRetrievalPage(_driver);
        }

        [When(@"I click (.*) link")]
        public void WhenIClickLink(string p0)
        {
           
            _vkHomePage.ClickForgotPassword();
        }

        [Then(@"I should see (.*) name of the page")]
        public void ThenIShouldSeeNameOfThePage(string retrievePasswordName)
        {         
            _passwordRetrievalPage.FindPasswordRetrievalText(retrievePasswordName);
        }



    }
}
