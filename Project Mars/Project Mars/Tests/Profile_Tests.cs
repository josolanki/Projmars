using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

IWebDriver driver = new ChromeDriver();
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

//Check If user has logged in successfully
IWebElement hiJyoti = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));

if (hiJyoti.Text == "Hi Jyoti")
{
    Console.Write("Logged in successfully, test passed.");
}
else
{
    Console.Write("Log in failed ,test failed");
}

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

//Check if Language has been Updated
//IWebElement updateLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));

//Delete Language
//IWebElement deletetLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[2]/i"));
//deletetLanguage.Click();

//Thread.Sleep(500);
//if (updateLanguage.Text == "English")
//{
//    Console.Write("Language has been created successfully");
//}
//else
//{
//    Console.Write("Language has not been created successfully ");
//}

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

//Check if Skill is added sucessfully


//Click on Certification
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

//click on update
IWebElement updateCertificate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
updateCertificate.Click();
Thread.Sleep(500);

//clear CertificateTextBox and reenter Value
IWebElement clearCertificateBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input"));
clearCertificateBox.Clear();
clearCertificateBox.SendKeys("Management");
Thread.Sleep(500);





