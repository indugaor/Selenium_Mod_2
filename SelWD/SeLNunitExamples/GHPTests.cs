using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeLNunitExamples
{
    [TestFixture]
    internal class GHPTests : CoreCodes
    {
        [Ignore("other")]
        [Test]
        [Order(10)]
        public void TitleTest()
        {

            Thread.Sleep(3000); //never use the thread not using
            Assert.AreEqual("Google", driver.Title);
            Console.WriteLine("Title test - pass");
        }
        [Ignore("other")]
        [Test]
        [Order(20)]

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
        [Ignore("other")]

        [Test]
        public void AllLinksStatusTest()
        {
            List<IWebElement>allLinks=driver.FindElements(By.TagName("a")).ToList();
            foreach (IWebElement link in allLinks)
            {
                string url=link.GetAttribute("href");
                if(url==null)
                {
                    Console.WriteLine("URL is null");
                    continue;
                }
                else
                {
                    bool isworking=CheckLinkStatus(url);
                    if (isworking)
                        Console.WriteLine(url + "is Working");
                    else
                        Console.WriteLine(url + "is Not Working");
                }

            }

        }
    }
}
