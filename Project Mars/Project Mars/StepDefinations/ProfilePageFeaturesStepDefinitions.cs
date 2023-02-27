using NUnit.Framework;
using Project_Mars.Pages;
using Project_Mars.Utilities;
using TechTalk.SpecFlow;

namespace Project_Mars.StepDefinations
{
    [Binding]
    public class ProfilePageFeaturesStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        ProfilePageTabs profilePageTabsObj = new ProfilePageTabs();
        LanguagePage languagePageObj = new LanguagePage();

        [Given(@"I login with valid email and password\.")]
        public void GivenILoginWithValidEmailAndPassword_()
        {
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }
        [When(@"I navigated language Tab")]
        public void WhenINavigatedLanguageTab()
        {
            ProfilePageTabs profilePageTabsObj = new ProfilePageTabs();
            profilePageTabsObj.LanguageTab(driver);

        }

        [When(@"I added new  '([^']*)' and '([^']*)'")]
        public void WhenIAddedNewAnd(string langugage, string level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.CreateLanguage();
        }

        [Then(@"'([^']*)' and '([^']*)' should be added successfully\.")]
        public void ThenAndShouldBeAddedSuccessfully_(string langugage, string level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            string NewLanguage = languagePageObj.GetLanguage();
            string NewLevel = languagePageObj.GetLevel();

            Assert.That(NewLanguage == "English", "Actula code and expected code do not match");
            Assert.That(NewLevel == "Fluent", "Actul level and expected level do not match");
        }

    }
}
