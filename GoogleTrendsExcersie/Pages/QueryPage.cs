using GoogleTrendsExcersie;
using Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Infrastructure
{
    public class QueryPage : DriverUser
    {
        public QueryHeader Header => new QueryHeader(Driver, Driver.FindElement(By.CssSelector(".compare-pickers-wrapper")));

        public RegionComponenent Region => new RegionComponenent(Driver, Driver.FindElement(By.CssSelector(".progress-label")));

        public RelatedQueriesComponent RelatedQueries => new RelatedQueriesComponent (Driver, Driver.FindElement(By.CssSelector(".progress-label")));



        public QueryPage(IWebDriver driver) : base(driver)
        {
        }
    }
}