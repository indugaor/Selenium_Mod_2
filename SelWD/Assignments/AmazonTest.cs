using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AmazonTest
    {
        IWebDriver? driver;
        public void Initialize()
        {

            driver = new ChromeDriver();
            driver.Navigate().Back();
            Thread.Sleep(3000);
            driver.Url = "https://www.amazon.com/";
            driver.Manage().Window.Maximize();
        }
        public void LocateTitleTest()
        {

            Thread.Sleep(3000); 
            string title = driver.Title;
            Console.WriteLine("Title" + driver.Title);
            Assert.That(driver.Title.Contains("Amazon"));
            //Assert.AreEqual("Amazon.com. Spend less. Smile more.", driver.Title);
            Console.WriteLine("Title test - pass");
        }
        public void PageSourceandURLTest()
        {
            Console.WriteLine("Ps:"+driver.PageSource);
            Console.WriteLine("PS Lenght"+driver.PageSource.Length);
            Console.WriteLine(driver.Url);
            Assert.AreEqual("https://www.amazon.com/", driver.Url);
            Console.WriteLine("URL test-pass");
        }



        public void Destruct()
        {
            driver.Close();
        }

    }
}
