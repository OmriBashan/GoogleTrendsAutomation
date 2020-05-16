using System.Configuration;
using GoogleTrendsExcersie;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class HomePage : DriverUser
    {
        public HeaderComponent HeaderComponent => new HeaderComponent(Driver, Driver.FindElement(By.CssSelector(".home-page-header-container")));
        


        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void GoToPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get(0));
        }
    }
}