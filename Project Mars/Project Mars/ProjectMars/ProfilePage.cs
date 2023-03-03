using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Project_Mars.Pages;


//Sign in page intialization and defination
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginActions();

//On Profile page identify Tab and click on it
ProfilePageTabs profilePageTabs = new ProfilePageTabs();
profilePageTabs.LanguageTab();

//Language page intialization and defination
LanguagePage languagePageObj = new LanguagePage();
languagePageObj.CreateLanguage();

//certification page intialization and defination
CertificationPage certificationPageObj = new CertificationPage();
certificationPageObj.AddCertification();


//Skills page intialization and defination
SkillsPage skillsPageObj = new SkillsPage();
skillsPageObj.AddSkill();











