﻿using OpenQA.Selenium;
using Project_Mars.Utilities;


namespace Project_Mars.Pages
{
    public class SkillsPage:CommonDriver
    {
        public void AddSkill(IWebDriver driver) 

        {
            Thread.Sleep(1000);
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
            
        }
        public string Getskill() 
        {
            IWebElement skillTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return skillTextBox.Text;
        }
        public string GetSkillLevel() 
        {
            IWebElement Skilllevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return Skilllevel.Text;
        }
    }
}
