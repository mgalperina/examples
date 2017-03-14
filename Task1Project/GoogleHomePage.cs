using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Project
{
    public class GoogleHomePage
    {
        private readonly IWebDriver _driver;
        private const string PageUri = @"http://google.com";

        public GoogleHomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement _searchField;

        [FindsBy(How = How.Id, Using = "_fZl")]
        private IWebElement _searchButton;

        public static GoogleHomePage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PageUri);

            return new GoogleHomePage(driver);
        }

        public string SearchField
        {
            set
            {
                _searchField.SendKeys(value);
            }
        }
        
        public void ClickSearch()
        {
            _searchButton.Click();
        }


    }
}
