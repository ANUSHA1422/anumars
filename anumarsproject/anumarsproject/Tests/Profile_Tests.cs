
using anumarsproject.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using anumarsproject.Utilities;

namespace anumarsproject.Tests
{
    [TestFixture]
    public class Profile_Tests : CommonDriver
    {
        [SetUp]
        public void SigninActions()
        {
            driver = new ChromeDriver();

            SigninPage signinPageObj = new SigninPage();
            signinPageObj.SigninSteps(driver);

            ProfilePage profilePageObj = new ProfilePage();

        }
        [Test, Order(1)]
        public void AddDescriptionTest()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddDescription(driver);
        }
        [Test, Order(2)]
        public void AddLanguageTest()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddLanguage(driver);
        }
        [Test, Order(3)]
        public void AddSkillsTest()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddSkills(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
















        //    IWebDriver driver = new ChromeDriver();
        //    SigninPage signinPageObj = new SigninPage();
        //    signinPageObj.SigninSteps(driver);

        //    ProfilePage profilePageObj = new ProfilePage();
        //    profilePageObj.AddDescription(driver);
        //    profilePageObj.AddLanguage(driver);
        //    profilePageObj.AddSkills(driver);

        //}
    }
}


