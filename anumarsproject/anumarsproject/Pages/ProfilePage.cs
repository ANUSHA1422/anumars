


using anumarsproject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;



namespace anumarsproject.Pages
{
    public class ProfilePage
    {
        public void AddDescription(IWebDriver driver)
        {
            try
            {
                IWebElement Description = driver.FindElement(By.XPath("//i[@class='outline write icon']"));
                Description.Click();
                IWebElement WriteDescription = driver.FindElement(By.XPath("//textarea[@name='value']"));
                WriteDescription.Click();
                WriteDescription.Clear();
                WaitHelpers.WaitToBeClickable(driver, "XPath", "//textarea[@name='value']", 3);
                WriteDescription.SendKeys("tester");

                IWebElement Savebutton = driver.FindElement(By.XPath("//button[@type='button']"));
                Savebutton.Click();
               
            }
            catch(Exception ex)
            {
                Assert.Fail("description not done", ex.Message);
            }

        }
        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//textarea[@name='value']"));
            return newDescription.Text;
        }


        public void AddLanguage(IWebDriver driver)
        {
            IWebElement LanguageTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            LanguageTab.Click();
            IWebElement AddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]//div[3]/form/div[2]//div[2]/div/table/thead/tr/th[3]/div"));
            AddNew.Click();
            IWebElement AddLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            AddLanguage.SendKeys("English");
            IWebElement LanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            LanguageLevel.SendKeys("Fluent");
            IWebElement addbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addbutton.Click();

            IWebElement WriteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            WriteButton.Click();

            IWebElement UpdateLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            UpdateLanguage.SendKeys("Telugu");
            IWebElement UpdateLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            UpdateLevel.SendKeys("Native");
            IWebElement UpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            UpdateButton.Click();

            IWebElement newlanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            Assert.That(newlanguage.Text == "Telugu", "actual language and expected language do Not match");

            IWebElement DeleteLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            DeleteLanguage.Click();
        }
        public string GetLanguage(IWebDriver driver)
        {
            IWebElement newlanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            return newlanguage.Text;
        }

        public void AddSkills(IWebDriver driver)
        {
            //skills
            IWebElement SkillsButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillsButton.Click();
            IWebElement AddNewSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewSkill.Click();
            IWebElement AddSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            AddSkill.SendKeys("SING");
            IWebElement SkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SkillLevel.SendKeys("Expert");
            IWebElement Addbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            Addbutton.Click();

            IWebElement WriteSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            WriteSkill.Click();
            IWebElement UpdateSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            UpdateSkill.SendKeys("PAINT");
            IWebElement UpadteSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            UpadteSkillLevel.SendKeys("Beginner");

            IWebElement UpdateSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            UpdateSkillButton.Click();

            IWebElement newskill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            Assert.That(newskill.Text == "PAINT", "actual skill and expected skill do Not match");


            IWebElement DeleteSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            DeleteSkill.Click();

        }
        public string Getskill(IWebDriver driver)
        {
            IWebElement newskill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            return newskill.Text;
        }


    }
}
