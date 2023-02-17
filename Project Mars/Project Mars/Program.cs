using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

IWebDriver driver = new ChromeDriver();


// launch localhost portal
driver.Navigate().GoToUrl("http://localhost:5000/");
driver.Manage().Window.Maximize();

// click on sign in
IWebElement signIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
signIn.Click();
Thread.Sleep(500);

// get the webelement corresponding to the email ID
IWebElement email = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
email.SendKeys("solankijo@yahoo.com");
Thread.Sleep(500);

// Retrive the webelement corresponding to the password
IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
passwordTextbox.SendKeys("Jyoti09");

//click login button
IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
loginButton.Click();
Thread.Sleep(500);

// check if user has login successfully

// Click on add new button
IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
addNewButton.Click();

IWebElement languageTextBox = driver.FindElement(By.Name("name"));
languageTextBox.SendKeys("Hindi");
Thread.Sleep(500);

IWebElement chooseLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
chooseLanguageLevel.Click();
Thread.Sleep(500);

IWebElement fluentOption = driver.FindElement(By.XPath("//option[@value='Fluent' and text() ='Fluent']"));
fluentOption.Click();
Thread.Sleep(500);

IWebElement addLanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
addLanguageButton.Click();
Thread.Sleep(500);

