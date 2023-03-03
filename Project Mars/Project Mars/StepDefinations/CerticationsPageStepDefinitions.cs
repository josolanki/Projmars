using Project_Mars.Pages;
using Project_Mars.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Project_Mars.StepDefinations
{
    [Binding]
    public class CerticationsPageStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        ProfilePageTabs profilePageTabsObj = new ProfilePageTabs();

        [Given(@"I login with valid email and password")]
        public void GivenILoginWithValidEmailAndPassword()
        {
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions();

        }

        [When(@"I navigated to Certifications page\.")]
        public void WhenINavigatedToCertificationsPage_()
        {
            ProfilePageTabs profilePageTabsObj = new ProfilePageTabs();
            profilePageTabsObj.CertificationTab();
        }

        [When(@"I am able to add a new certificate '([^']*)' ,'([^']*)' ,'([^']*)'")]
        public void WhenIAmAbleToAddANewCertificate(string Certificate, string From, string Year)
        {
            CertificationPage certificationPageObj = new CertificationPage();
            certificationPageObj.AddCertification();
        }

        [Then(@"I successfully added a new '([^']*)' ,'([^']*)', '([^']*)'")]
        public void ThenISuccessfullyAddedANew(string Certificate, string From, string Year)
        {
            CertificationPage CertificationPageObj = new CertificationPage();
            CertificationPageObj.GetCertification();


        }
    }
}
