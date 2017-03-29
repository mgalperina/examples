using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;
using System.Threading;

namespace Task1Project
{
    public class PasswordRetrievalPage
    {
        private readonly IWebDriver _driver;
        public PasswordRetrievalPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='forgot_panel']/h2/div/div[3]/div")]
        public IWebElement _retrievePasswordPageTitle;

        public void FindPasswordRetrievalText(string retrievePasswordName)
        {
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());
            _driver.FindElement(By.CssSelector("div.ui_crumb"));
  
       }

        public string GetRetrievePasswordTitle()
        {
            return _retrievePasswordPageTitle.Text;
        }



    }
}
