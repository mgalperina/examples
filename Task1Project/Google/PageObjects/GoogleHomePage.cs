using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;


namespace Task1Project
{
    public class GoogleHomePage
    {
        private readonly IWebDriver _driver;
        private const string PageUri = @"http://google.com";

        WebDriverWait wait;
           

        public GoogleHomePage(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement _searchField;

        [FindsBy(How = How.Id, Using = "_fZl")]
        public IWebElement _searchButton;

        [FindsBy(How = How.LinkText, Using = "Images")]
        public IWebElement _imagesButton;

        [FindsBy(How = How.Id, Using = "qbi")]
        public IWebElement _uploadImageButton;

        [FindsBy(How = How.XPath, Using = ".//div[@id='qbug']/div/a")]
        public IWebElement _uploadFromPCButton;

        [FindsBy(How = How.Name, Using = "encoded_image")]
        public IWebElement _browsePCButton;

        [FindsBy(How = How.LinkText, Using = "Māori")]
        public IWebElement _maoriLanguageButton;


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

        public void ClickImagesToUpload()
        {
            _imagesButton.Click();
            wait.Until(driver => _uploadImageButton.Enabled && _uploadImageButton.Displayed);
            _uploadImageButton.Click();
            wait.Until(driver => _uploadFromPCButton.Displayed);
            _uploadFromPCButton.Click();
     
        }

        public void UploadImage(string pathToPicture)
        {
            _browsePCButton.SendKeys(pathToPicture);
        }

        public void ClickMaoriLanguageButton(string language)
        {
            _maoriLanguageButton.Click();
        }
    }
}
