using OpenQA.Selenium;
using Project_Mars.Utilities;


namespace Project_Mars.Pages
{
    public class CertificationPage: CommonDriver
    {
        public void AddCertification(IWebDriver driver)
        {

            //Click on Certification
            IWebElement clickCertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            clickCertification.Click();

            // Click on Add new button
            IWebElement addNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNew.Click();

            // Add Certficatons
            IWebElement addCertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            addCertification.SendKeys("B.A");
            Thread.Sleep(500);

            // Add Certification from
            IWebElement certificationFrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certificationFrom.SendKeys("Adobe");
            Thread.Sleep(500);

            // Add year
            IWebElement addYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            addYear.Click();

            //Add year level
            IWebElement certificationYear = driver.FindElement(By.XPath("//option[@value='2003' and text() ='2003']"));
            certificationYear.Click();
            Thread.Sleep(1000);

            // Add new record
            IWebElement newCertificationRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            newCertificationRecord.Click();
            //Thread.Sleep(500);

            Wait.WaitforelementstoBeClickable(driver, "XPath", "\"//*[@id=\\\"account-profile-section\\\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]\"", 5);
        }
        public string GetCertification() 
        {
            IWebElement certificationFrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            return certificationFrom.Text;
        }
        public string GetYear() 
        {
            IWebElement addYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            return addYear.Text;    
        }
        public string GetLevel() 
        {
            IWebElement certificationYear = driver.FindElement(By.XPath("//option[@value='2003' and text() ='2003']"));
            return certificationYear.Text;
        }

    }
}
