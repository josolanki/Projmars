using OpenQA.Selenium;
using Project_Mars.Utilities;
namespace Project_Mars.Pages
{
    public class LanguagePage : CommonDriver
    {
        public void CreateLanguage()
        {
            
            //Click on add new button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();

            //Enter Language
            IWebElement languageTextBox = driver.FindElement(By.Name("name"));
            languageTextBox.SendKeys("English");
            Thread.Sleep(500);

            //Enter Level
            IWebElement chooseLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseLanguageLevel.Click();
            Thread.Sleep(1500);

            //Add level option
            IWebElement levelOption = driver.FindElement(By.XPath("//option[@value='Fluent' and text() ='Fluent']"));
            levelOption.Click();
            Thread.Sleep(500);

            //Click add language button
            IWebElement addLanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addLanguageButton.Click();
            //Thread.Sleep(500);

            //Wait.WaitforelementstoBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr", 5);

            //IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]"));
           


            // Assert.That(NewLanguage == "English", "Actul code and expected code do not match");
            // Assert.That(NewLevel == "Fluent", "Actul level and expected level do not match");


        }



        public string GetLanguage() 
        {
            //Enter Language
            IWebElement languageTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
           return languageTextBox.Text;
 
        }
        //public string GetLevel() 
        //{
        //    IWebElement basicOption = driver.FindElement(By.XPath("//option[@value='Fluent' and text() ='Fluent']"));
        //    return basicOption.Text;
        //}
        public void EditLanguage()
        {
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
        public string GetNewLanguage(IWebDriver driver)
        {
            IWebElement NewLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            return NewLanguage.Text;    
        } 
        public void DeleteLanguage(IWebDriver driver) 
        {
            // Click on Delete button
            Thread.Sleep(1000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteButton.Click();   
        }
        //public string Getdeletelanguage(IWebDriver driver) 
        //{
        //IWebElement Deletelanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr"));
        //    return Deletelanguage.Text;
        //}

    }
}
