using OpenQA.Selenium;
using Project_Mars.Utilities;


namespace Project_Mars.Pages
{
    public class SkillsPage:CommonDriver
    {
        public void AddSkill() 

        {
            Thread.Sleep(1000);
            //click on Skill
            IWebElement selectSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            selectSkill.Click();

            Wait.WaitforelementstoBeExit(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 5);

            //click on Add new button
            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();


            //Enter name in skillbox
            IWebElement skillTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillTextBox.SendKeys("Programming");
            

            //choose Skill level
            IWebElement skillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillLevel.Click();
            

            //Select level from dropdown
            IWebElement beginnerOption = driver.FindElement(By.XPath("//option[@value='Beginner' and text() ='Beginner']"));
            beginnerOption.Click();

            
            //Add Skill
            IWebElement addSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addSkill.Click();



        }
        public string Getskill() 
        {
            IWebElement skillTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return skillTextBox.Text;
        }
        public string GetSkillLevel()
        {
            IWebElement Skilllevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return Skilllevel.Text;
        }
    }
}
