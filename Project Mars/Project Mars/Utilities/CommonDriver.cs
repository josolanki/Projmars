using NUnit.Framework;
using OpenQA.Selenium;
using Project_Mars.Pages;


namespace Project_Mars.Utilities
{
    public class CommonDriver
    {
        public static  IWebDriver driver;
        

        public void SignIn()
        {

            //Sign in page intialization and defination
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions();
        }
        
        public void CloseTest()
        {
            driver.Quit();

        }

    }
}
