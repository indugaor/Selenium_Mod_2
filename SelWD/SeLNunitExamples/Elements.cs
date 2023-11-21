using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeLNunitExamples
{
    [TestFixture]
    internal class Elements : CoreCodes
    {

        [Test]
        public void TestCheckbox()
        {
            Thread.Sleep(3000);
            /*
            IWebElement elements = driver.FindElement(By.XPath("//h5[text='Elements']//parent::div"));
            elements.Click();
            */
            IWebElement cbmenu = driver.FindElement(By.XPath("//span[text()='Check Box']//parent::li"));
            cbmenu.Click();

            List<IWebElement> expandcollapse = driver.FindElements(By.XPath("//*[@id=\tree-node\"]/")).ToList();
            foreach (IWebElement item in expandcollapse)
            {
                item.Click();

            }
            IWebElement cammandscheckbox = driver.FindElement(By.XPath("//span[text()='Cammands']"));
            cammandscheckbox.Click();
            Assert.True(driver.FindElement(By.XPath("//input[contains(@id,'cammands']")).Selected);
        }
        [Ignore("other")]
        [Test]
        public void TestFromElements()
        {

            Thread.Sleep(2000);
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("John");
            Thread.Sleep(2000);
            IWebElement lastNamefeild = driver.FindElement(By.Id("lastName"));
            lastNamefeild.SendKeys("Doe");
            Thread.Sleep(2000);
            IWebElement emailFeild = driver.FindElement(By.XPath("//input[@id='userEmail']"));
            emailFeild.SendKeys("myid@gmail.com");
            Thread.Sleep(2000);
            IWebElement genderRadio = driver.FindElement(By.XPath("//input[@id='gender-radio-1']//following::label"));
            genderRadio.Click();
            Thread.Sleep(2000);
            IWebElement mobileNumberFeild = driver.FindElement(By.Id("userNumber"));
            mobileNumberFeild.SendKeys("9876543210");
            Thread.Sleep(2000);
            IWebElement dobFeild = driver.FindElement(By.Id("dateOfBirthInput"));
            dobFeild.Click();
            Thread.Sleep(2000);
            IWebElement dobMonth = driver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']"));
            SelectElement selectMonth = new SelectElement(dobMonth);
            selectMonth.SelectByIndex(4);
            Thread.Sleep(2000);
            IWebElement dobYear = driver.FindElement(By.XPath("//select[@class='react-datepicker__year-select']"));
            SelectElement selectYear = new SelectElement(dobYear);
            selectYear.SelectByText("1998");
            Thread.Sleep(2000);
            IWebElement dobDay = driver.FindElement(By.XPath("//div[@class='react-datepicker__day react-datepicker__day--005']"));
            dobDay.Click();
            Thread.Sleep(2000);
            IWebElement subjectsFeild = driver.FindElement(By.Id("subjectsInput"));
            subjectsFeild.SendKeys("Maths");
            subjectsFeild.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            subjectsFeild.SendKeys("Chemistry");
            subjectsFeild.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            IWebElement hobbiesCheckbox = driver.FindElement(By.XPath("//label[text()='Sports']"));
            hobbiesCheckbox.Click();
            Thread.Sleep(3000);
            IWebElement uploadPictureFeild = driver.FindElement(By.Id("uploadPicture"));
            uploadPictureFeild.SendKeys("C:\\Users\\User\\Pictures\\Camera Roll\\Capture.png");
            Thread.Sleep(3000);
            IWebElement currentAddressFeild = driver.FindElement(By.Id("currentAddress"));
            currentAddressFeild.SendKeys("123 Street,city,Country");
            Thread.Sleep(3000);
            //IWebElement submitButton = driver.FindElement(By.Id("submit"));
            //submitButton.Click();
            //Thread.Sleep(3000);
        }
        /*
        [Test]
        public void TestWindows()
        {
            driver.Url = "https://demoqa.com/browser-windows";
            string parentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Parent window's handle -> " + parentWindowHandle);
            IWebElement clickElement = driver.FindElement(By.Id("tabButton"));
            for (var i = 0; i < 3; i++)
            {
                clickElement.Click();
                Thread.Sleep(3000);
            }

            List<string> lastwindow = driver.WindowHandles.ToList();

            string lastWindowHandle = "";
            foreach (var handle in lastwindow)
            {
                Console.WriteLine("Switching to window = > " + handle);
                driver.SwitchTo().Window(handle);
                Thread.Sleep(2000);
                Console.WriteLine("Navigating to google.com");
                driver.Navigate().GoToUrl("https://google.com");
                Thread.Sleep(2000);
            }
            driver.SwitchTo().Window(parentWindowHandle);
            driver.Quit();
        }
        
        */
        [Test]

        public void TestAlerts()
        {
            driver.Url = "https://demoqa.com/alerts";

            IWebElement element = driver.FindElement(By.Id("alertButton"));
            Thread.Sleep(5000);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", element);
            IAlert simpleAlert = driver.SwitchTo().Alert();
            Console.WriteLine("Alert text is " + simpleAlert.Text);

            simpleAlert.Accept();
            Thread.Sleep(5000);

            element = driver.FindElement(By.Id("confirmButton"));
            Thread.Sleep(5000);
            element.Click();
            IAlert confirmationAlert = driver.SwitchTo().Alert();
            string alertText = confirmationAlert.Text;
            Console.WriteLine("Alert text is " + alertText);
            confirmationAlert.Dismiss();

            element = driver.FindElement(By.Id("promtButton"));
            element.Click();
            Thread.Sleep(5000);
            IAlert promtAlert = driver.SwitchTo().Alert();
            alertText = promtAlert.Text;
            Console.WriteLine("Alert text is " + alertText);
            promtAlert.SendKeys("Accepting the alert");
            Thread.Sleep(5000);
            promtAlert.Accept();
        }



    }

}

