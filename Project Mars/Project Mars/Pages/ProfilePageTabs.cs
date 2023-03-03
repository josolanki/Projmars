using OpenQA.Selenium;
using Project_Mars.Utilities;


namespace Project_Mars.Pages 
{
    public class ProfilePageTabs : CommonDriver
    {
        public void LanguageTab()
        {
            Thread.Sleep(1500);
            //profile page
            // IWebElement profilePg = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            // profilePg.Click();

            //Find Language tab and click
            IWebElement languageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageButton.Click();
            Thread.Sleep(1500);
        }
        public void SkillTab() 
        {
            // Find Skill tab and click
            IWebElement skillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillButton.Click();
            Thread.Sleep(1500);
        }
        public void CertificationTab() 
        {
            //Find Certification Tab and click
            IWebElement certificationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationButton.Click();
            Thread.Sleep(1500);
        }
    }
}
