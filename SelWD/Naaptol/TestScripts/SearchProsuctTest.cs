﻿using Naaptol.PageObjects;
using Naaptol.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naaptol.TestScripts
{
    internal class SearchProsuctTest : CoreCodes
    {
        //[Test]
        public void Select5thProductTest()
        {

            var selectProduct = new Select5thProductPage(driver);

            var addProduct = selectProduct.SelectAProduct();
            List<string> lstWindow = driver.WindowHandles.ToList();

            foreach (var i in lstWindow)
            {
                Console.WriteLine("Switching to window: " + i);
                driver.SwitchTo().Window(i);
            }

            try
            {
                Assert.That(driver.Url.Contains("colored"));
                test = extent.CreateTest("Select Product Test- Pass");
                test.Pass("Select Product Test success");
            }
            catch
            {
                test = extent.CreateTest("Select Product Test - Fail");
                test.Fail("Select Product Test failed");
            }


            addProduct.SelectSizeLink();


        }
    }
}
