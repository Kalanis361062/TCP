using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_LMS.Source.Pages
{
    public class DashboardPage
    {
        private IWebDriver driver;

        //IWebElement
        private IWebElement pageHeading => driver.FindElement(By.XPath("//div[@id='main']/div[2]/div/h1"));

        private IWebElement studentsTile => driver.FindElement(By.XPath("//div[@class='row users-count px-3']/div/div/div"));

        private IWebElement lecturersTile => driver.FindElement(By.XPath("//div[@class='row users-count px-3']/div[2]/div/div"));

        private IWebElement administratorsTile => driver.FindElement(By.XPath("//div[@class='row users-count px-3']/div[3]/div/div"));

        private IWebElement labassistanceTile => driver.FindElement(By.XPath("//div[@class='row users-count px-3']/div[4]/div/div"));

        private IWebElement librariansTile => driver.FindElement(By.XPath("//div[@class='row users-count px-3']/div[5]/div/div"));

        private IWebElement supervisorsTile => driver.FindElement(By.XPath("//div[@class='row users-count px-3']/div[6]/div/div"));

        private IWebElement officeassistanceTile => driver.FindElement(By.XPath("//div[@class='row users-count px-3']/div[7]/div/div"));

        private IWebElement othersTile => driver.FindElement(By.XPath("//div[@class='row users-count px-3']/div[8]/div/div"));

        private IWebElement websiteTrafficGraph => driver.FindElement(By.XPath("//*[@id='traffic']"));

        private IWebElement enrollementPerCourseGraph => driver.FindElement(By.XPath("//*[@id='enrollement']"));

        private IWebElement studentAverageGradeGraph => driver.FindElement(By.XPath("//*[@id='students_grade']"));

        private IWebElement schoolDemographicsGraphs => driver.FindElement(By.XPath("//*[contains(text(),'School Demographics')]"));

        private IWebElement studentGenderGraph => driver.FindElement(By.XPath("//*[@id='gender']"));

        private IWebElement lecturerQualificationsGraph => driver.FindElement(By.XPath("//*[@id='ethnicity']"));

        private IWebElement studentLevelsGraph => driver.FindElement(By.XPath("//*[@id='language']"));

        private IWebElement dashboardSettingsButton => driver.FindElement(By.XPath("//div[@class='dropdown']/button"));

        private IWebElement dashboardSettings_displayGrid => driver.FindElement(By.XPath("//div[@class='dropdown']/div/button"));

        private IWebElement dashboardSettings_displayTable => driver.FindElement(By.XPath("//div[@class='dropdown']/div/button[2]"));

        private IWebElement dashboardSettings_manageDashboard => driver.FindElement(By.XPath("//div[@class='dropdown']/div/button[3]"));

        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetTitle()
        {
            return driver.Title;
        }

        public string GetHeading()
        {
            return pageHeading.Text;
        }

        public string GetStudentsTile()
        {
            return studentsTile.Text;
        }

        public string GetLecturersTile()
        {
            return lecturersTile.Text;
        }

        public string GetAdministratorsTile()
        {
            return administratorsTile.Text;
        }

        public string GetLabAssistanceTile()
        {
            return labassistanceTile.Text;
        }

        public string GetLibrariansTile()
        {
            return librariansTile.Text;
        }

        public string GetSupervisorsTile()
        {
            return supervisorsTile.Text;
        }

        public string GetOfficeAssistanceTile()
        {
            return officeassistanceTile.Text;
        }

        public string GetOthersTile()
        {
            return othersTile.Text;
        }

        public string GetWebsiteTrafficGraph()
        {
            return websiteTrafficGraph.TagName.ToString();
        }

        public string GetEnrollementPerCourseGraph()
        {
            return enrollementPerCourseGraph.TagName.ToString();
        }

        public string GetStudentAverageGradeGraph()
        {
            return studentAverageGradeGraph.TagName.ToString();
        }

        public string GetSchoolDemographicsGraphs()
        {
            return schoolDemographicsGraphs.TagName.ToString();
        }

        public string GetStudentGenderGraph()
        {
            return studentGenderGraph.TagName.ToString();
        }

        public string GetlecturerQualificationsGraph()
        {
            return lecturerQualificationsGraph.TagName.ToString();
        }

        public string GetstudentLevelsGraph()
        {
            return studentLevelsGraph.TagName.ToString();
        }

        public void ClickDashboardSettings()
        {
            dashboardSettingsButton.Click();
        }

        public void ClickSetting_DisplayGrid()
        {
            dashboardSettings_displayGrid.Click();
        }

        public void ClickSetting_DisplayTable ()
        {
            dashboardSettings_displayTable.Click();
        }

        public void ClickSetting_ManageDashboard()
        {
            dashboardSettings_manageDashboard.Click();
        }
    }
}
