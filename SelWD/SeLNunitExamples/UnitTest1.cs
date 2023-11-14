
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeLNunitExamples
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            driver.Url = "https://www.amazon.com/";

        }

        [Test]
        public void CheckForTitle()
        {

            Thread.Sleep(2000); //never use the thread not using
            string title= driver.Title;
            Assert.AreEqual("Amazon.com. Spend less. Smile more.", title);


        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}