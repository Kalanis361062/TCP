using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_LMS.Source.Pages
{
    public class CompleteExamsPage
    {
        private IWebDriver driver;

        //IWebElement
        private IWebElement pageHeading => driver.FindElement(By.XPath("//div[@id='main']/div[2]/div/h1"));

        

        public CompleteExamsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetTitle()
        {
            return driver.Title;
        }

        public string getHeading()
        {
            return pageHeading.Text;
        }
    }
}
