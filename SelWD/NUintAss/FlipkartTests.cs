using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintAss
{
    
    internal class FlipkartTests : CoreCode
    {
        [Test]
        [Description("Check for Search box")]
        public void SearchBoxTest()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";

            driver.FindElement(By.XPath("/html/body/div[3]/div/span")).Click();
            IWebElement searchInput = fluentWait.Until(driv => driv.FindElement(By.ClassName("Pke_EE")));
            //IWebElement passwordInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_password")));
            searchInput.SendKeys("laptops");
            searchInput.SendKeys(Keys.Enter);

        }

    }
}
