using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.Pages
{
    public class CertificationPage
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
            Thread.Sleep(500);

            //click on update
            IWebElement updateCertificate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
            updateCertificate.Click();
            Thread.Sleep(500);

            //clear CertificateTextBox and reenter Value
            IWebElement clearCertificateBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input"));
            clearCertificateBox.Clear();
            clearCertificateBox.SendKeys("Management");
            Thread.Sleep(500);

            //Successfully update new Certificate
            IWebElement newUpdate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            newUpdate.Click();

            ////Cancel update Certification
            IWebElement cancelUpdateCertificate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[2]"));
            cancelUpdateCertificate.Click();




        }
    }
}
