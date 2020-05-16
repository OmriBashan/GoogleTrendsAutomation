using Infrastructure;
using OpenQA.Selenium;

namespace GoogleTrendsExcersie
{
    public class HeaderComponent : ComponentUser
    {
        private IWebElement searchElement => ParentElement.FindElement(By.CssSelector("input[type=search]"));

        public HeaderComponent(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public QueryPage Search(string text)
        {
            searchElement.SendKeys(text);
            searchElement.SendKeys(Keys.Enter);
            return new QueryPage(Driver);
        }
    }
}