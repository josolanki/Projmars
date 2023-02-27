using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project_Mars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.Pages
{
    public class LoginPage:CommonDriver
    {
        public void LoginActions(IWebDriver driver)

        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            //launch localhost portal
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //click on sign in
            IWebElement signIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signIn.Click();
            Thread.Sleep(500);

            //Enter valid Email Id
            IWebElement emailId = driver.FindElement(By.XPath("//input[@name ='email']"));
            emailId.SendKeys("solankijo@yahoo.com");
            Thread.Sleep(500);

            //Enter valid Password
            IWebElement passwordTextBox = driver.FindElement(By.XPath("//input[@name='password']"));
            passwordTextBox.SendKeys("Jyoti09");
            Thread.Sleep(500);

            //Click on Login
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(500);
        }
        
    }
}
