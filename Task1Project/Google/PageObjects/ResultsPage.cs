using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Project
{
    public class ResultsPage
    {
        private readonly IWebDriver _driver;             
        public ResultsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void FindText(string text)
        {
          _driver.FindElement(By.XPath($"//*[text()[contains(.,'{text}')]]"));
    
        }



    }
}
