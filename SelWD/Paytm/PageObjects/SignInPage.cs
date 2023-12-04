using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paytm.PageObjects
{
    internal class SignInPage
    {
        IWebDriver driver;
        public SignInPage(IWebDriver driver)
        {
            this.driver = driver?? throw new ArgumentException(nameof(driver));

            PageFactory.InitElements(driver, this);

        }
        [FindsBy(How = How.Id, Using = "email_mobile_login")]
        public IWebElement? UserNameText { get; set; }

        [FindsBy(How = How.Id, Using = "password_login")]
        public IWebElement? PasswordText { get; set; }

        [FindsBy(How = How.Name, Using = "remember")]
        public IWebElement? RememberMeChekbx { get; set; }

        [FindsBy(How = How.ClassName, Using = "_2oY3zzrfgApNfd7zMtTLn x-button")]
        public IWebElement? SignInBtn { get; set; }

        public void TypeUserName(string un)
        {
            UserNameText?.SendKeys(un);
        }
        public void TypePassword(string pwd)
        {
            PasswordText?.SendKeys(pwd);
        }
        public void RememberMeChkbkClick()
        {
            RememberMeChekbx?.Click();
        }
        public void SignInBtnClick()
        {
            SignInBtn?.Click();
        }

    }
}
