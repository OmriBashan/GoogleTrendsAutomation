using System;
using GoogleTrendsExcersie;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace Infrastructure
{
    public class QueryHeader : ComponentUser
    {
        public QueryHeader QuerySearchHeader => new QueryHeader(Driver, Driver.FindElement(By.CssSelector(".compare-pickers-wrapper")));
        private IWebElement countryElement => ParentElement.FindElement(By.CssSelector("input[type=search]"));
        private IWebElement clickElement => ParentElement.FindElement(By.CssSelector(".hierarchy-select"));
        public QueryHeader(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public QueryHeader PickCountry(string country)
        {
            clickElement.Click();
            countryElement.SendKeys(country);
            countryElement.Click();
            
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
           var a = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".hierarchy-picker-label")));
           Actions clickActions = new Actions(Driver);
           clickActions.MoveToElement(a);
           clickActions.Click();
            clickActions.Perform();
            
            
            //sendCountryElement.Click();
            return this;
        }

    }
}