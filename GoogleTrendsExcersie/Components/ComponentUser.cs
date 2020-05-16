using System;
using System.Collections.Generic;
using Infrastructure;
using OpenQA.Selenium;

namespace GoogleTrendsExcersie
{
    public class ComponentUser : DriverUser
    {
        protected IWebElement ParentElement { get;}
        public ComponentUser(IWebDriver driver, IWebElement element) : base(driver)
        {
            ParentElement = element;
        }
    }
}
