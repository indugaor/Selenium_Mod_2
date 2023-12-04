using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paytm.PageObjects
{
    internal class PaytmHomePage
    {
        IWebDriver driver;
        public PaytmHomePage(IWebDriver driver)
        {
            this.driver = driver??throw new ArgumentException(nameof(driver));

            PageFactory.InitElements(driver, this);

        }
        //Arrange

        [FindsBy(How = How.LinkText, Using = "Create Account")]
        public IWebElement? CreateAccountLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Sign in")]

        public IWebElement? SignInLink { get; set; }

        public CreateBusinessAccount CreateAccountClick()
        {
            CreateAccountLink?.Click();
            return new CreateBusinessAccount(driver);
        }
        public SignInPage SignInClick()
        {
            CreateAccountLink?.Click();
            return new SignInPage(driver);
        }

    }
}
