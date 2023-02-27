using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Project_Mars.Pages;


IWebDriver driver = new ChromeDriver();
//Sign in page intialization and defination
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginActions(driver);

//On Profile page identify Tab and click on it
ProfilePageTabs profilePageTabs = new ProfilePageTabs();
profilePageTabs.LanguageTab(driver);


// certification page intialization and defination
//CertificationPage certificationPageObj = new CertificationPage();
//certificationPageObj.AddCertification(driver);

//Language page intialization and defination
//LanguagePage languagePageObj = new LanguagePage();
//languagePageObj.CreateLanguage();

////Skills page intialization and defination
//SkillsPage skillsPageObj = new SkillsPage();
//skillsPageObj.AddSkill(driver);











