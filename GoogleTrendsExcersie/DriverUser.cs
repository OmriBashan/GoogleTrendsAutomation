using OpenQA.Selenium;

namespace Infrastructure
{
    public class DriverUser
    {
        protected IWebDriver Driver { get; }

        public DriverUser(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}