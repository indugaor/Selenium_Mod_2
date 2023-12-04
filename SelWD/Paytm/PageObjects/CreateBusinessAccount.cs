using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paytm.PageObjects
{
    internal class CreateBusinessAccount
    {
        private IWebDriver driver;

        public CreateBusinessAccount(IWebDriver driver)
        {
            this.driver = driver;
        }

        [FindsBy(How = How.Id, Using = "mobile_login") ]

        public IWebElement? MobileNumberInput { get; set; }


        [FindsBy(How = How.Id, Using = "email_login")]

        public IWebElement? EmailInput { get; set; }

        [FindsBy(How = How.Id, Using = "password_login")]

        public IWebElement? PasswordInput { get; set; }

        [FindsBy(How = How.Id, Using = "confirm_password_login")]

        public IWebElement? ConfirmPasswordInput { get; set; }


        [FindsBy(How = How.ClassName, Using = "_2oY3zzrfgApNfd7zMtTLn x-button")]
        public IWebElement? CheckOTPBtn { get; set; }

       // [FindsBy(How = How.Id, Using = "Register")]
        //public IWebElement? CreateMyAccountBtn { get; set; }


        //Act
        public  void MobileNumberType(string mobileNumber) 
        {
            MobileNumberInput?.SendKeys(mobileNumber);
        }
       
        public void Emailtype(string email)
        {
            EmailInput?.SendKeys(email);
        }
        public void CheckAvailabilityBtnClick()
        {
            CheckOTPBtn?.Click();
        }
      //  public void CreateMyAccountBtnClick()
        //{
          //  CreateMyAccountBtn?.Click();
        //}
        public void MobileNumberClear()
        {
            MobileNumberInput?.Clear();
        }
        public void EmailClear()
        {
            EmailInput?.Clear();
        }

    }
}
