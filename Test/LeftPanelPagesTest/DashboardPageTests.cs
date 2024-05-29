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
    public class DashboardPageTests
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;
        private DashboardPage dashboardPage;

        [SetUp]
        public void Setup()
        {
            // Set up the WebDriver
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            dashboardPage = new DashboardPage(driver);
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

        // Dashboard Page Title
        [Test]
        public void TestDashboardPageTitle()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("Dashboard | Learning management system", dashboardPage.GetTitle());
        }

        // Dashboard Page Heading
        [Test]
        public void TestDashboardPageHeading()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("Dashboard", dashboardPage.GetHeading());
        }

        // Dashboard Page Tiles - Students
        [Test]
        public void TestDashboardPageTile_Students()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("Students\r\n0", dashboardPage.GetStudentsTile());
        }

        // Dashboard Page Tiles - Lecturers
        [Test]
        public void TestDashboardPageTile_Lecturers()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("Lecturers\r\n0", dashboardPage.GetLecturersTile());
        }

        // Dashboard Page Tiles - Administrators
        [Test]
        public void TestDashboardPageTile_Administrators()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("Administrators\r\n1", dashboardPage.GetAdministratorsTile());
        }

        // Dashboard Page Tiles - LabAssistance
        [Test]
        public void TestDashboardPageTile_LabAssistance()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("Lab Assistance\r\n500", dashboardPage.GetLabAssistanceTile());
        }

        // Dashboard Page Tiles - Librarians
        [Test]
        public void TestDashboardPageTile_Librarians()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("Librarians\r\n300", dashboardPage.GetLibrariansTile());
        }

        // Dashboard Page Tiles - Supervisors
        [Test]
        public void TestDashboardPageTile_Supervisors()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("Supervisors\r\n660", dashboardPage.GetSupervisorsTile());
        }

        // Dashboard Page Tiles - OfficeAssistance
        [Test]
        public void TestDashboardPageTile_OfficeAssistance()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("Office Assistance\r\n1,700", dashboardPage.GetOfficeAssistanceTile());
        }

        // Dashboard Page Tiles - Others
        [Test]
        public void TestDashboardPageTile_Others()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("Others\r\n1,250", dashboardPage.GetOthersTile());
        }


        // Dashboard Page Graph - Website Traffic
        [Test]
        public void TestDashboardPageGraph_WebsiteTraffic()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("canvas", dashboardPage.GetWebsiteTrafficGraph());
        }

        // Dashboard Page Graph - Enrolment per course
        [Test]
        public void TestDashboardPageGraph_Enrolment()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("canvas", dashboardPage.GetEnrollementPerCourseGraph());
        }

        // Dashboard Page Graph - Student Average Grade (Performance)
        [Test]
        public void TestDashboardPageGraph_Performance()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("canvas", dashboardPage.GetStudentAverageGradeGraph());
        }

        // Dashboard Page Graph -  School Demographics
        [Test]
        public void TestDashboardPageGraph_SchoolDemographics()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("h5", dashboardPage.GetSchoolDemographicsGraphs());
        }

        // Dashboard Page Graph -  Student Gender
        [Test]
        public void TestDashboardPageGraph_StudentGender()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("canvas", dashboardPage.GetStudentGenderGraph());
        }

        // Dashboard Page Graph - Lecturer Qualifications 
        [Test]
        public void TestDashboardPageGraph_LecturerQualifications()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("canvas", dashboardPage.GetlecturerQualificationsGraph());
        }

        // Dashboard Page Graph - Get student Levels
        [Test]
        public void TestDashboardPageGraph_StudentLevels()
        {
            homePage.ClickDashboard();
            Assert.AreEqual("canvas", dashboardPage.GetstudentLevelsGraph());
        }

        // Dashboard Page - Settings - Display Grid
        [Test]
        public void TestDashboardPageSettings_DisplayGrid()
        {
            homePage.ClickDashboard();
            dashboardPage.ClickDashboardSettings();
            dashboardPage.ClickSetting_DisplayGrid();
            Assert.AreEqual("Dashboard Grid View", dashboardPage.GetHeading());
        }

        // Dashboard Page - Settings - Display Table
        [Test]
        public void TestDashboardPageSettings_DisplayTable()
        {
            homePage.ClickDashboard();
            dashboardPage.ClickDashboardSettings();
            dashboardPage.ClickSetting_DisplayTable();
            Assert.AreEqual("Dashboard Table View", dashboardPage.GetHeading());
        }

        // Dashboard Page - Settings - Manage Dashboard
        [Test]
        public void TestDashboardPageSettings_ManageDashboard()
        {
            homePage.ClickDashboard();
            dashboardPage.ClickDashboardSettings();
            dashboardPage.ClickSetting_ManageDashboard();
            Assert.AreEqual("Manage Dashboard", dashboardPage.GetHeading());
        }



        [TearDown]
        public void Teardown()
        {
            // Clean up the WebDriver
            driver.Quit();
        }
        
    }
}
