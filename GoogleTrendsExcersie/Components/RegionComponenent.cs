using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace GoogleTrendsExcersie
{
    public class RegionComponenent : ComponentUser
    {
        private IEnumerable<IWebElement> interstElement => ParentElement.FindElements(By.CssSelector(".label-text"));
        public RegionComponenent(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }
        public RegionComponenent ByLocation(string location)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IList<IWebElement> all = Driver.FindElements(By.CssSelector(".label-text"));
            List<string> lst = new List<string>(all.Count);
            IWebElement ClickOnDistrict = null;
            foreach (IWebElement element in all)
            {
                lst.Add(element.Text);

                if (element.Text.Equals(location))
                {
                    ClickOnDistrict = element;
                }

            }
            ClickOnDistrict.Click();

            return this;
        }


    }
}
