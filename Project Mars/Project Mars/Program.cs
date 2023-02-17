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

//check if new language is added
IWebElement languageAdded = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr"));
languageAdded.Click();
Thread.Sleep(1000);

//click on Skill
IWebElement selectSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
selectSkill.Click();
Thread.Sleep(1000);

// click on Add new button
IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
addnewButton.Click();
Thread.Sleep(1000);

IWebElement skillTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
skillTextBox.SendKeys("Communication");
Thread.Sleep(500);

// choose Skill level
IWebElement skillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
skillLevel.Click();
Thread.Sleep(500);

//Select level from dropdown
IWebElement beginnerOption = driver.FindElement(By.XPath("//option[@value='Beginner' and text() ='Beginner']"));
beginnerOption.Click();
Thread.Sleep(500);

// Skill add
IWebElement addSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
addSkill.Click();

// Click on Certification
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