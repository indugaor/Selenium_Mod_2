using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    [TestFixture]
    internal class PaytmTest : CoreCodes
    {
        [Test]
        [Description("checked for valid login")]

        public void LoginTest()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";


            IWebElement loginTest = fluentWait.Until(driv => driv.FindElement(By.ClassName("_1YPz_")));
            // IWebElement otp = fluentWait.Until(driv => driv.FindElement(By.ClassName("cKPVd2kKcfsd14K4cbBPc")));
           // phonenumber.SendKeys("7676907287");
           loginTest.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));

            IWebElement loginClose = fluentWait.Until(driv => driv.FindElement(By.ClassName("_2jZ45")));
            loginClose.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }
        [Test]
        [Description("Seach Trains")]
        public void SearchTrainTest()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";

            IWebElement trainsMenu = driver.FindElement(By.XPath("//*[@id=\"app\"]/section[4]/div/div/div/div[4]"));
            trainsMenu.Click();

            Thread.Sleep(TimeSpan.FromSeconds(5));
            IWebElement sourcestationInput = fluentWait.Until(driv => driv.FindElement(By.XPath("//*[@id=\"dwebSourceInput\"]")));
            sourcestationInput.SendKeys("Trivendrum");
            sourcestationInput.SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(5));

            IWebElement  destinationInput = fluentWait.Until(driv => driv.FindElement(By.XPath("//*[@id=\"dwebDestinationInput\"]")));
            destinationInput.SendKeys("Hyderabad");
            destinationInput.SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(5));


            IWebElement searchTrain = fluentWait.Until(driv => driv.FindElement(By.ClassName("_2nkz5 _3r5iB fGGl8 -me3C")));
            searchTrain.Click();
            Thread.Sleep(3000);


            /* IWebElement destinationInput = driver.FindElement(By.Id("destinationInput"));
             destinationInput.SendKeys("DestinationStation");

             IWebElement dateInput = driver.FindElement(By.Id("dateInput"));
             dateInput.SendKeys("2023-12-01"); // Replace with the desired date format

             IWebElement searchButton = driver.FindElement(By.Id("searchButton"));
             searchButton.Click();
            */

        }
    }
}
