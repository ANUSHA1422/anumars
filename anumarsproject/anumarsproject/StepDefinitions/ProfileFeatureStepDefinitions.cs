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
        [When(@"I Update '([^']*)'the langugae in the portal")]
        public void WhenIUpdateTheLangugaeInThePortal(string language)
        {
            
        }


        [Then(@"The language should have updated '([^']*)'")]
        public void ThenTheLanguageShouldHaveUpdated(string langauge)
        {
            
        }


    }
}
