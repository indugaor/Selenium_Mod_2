﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naapitol.PageObjects
{
    internal class NaaptolHomePage
    {
        IWebDriver driver;
        public NaaptolHomePage(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

        //Arrange
        [FindsBy(How = How.Id, Using = "header_search_text")]
        public IWebElement? SearchInputBox { get; set; }

        //Act
        public void SearchClick(string productName)
        {
            SearchInputBox?.SendKeys(productName);
            SearchInputBox?.SendKeys(Keys.Enter);
        }
    }
}
