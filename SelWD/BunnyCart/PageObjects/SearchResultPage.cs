using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCart.PageObjects
{
    internal class SearchResultPage
    {
        private IWebDriver? driver;

        public SearchResultPage(IWebDriver? driver)
        {
            this.driver = driver;
        }
    }
}
