using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Project_Mars.Pages;
using SeleniumExtras.WaitHelpers;
namespace Project_Mars.Utilities
{
    public class Wait
    {
        public static void WaitforelementstoBeClickable(IWebDriver driver, string locator, string locatorValue, int seconds) 
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (locator == "XPath")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("locatorvalue")));
            }

            if (locator == "Id")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("locatorvalue")));
            }

            if (locator == "CssSelector")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("locatorvalue")));
            }


        }
    }
}
