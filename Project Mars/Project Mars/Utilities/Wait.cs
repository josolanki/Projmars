using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace Project_Mars.Utilities
{
    public class Wait
    {
        public static void WaitforelementstoBeClickable(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (locator == "XPath")
            {

                 wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath( locatorValue)));
            }

            if (locator == "Id")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id( locatorValue)));
            }

            if (locator == "CssSelector")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }


        }
        public static void WaitforelementstoBeExit(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (locator == "XPath")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
            }

            if (locator == "Id")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
            }

            if (locator == "CssSelector")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
            }


        }
    }
}
