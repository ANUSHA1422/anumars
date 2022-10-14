using System;
using anumarsproject.Pages;
using anumarsproject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace anumarsproject.StepDefinitions
{
    [Binding]
    public class ProfileFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I Signed into the Mars portal successfully")]
        public void GivenISignedIntoTheMarsPortalSuccessfully()
        {
            driver = new ChromeDriver();

            SigninPage signinPageObj = new SigninPage();
            signinPageObj.SigninSteps(driver);
        }

        [When(@"I navigate to language field")]
        public void WhenINavigateToLanguageField()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddLanguage(driver);
        }

        [When(@"I add a new language in the field")]
        public void WhenIAddANewLanguageInTheField()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddLanguage(driver);
        }

        [Then(@"The language should be added successfully")]
        public void ThenTheLanguageShouldBeAddedSuccessfully()
        {
            ProfilePage profilePageObj = new ProfilePage();
            string newlanguage = profilePageObj.GetLanguage(driver);
            Assert.That(newlanguage == "Telugu", "actual language and expected language do Not match");

        }

        [When(@"I navigate to skill field")]
        public void WhenINavigateToSkillField()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddSkills(driver);
        }

        [When(@"I add a new skill in the field")]
        public void WhenIAddANewSkillInTheField()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddSkills(driver);
        }
        [Then(@"The skill should be added successfully")]
        public void ThenTheSkillShouldBeAddedSuccessfully()
        {
            ProfilePage profilePageObj = new ProfilePage();
            string newskill = profilePageObj.Getskill(driver);
            Assert.That(newskill == "PAINT", "actual skill and expected skill do Not match");
        }


        [When(@"I navigate to description field")]
        public void WhenINavigateToDescriptionField()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddDescription(driver);
        }
        [When(@"I add a new description in the field")]
        public void WhenIAddANewDescriptionInTheField()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddDescription(driver);

        }
        [Then(@"The description should be added successfully")]
        public void ThenTheDescriptionShouldBeAddedSuccessfully()
        {
            ProfilePage profilePageObj = new ProfilePage();
            string newDescription = profilePageObj.GetDescription(driver);
            Assert.That(newDescription == "tester", "actual description and expected description do Not match");
        }

    }
}
