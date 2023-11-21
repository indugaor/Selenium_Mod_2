using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SeLNunitExamples
{
    [TestFixture]
    internal class LinkedinTest : CoreCodes
    {
        [Test, Category("Regression Testing")]
        [Author("indu", "185240@ust.com")]
        [Description("checked for valid login")]

        public void LoginTest()
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3); 

            //WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(10));

            // IWebElement emailInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("session_key")));
            //IWebElement passwordInput= wait.Until(ExpectedConditions.ElementIsVisible(By.Id("session_password")));
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";

            IWebElement emailInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_key")));
            IWebElement passwordInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_password")));


            emailInput.SendKeys("abc@xyz.com");
            passwordInput.SendKeys("12345");

            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

        }
        /*
        [Test]
        [Author("indu", "185240@ust.com")]
        [Description(" check for invalid login")]
        [Category("Smoke Testing")]
        public void LoginTestWithInvalidCred()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";

            IWebElement emailInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_key")));
            IWebElement passwordInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_password")));


            emailInput.SendKeys("djflk@xyz.com");
            passwordInput.SendKeys("12345");
            Thread.Sleep(3000);
            ClearFrom(emailInput);
            ClearFrom(passwordInput);

            emailInput.SendKeys("abc@xyz.com");
            passwordInput.SendKeys("7584");
            Thread.Sleep(3000);
            ClearFrom(emailInput);
            ClearFrom(passwordInput);

            emailInput.SendKeys("abc@xyz.com");
            passwordInput.SendKeys("12345");
            Thread.Sleep(3000);
            ClearFrom(emailInput);
            ClearFrom(passwordInput);

        }
        */
        
        void ClearFrom(IWebElement element)
        {
            element.Clear();
        }

        /*

        [Test]
        [Author("AAA", "AAA@ust.com")]
        [Description("check for invalid login")]
        [Category("Regression Testing")]
        [TestCase("djflk@xyz.com","12345")]
        [TestCase("abc@xyz.com","7584")]
        [TestCase("abc@xyz.com","12345")]
        public void LoginTestWithInvalidCred(string email,string pwd)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";

            IWebElement emailInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_key")));
            IWebElement passwordInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_password")));

            emailInput.SendKeys(email);
            passwordInput.SendKeys(pwd);
            Thread.Sleep(3000);
            ClearFrom(emailInput);
            ClearFrom(passwordInput);

        }
        */
        [Test]
        [Author("AAA", "AAA@ust.com")]
        [Description("check for invalid login")]
        [Category("Regression Testing")]
        [TestCaseSource(nameof(InvalidLoginData))]
        public void LoginTestWithInvalidCred(string email, string pwd)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";

            IWebElement emailInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_key")));
            IWebElement passwordInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_password")));

            emailInput.SendKeys(email);
            passwordInput.SendKeys(pwd);
            TakeScreenShot();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);",
                driver.FindElement(By.XPath("//button[@type='submit']"))) ;
            Thread.Sleep(TimeSpan.FromSeconds(5));
            js.ExecuteScript("arguments[0].click();",
                driver.FindElement(By.XPath("//button[@type='submit']")));

            
              ClearFrom(emailInput);
              ClearFrom(passwordInput);

            

        }
        static object[] InvalidLoginData()
        {
            return new object[]
                {
                    new object[] {"abc@xyz.com","12345" },
                    new object[] {"hfd@dh.com","7563"},
                    new object[] {"fhd@fj.com","4798"}
                };
        }
       
    }
}

