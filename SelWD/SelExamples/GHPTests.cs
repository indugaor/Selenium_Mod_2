using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Edge;

namespace SelExamples
{
  
    internal class GHPTests
    {
        IWebDriver? driver;
        public void InitializeEdgeDriver()
        {

            driver = new EdgeDriver();

            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();
        }
        public void InitializeChromeDriver()
        {

            driver = new ChromeDriver();

            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();
        }

        public void TitleTest()
        {
            
            Thread.Sleep(3000); //never use the thread not using
            
            Console.WriteLine("Title" + driver.Title);
            Console.WriteLine("Title Length"+driver.Title.Length);
            Assert.AreEqual("Google",driver.Title);
            Console.WriteLine("Test test - pass");
        }
        public void PageSourceandURLTest()
        {
            //Console.WriteLine("Ps:"+driver.PageSource);
           // Console.WriteLine("PS Lenght"+driver.PageSource.Length);
            //Console.WriteLine(driver.Url);
            Assert.AreEqual("https://www.google.com/", driver.Url);
            Console.WriteLine("URL test-pass");
        }
        public void GStest()
        {
            
            IWebElement searchinputtextbox = driver.FindElement(By.Id("APjFqb"));
            searchinputtextbox.SendKeys("Hp laptop");
            Thread.Sleep(3000);
            IWebElement gsbutton = driver.FindElement(By.ClassName("gNO89b"));    //Name("btnK"));
            gsbutton.Click();
            Assert.AreEqual("Hp laptop - Google Search", driver.Title);
            Console.WriteLine("GS Test - pass");
        }
        public void GmailLinkTest()
        {
            driver.Navigate().Back();
            driver.FindElement(By.LinkText("Gmail")).Click();
           // driver.FindElement(By.PartialLinkText("ma")).Click();
            Thread.Sleep(3000);
            string title= driver.Title;
            // Assert.That(title.Contains("Gmail"));
            Assert.That(driver.Title.Contains("gmail"));
            Console.WriteLine(" Gmail Link-Pass");
        }
        public void ImagesLinkTest()
        { 
            driver.Navigate().Back();
            //driver.FindElement(By.LinkText("mag")).Click();
            driver.FindElement(By.PartialLinkText("mag")).Click();
            Thread.Sleep(3000);
            string title = driver.Title;
            Assert.That(driver.Title.Contains("Images"));
            Console.WriteLine(" images Link-Pass");
        }
        public void LocalizationTest()
        {
            driver.Navigate().Back();
            string loc= driver.FindElement(By.XPath("html/body/div[1]/div[6]/div[1]")).Text;
            //driver.FindElement(By.PartialLinkText("mag")).Click();
            Thread.Sleep(3000);
            Assert.That(loc.Equals("India"));
            Console.WriteLine("loc-Pass");
        }
        public void GappYouTubeTest()
        {
            driver.FindElement(By.ClassName("gb_d")).Click();
            driver.FindElement(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz/div/div/c-wiz/div/div/div[2]/div[2]/div[1]/ul/li[4]/a/div/span")).Click();
            Thread.Sleep(3000);
            Assert.That("YouTube".Equals(driver.Title));
        }

        public void Destruct() 
        {
            driver.Close();
        }
    }
}
