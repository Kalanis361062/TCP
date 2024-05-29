using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_LMS.Source.Pages
{
    public class NewsAndEventsPage
    {
        private IWebDriver driver;

        //IWebElement
        private IWebElement addNewPostButton => driver.FindElement(By.XPath("//*[contains(text(),' Add New Post')]"));
        private IWebElement titleInput => driver.FindElement(By.XPath("//input[@name='title']"));
        private IWebElement summaryInput => driver.FindElement(By.XPath("//textarea[@name='summary']"));
        private IWebElement postedasDropdown => driver.FindElement(By.XPath("//select[@name='posted_as' and " +
            "@class='form-control select form-select']"));
        private IWebElement addNewPost_saveButton => driver.FindElement(By.XPath("//input[@type='submit' and @value='Save']"));

        private IWebElement addNewPost_cancelButton => driver.FindElement(By.XPath("//input[@type='submit' and @value='Save']/../a"));

        private IWebElement addNewPost_successAlert => driver.FindElement(By.XPath("//div[@class='alert alert-success']"));

        private IWebElement newsPostTitle => driver.FindElement(By.XPath("//*[contains(text(),'News Post 002')]"));

        private IWebElement eventPostTitle => driver.FindElement(By.XPath("//*[contains(text(),'Event Post 002')]"));

        private IWebElement newsPostSummary => driver.FindElement(By.XPath("//*[contains(text(),'News Test Summary')]"));

        private IWebElement eventPostSummary => driver.FindElement(By.XPath("//*[contains(text(),'Event Test Summary')]"));

        private IWebElement newsPostDropdown => driver.FindElement(By.XPath("//*[contains(text(),'News Post 002')]/../div/button"));

        private IWebElement eventPostDropdown => driver.FindElement(By.XPath("//*[contains(text(),'Event Post 002')]/../div/button"));

        private IWebElement postToDelete => driver.FindElement(By.XPath("//*[contains(text(),'Event Post 004')]/../div/button"));

        private IWebElement editPost => driver.FindElement(By.XPath("//*[contains(text(),'Edit')]"));

        private IWebElement deletePost => driver.FindElement(By.XPath("//*[contains(text(),'Delete')]"));

        public NewsAndEventsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetTitle()
        {
            return driver.Title;
        }

        public void ClickAddNewPostButton()
        {
            addNewPostButton.Click();
        }

        public void EnterTitle(string title)
        {
            titleInput.SendKeys(title);
        }

        public void EnterSummary(string summary)
        {
            summaryInput.SendKeys(summary);
        }

        public void ClickPostedasDropdown()
        {
            postedasDropdown.Click();
        }

        public void SelectNews()
        {
            SelectElement dropDown = new SelectElement(postedasDropdown);
            dropDown.SelectByText("News");
        }

        public void SelectEvent()
        {
            SelectElement dropDown = new SelectElement(postedasDropdown);
            dropDown.SelectByText("Event");
        }

        public void ClickAddNewPost_SaveButton()
        {
            addNewPost_saveButton.Click();
        }

        public void ClickAddNewPost_CancelButton()
        {
            addNewPost_cancelButton.Click();
        }

        public string getAlert()
        {
            return addNewPost_successAlert.Text;
        }

        public string getNewsPostTitle()
        {
            return newsPostTitle.Text;
        }

        public string getEventPostTitle()
        {
            return eventPostTitle.Text;
        }

        public string getNewsPostSummary()
        {
            return newsPostSummary.Text;
        }

        public string getEventPostSummary()
        {
            return eventPostSummary.Text;
        }

        public void ClickNewsPostDropdown()
        {
            newsPostDropdown.Click();
        }

        public void ClickEventPostDropdown()
        {
            eventPostDropdown.Click();
        }

        public void ClickPostToDelete()
        {
            postToDelete.Click();
        }

        public void SelectEdit()
        {
            editPost.Click();
        }

        public void SelectDelete()
        {
            deletePost.Click();
        }

    }
}
