using NUnit.Framework;
using OpenQA.Selenium;
using Project_Mars.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        

        public void SignIn()
        {

            //Sign in page intialization and defination
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }
        
        public void CloseTest()
        {
            driver.Quit();

        }

    }
}
