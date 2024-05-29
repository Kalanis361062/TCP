using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_LMS.Source.Pages
{
    public class SearchResultsPage
    {
        private IWebDriver driver;

        //IWebElement
        private IWebElement searchResultsCount => driver.FindElement(By.XPath("//div[@id='main']/div[2]/div/h5"));

        public SearchResultsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetTitle()
        {
            return driver.Title;
        }

        public string getResultsCount()
        {
            return searchResultsCount.Text;
        }

    }
}
