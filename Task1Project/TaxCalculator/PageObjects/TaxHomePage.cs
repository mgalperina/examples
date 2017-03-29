using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace Task1Project
{
    public class TaxHomePage
    {

        private readonly IWebDriver _driver;
        WebDriverWait wait;

        public TaxHomePage(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "income")]
        public IWebElement _salaryField;

        [FindsBy(How = How.XPath, Using = ".//a[@onclick='approximateNZ()']")]
        public IWebElement _calculateButton;

        [FindsBy(How = How.CssSelector, Using = "div[id='monthTakeHomePay']")]
        public IWebElement _monthlySalaryField;


        public void InputSalary(double salary)
        {
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _salaryField.Click();
            _salaryField.SendKeys(salary.ToString());
            _calculateButton.Click();
        }

        public string GetMonthlySalary()
        {
           return _monthlySalaryField.Text;
        }


    }
}
