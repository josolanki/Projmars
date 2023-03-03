using NUnit.Framework;
using Project_Mars.Pages;
using Project_Mars.Utilities;
using TechTalk.SpecFlow;

namespace Project_Mars.StepDefinations
{
    [Binding]
    public class LanguagePageStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        ProfilePageTabs profilePageTabsObj = new ProfilePageTabs();
        LanguagePage languagePageObj = new LanguagePage();

        [Given(@"I login with valid email and password\.")]
        public void GivenILoginWithValidEmailAndPassword_()
        {
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions();
        }
        [When(@"I navigated language Tab")]
        public void WhenINavigatedLanguageTab()
        {
            ProfilePageTabs profilePageTabsObj = new ProfilePageTabs ();
            profilePageTabsObj.LanguageTab();

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
      //      string NewLevel = languagePageObj.GetLevel();

            Assert.That(NewLanguage == "English", "Test failed");
        }
        [When(@"I edit existing '([^']*)' recors\.")]
        public void WhenIEditExistingRecors_(string langugage)
        {
            profilePageTabsObj.LanguageTab();
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.EditLanguage();

        }
        [Then(@"I successfully edited '([^']*)' record\.")]
        public void ThenISuccessfullyEditedRecord_(string langugage)
        {
            LanguagePage languagePageObj = new LanguagePage();
            string NewEditlanguage = languagePageObj.GetNewLanguage(driver);

            Assert.That(NewEditlanguage == "Hindi", "Test Failed");

        }
        [When(@"I am able to delete existing language")]
        public void WhenIAmAbleToDeleteExistingLanguage()
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.DeleteLanguage(driver);

        }
        //[Then(@"i have successfully deleted language")]
        //public void ThenIHaveSuccessfullyDeletedLanguage()
        //{
        //    LanguagePage languagePageObj = new LanguagePage();
        //    string NewDeleteLanguage = languagePageObj.Getdeletelanguage(driver);
        //    Assert.That(NewDeleteLanguage == "Hindi", "Test Failed");
        //    driver.Quit();

        //}


    }
}
