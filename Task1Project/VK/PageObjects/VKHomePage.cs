using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace Task1Project
{
    public class VKHomePage
    {

        private readonly IWebDriver _driver;
        WebDriverWait wait;
        
        public VKHomePage(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "index_forgot")]
        public IWebElement _forgotPasswordButton;


        public void ClickForgotPassword()
        {
            _forgotPasswordButton.Click();
        }
    }
}
