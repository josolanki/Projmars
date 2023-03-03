using Project_Mars.Pages;
using Project_Mars.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Project_Mars.StepDefinations
{
    [Binding]
    public class SkillsPageStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        ProfilePageTabs profilePageTabsObj = new ProfilePageTabs();

        [When(@"I navigated to Skills page\.")]
        public void WhenINavigatedToSkillsPage_()
        {
            ProfilePageTabs profilePageTabsObj = new ProfilePageTabs();
            profilePageTabsObj.SkillTab();
        }

        [When(@"I added new skill  <Skill>'([^']*)'<level>'\.")]
        public void WhenIAddedNewSkillSkillLevel_(string p0)
        {
           
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.AddSkill();
        }

        [Then(@"I have successfully added a new <Skill>'([^']*)'<level>'\.")]
        public void ThenIHaveSuccessfullyAddedANewSkillLevel_(string p0)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.AddSkill();
        }
    }
}
