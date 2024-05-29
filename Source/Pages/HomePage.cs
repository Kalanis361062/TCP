using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_LMS.Source.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        //IWebElement
        private IWebElement mainSearchBar => driver.FindElement(By.XPath("//input[@id='primary-search' and @type='text' and @name='q']"));

        private IWebElement searchButton => driver.FindElement(By.XPath("//input[@id='primary-search' and @type='text' and @name='q']/../button/i"));

        private IWebElement leftPanel_Dashboard => driver.FindElement(By.XPath("//div[@class='main-menu']/ul/li/a"));

        private IWebElement leftPanel_Home => driver.FindElement(By.XPath("//div[@class='main-menu']/ul/li[2]/a"));

        private IWebElement leftPanel_Profile => driver.FindElement(By.XPath("//div[@class='main-menu']/ul/li[3]/a"));

        private IWebElement leftPanel_AdminPanel => driver.FindElement(By.XPath("//div[@class='main-menu']/ul/li[4]/a"));

        private IWebElement leftPanel_Lecturers => driver.FindElement(By.XPath("//div[@class='main-menu']/ul/li[5]/a"));

        private IWebElement leftPanel_Students => driver.FindElement(By.XPath("//div[@class='main-menu']/ul/li[6]/a"));

        private IWebElement leftPanel_ProgramsAndCourses => driver.FindElement(By.XPath("//div[@class='main-menu']/ul/li[7]/a"));

        private IWebElement leftPanel_CompleteExams => driver.FindElement(By.XPath("//div[@class='main-menu']/ul/li[8]/a"));

        private IWebElement leftPanel_QuizProgressRec => driver.FindElement(By.XPath("//div[@class='main-menu']/ul/li[9]/a"));

        private IWebElement leftPanel_CourseAllocation => driver.FindElement(By.XPath("//div[@class='main-menu']/ul/li[10]/a"));

        private IWebElement leftPanel_ManageSession => driver.FindElement(By.XPath("//div[@class='main-menu']/ul/li[11]/a"));

        private IWebElement leftPanel_ManageSemester => driver.FindElement(By.XPath("//div[@class='main-menu']/ul/li[12]/a"));

        private IWebElement leftPanel_AccountSetting => driver.FindElement(By.XPath("//div[@class='main-menu']/ul/li[13]/a"));

        private IWebElement leftPanel_ChangePassword => driver.FindElement(By.XPath("//div[@class='main-menu']/ul/li[14]/a"));


        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetTitle()
        {
            return driver.Title;
        }

        public void EnterKeyword(string keyword)
        {
            mainSearchBar.SendKeys(keyword);
        }

        public void ClickSearchButton()
        {
            searchButton.Click();
        }

        public void ClickDashboard()
        {
            leftPanel_Dashboard.Click();
        }

        public void ClickHome()
        {
            leftPanel_Home.Click();
        }

        public void ClickProfile()
        {
            leftPanel_Profile.Click();
        }

        public void ClickAdminPanel()
        {
            leftPanel_AdminPanel.Click();
        }

        public void ClickLecturers()
        {
            leftPanel_Lecturers.Click();
        }

        public void ClickStudents()
        {
            leftPanel_Students.Click();
        }

        public void ClickProgramsAndCourses()
        {
            leftPanel_ProgramsAndCourses.Click();
        }

        public void ClickCompleteExams()
        {
            leftPanel_CompleteExams.Click();
        }

        public void ClickQuizProgressRec()
        {
            leftPanel_QuizProgressRec.Click();
        }

        public void ClickCourseAllocation()
        {
            leftPanel_CourseAllocation.Click();
        }

        public void ClickManageSession()
        {
            leftPanel_ManageSession.Click();
        }

        public void ClickManageSemester()
        {
            leftPanel_ManageSemester.Click();
        }

        public void ClickAccountSetting()
        {
            leftPanel_AccountSetting.Click();
        }

        public void ClickChangePassword()
        {
            leftPanel_ChangePassword.Click();
        }
    }
}
