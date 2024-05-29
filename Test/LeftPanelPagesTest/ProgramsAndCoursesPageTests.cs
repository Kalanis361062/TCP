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
    public class ProgramsAndCoursesPageTests
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;
        private ProgramsAndCoursesPage programsAndCoursesPage;

        [SetUp]
        public void Setup()
        {
            // Set up the WebDriver
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            programsAndCoursesPage = new ProgramsAndCoursesPage(driver);
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

        // Programs And Courses Page Title
        [Test]
        public void TestProgramsAndCoursesPageTitle()
        {
            homePage.ClickProgramsAndCourses();
            Assert.AreEqual("Programs | Learning management system", programsAndCoursesPage.GetTitle());
        }

        [TearDown]
        public void Teardown()
        {
            // Clean up the WebDriver
            driver.Quit();
        }
        
    }
}
