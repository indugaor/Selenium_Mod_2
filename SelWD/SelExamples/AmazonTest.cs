using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelExamples
{
    internal class AmazonTest
    {
        IWebDriver? driver;
        public void InitializeEdgeDriver()
        {

            driver = new EdgeDriver();

            driver.Url = "https://www.amazon.com/";
            driver.Manage().Window.Maximize();
        }
        public void InitializeChromeDriver()
        {

            driver = new ChromeDriver();

            driver.Url = "https://www.amazon.com/";
            driver.Manage().Window.Maximize();
        }

        public void TitleTest()
        {

            Thread.Sleep(3000); //never use the thread not using

            Console.WriteLine("Title" + driver.Title);
            Console.WriteLine("Title Length" + driver.Title.Length);
            Assert.AreEqual("Amazon.com. Spend less. Smile more.", driver.Title);
            Console.WriteLine("Title test - pass");
        }
        public void LogoClickTest()
        {
            driver.FindElement(By.Id("nav-logo-sprites")).Click();
            Assert.AreEqual("Amazon.com. Spend less. Smile more.", driver.Title);
            Console.WriteLine("Logo test - pass");
        }
        public void SearchProductTest()
        {
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("mobiles");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
            Assert.That(("Amazon.com : mobiles".Equals(driver.Title)) &&
                (driver.Url.Contains("mobiles")));
            Console.WriteLine("SearchProduct Test -pass");

        }
        public void ReloadHomePage()
        {
            driver.Navigate().GoToUrl("https://www.amazon.com/");
            Thread.Sleep(3000);
        }
        public void TodaysDealsTest()
        {
            IWebElement todaysdeals = driver.FindElement(By.LinkText("Today's Deals"));
            if (todaysdeals == null)
            { 
                throw new NoSuchElementException("Today's Deals Link not present");
            }
                todaysdeals.Click();
                Assert.That(driver.FindElement(By.TagName("h1")).Text.Equals("Today's Deals"));
            Console.WriteLine("TodaysDeals test-pass");
        }
        public void SignInAccListTest()
        {
            IWebElement hellosignin = driver.FindElement(By.Id("nav-link-accountList-nav-line-1"));
            if (hellosignin == null)
            {
                throw new NoSuchElementException("Hello, Signin is not present");
            }
            IWebElement accountandlists = driver.FindElement(By.XPath("//*[@id=\"nav-link-accountList\"]/span"));
            if (accountandlists == null)
            {
                throw new NoSuchElementException("Hello, Account & List is not present");
            }
            Assert.That(hellosignin.Text.Equals("Hello, sign in"));
            Console.WriteLine("Hello, sign in present-pass");
            Assert.That(accountandlists.Text.Equals("Account & Lists"));
            Console.WriteLine("Account & Lists is present - pass");

        }public void SearchAndFilterProductByBrand()
        {
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("mobile phones");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
            driver.FindElement(By.XPath("//*[@id=\"p_89/Motorola\"]/span/a/div/label/i")).Click();       //driver.FindElement(By.XPath("//*[@id=\"p_89/Motorola\"]/span/a/div/label/input");
            Assert.True(driver.FindElement(By.XPath("//*[@id=\"p_89/Motorola\"]/span/a/div/label/input")).Selected);
            Console.WriteLine("Motorola is aelected");
            driver.FindElement(By.ClassName("a-expander-prompt")).Click();     
            driver.FindElement(By.XPath("//*[@id=\"p_89/BLU\"]/span/a/div/label/i")).Click();
            Assert.True(driver.FindElement(By.XPath("//*[@id=\"p_89/BLU\"]/span/a/div/label/input")).Selected);
            Console.WriteLine("BLU is selected");


        }
        public void SortBySelectTest()
        {
            IWebElement sortby = driver.FindElement(By.ClassName("a-button-text a-declarative"));
            SelectElement sortbyselect = (SelectElement)sortby;
            sortbyselect.SelectByValue("1");
            Thread.Sleep(5000);
            Console.WriteLine(sortbyselect.SelectedOption);
        }
        public void Destruct()
        {
            driver.Close();
        }

    }
}
