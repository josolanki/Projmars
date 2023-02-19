using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.Pages
{
    public class SkillsPage
    {
        public void AddSkill(IWebDriver driver) 
        {
            //click on Skill
            IWebElement selectSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            selectSkill.Click();
            Thread.Sleep(1000);

            //click on Add new button
            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();
            Thread.Sleep(1000);

            IWebElement skillTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillTextBox.SendKeys("Programming");
            Thread.Sleep(500);

            //choose Skill level
            IWebElement skillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillLevel.Click();
            Thread.Sleep(500);

            //Select level from dropdown
            IWebElement beginnerOption = driver.FindElement(By.XPath("//option[@value='Beginner' and text() ='Beginner']"));
            beginnerOption.Click();
            Thread.Sleep(500);

            //Skill add
            IWebElement addSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addSkill.Click();

            //Click on Update skill button
            IWebElement updateSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            updateSkill.Click();

            //Clear Skill textbox
            IWebElement SkillTextBox1 = driver.FindElement(By.XPath("//input[@value = 'Time Management']"));
            SkillTextBox1.Clear();
            Thread.Sleep(500);
            SkillTextBox1.SendKeys("Management");


            //Click on Update Button
            IWebElement addUpdate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            addUpdate.Click();
            Thread.Sleep(500);

            //Cancel update skill
            IWebElement cancelUpdateSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[2]/i"));
            cancelUpdateSkill.Click();
        }
    }
}
