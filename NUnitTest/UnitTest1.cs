using FluentAssertions;
using System.Configuration;
using Extensions;
using GoogleTrendsExcersie;
using Infrastructure;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Compatibility;

namespace NUnitTest
{
    [SetUpFixture]
    public class Tests
    {
        private IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            var a = ConfigurationManager.AppSettings;

           driver = new ChromeDriver(ConfigurationManager.AppSettings["URL"]);
           driver = new ChromeDriver("E:\\SeleniumDrivers");
           driver.Navigate().GoToUrl("https://trends.google.com/trends/?geo=US");
            driver.Manage().Window.Maximize();
        }

        [Test]
        [Description("Check if district have realted queries")]
        public void ChromeSanity()
        {
            HomePage homePage = new HomePage(driver);

            homePage
                .SearchQuery("query")
                .Header.PickCountry("israel");
            QueryPage queryPage = new QueryPage(driver);
            QueryPageExtensions.InterstByLocation(queryPage, "Tel Aviv District");
            Assert.IsNotNull(QueryPageExtensions.FindRelatedLocation(queryPage),"this district have no realted queries");
        }
    }
}