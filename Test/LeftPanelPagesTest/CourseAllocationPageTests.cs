using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium_LMS.Source.Pages;

namespace Selenium_LMS.Test
{
    [TestFixture]
    public class CourseAllocationPageTests
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;
        private CourseAllocationPage courseAllocationPage;

        [SetUp]
        public void Setup()
        {
            // Set up the WebDriver
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            courseAllocationPage = new CourseAllocationPage(driver);
            Login();
        }

        public void Login()
        {
            loginPage.GoToLoginPage();
            loginPage.EnterUsername("RADKHW");
            loginPage.EnterPassword("Saranga!890");
            loginPage.ClickLoginButton();
            Thread.Sleep(1000);
            driver.Manage().Window.Maximize();
        }

        // Course Allocation Page Title
        [Test]
        public void TestCourseAllocationPageTitle()
        {
            homePage.ClickProfile();
            Assert.AreEqual("Course Allocations | Learning management system", courseAllocationPage.GetTitle());
        }

        [TearDown]
        public void Teardown()
        {
            // Clean up the WebDriver
            driver.Quit();
        }
        
    }
}
