
using NUnit.Framework;
using OpenQA.Selenium;

namespace anumarsproject.Pages
{
    public class SigninPage
    {
        public void SigninSteps(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            
            driver.Navigate().GoToUrl("http://localhost:5000/");
            try
            {
                IWebElement SignIn = driver.FindElement(By.XPath("//*[@id=\'home\']/div/div/div[1]/div/a"));
                SignIn.Click();

                IWebElement EmailAddress = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                EmailAddress.SendKeys("mymarsproject22@gmail.com");

                IWebElement Password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                Password.SendKeys("mars123$");

                IWebElement RememberMe = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[3]/div/input"));
                RememberMe.Click();
                IWebElement Login = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                Login.Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("signin did not finish",ex.Message);
            }
            //IWebElement SignIn = driver.FindElement(By.XPath("//*[@id=\'home\']/div/div/div[1]/div/a"));
            //SignIn.Click();

            //IWebElement EmailAddress = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            //EmailAddress.SendKeys("mymarsproject22@gmail.com");

            //IWebElement Password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            //Password.SendKeys("mars123$");

            //IWebElement RememberMe = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[3]/div/input"));
            //RememberMe.Click();
            //IWebElement Login = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            //Login.Click();

        }

    }
}
