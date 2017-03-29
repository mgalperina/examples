using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Task1Project
{
    [Binding]
    public class TaxCalculatorSteps
    {
        private IWebDriver _driver;
        private TaxHomePage _taxHomePage;

        public TaxCalculatorSteps()
        {
            _driver = (IWebDriver)ScenarioContext.Current["driver"];
            _taxHomePage = new TaxHomePage(_driver);
        }


        [When(@"I type (.*) into a salary field")]
        public void WhenITypeIntoASalaryField(double salary)
        {
            _taxHomePage.InputSalary(salary);
        }

        [Then(@"I should see (.*) for each salary rate")]
        public void ThenIShouldSee_ForEachSalaryRate(string expectedMonthlySalary)
        {
            Assert.AreEqual(expectedMonthlySalary, _taxHomePage.GetMonthlySalary());
        }

    }
}
