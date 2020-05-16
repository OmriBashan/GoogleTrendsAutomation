using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace GoogleTrendsExcersie
{
    public class RelatedQueriesComponent :ComponentUser
    {
        private IEnumerable<IWebElement> interstElement => ParentElement.FindElements(By.CssSelector(".label-text"));
        public RelatedQueriesComponent(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public RelatedQueriesComponent FindRelatedQueriesOverDistrict()
        {
            IList<IWebElement> all = Driver.FindElements(By.CssSelector(".label-text"));
            List<string> lst = new List<string>(all.Count);
            foreach (IWebElement element in all)
            {

                if (element.Text.Contains("query"))
                {
                lst.Add(element.Text);      
                }
            }

            if (lst.Count.Equals(0))
            {
                return null;
            }

            return this;
        }
    }
}