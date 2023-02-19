using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.Pages
{
    public class LanguagePage
    {
        public void AddLanguage(IWebDriver driver) 
        {
            //Click on add new button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();

            //Enter Language
            IWebElement languageTextBox = driver.FindElement(By.Name("name"));
            languageTextBox.SendKeys("Marathi");
            Thread.Sleep(500);

            //Enter Level
            IWebElement chooseLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseLanguageLevel.Click();
            Thread.Sleep(500);

            //Add level option
            IWebElement fluentOption = driver.FindElement(By.XPath("//option[@value='Fluent' and text() ='Fluent']"));
            fluentOption.Click();
            Thread.Sleep(500);

            //Click add language button
            IWebElement addLanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addLanguageButton.Click();
            Thread.Sleep(500);

            //check if new language is added
            IWebElement languageAdded = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr"));
            languageAdded.Click();
            Thread.Sleep(1500);

            //Update the language
            IWebElement clickUpdate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            clickUpdate.Click();

            //clear TextBox
            IWebElement updateTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
            updateTextbox.Clear();
            Thread.Sleep(2000);

            //updateTextbox.Click();
            Thread.Sleep(500);
            updateTextbox.SendKeys("Hindi");
            
            //Update Level
            IWebElement clearLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            clearLevel.Click();
            Thread.Sleep(500);
            clearLevel.SendKeys("[@value='Fluent' and text() ='Fluent']");
            Thread.Sleep(500);

            //Click on Update Button
            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();
            Thread.Sleep(500);
        }
    }
}
