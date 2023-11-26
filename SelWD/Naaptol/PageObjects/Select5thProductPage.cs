﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naaptol.PageObjects
{
    internal class Select5thProductPage
    {
        IWebDriver driver;
        public Select5thProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "productItem5")]
        public IWebElement? SelectProduct { get; set; }

        public AddProductPage SelectAProduct()
        {
            SelectProduct?.Click();
            return new AddProductPage(driver);
        }



    }
}
