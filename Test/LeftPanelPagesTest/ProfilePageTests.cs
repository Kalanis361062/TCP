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
    public class ProfilePageTests
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;
        private ProfilePage profilePage;
        private ChangePasswordPage changePasswordPage;
        private AccountSettingPage accountSettingPage;

        [SetUp]
        public void Setup()
        {
            // Set up the WebDriver
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            profilePage = new ProfilePage(driver);
            changePasswordPage = new ChangePasswordPage(driver);
            accountSettingPage = new AccountSettingPage(driver);
            Login();
            homePage.ClickProfile();
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

        // Profile Page Title
        [Test]
        public void TestProfilePageTitle()
        {
            Assert.AreEqual("Polar Bear | Learning management system", profilePage.GetTitle());
        }

        // Profile Page Heading
        [Test]
        public void TestProfilePageHeading()
        {
            Assert.AreEqual("Polar Bear", profilePage.GetHeading());
        }

        // Profile Page - Full Name
        [Test]
        public void TestProfilePage_FullName()
        {
            Assert.AreEqual("Polar Bear", profilePage.GetFullName());
        }


        // Profile Page - Last Login
        [Test]
        public void TestProfilePage_LastLogin()
        {
            Assert.AreEqual("Last login: April 16, 2024", profilePage.GetLastLogin());
        }

        // Profile Page - Role
        [Test]
        public void TestProfilePage_Role()
        {
            Assert.AreEqual("Role: Admin", profilePage.GetRole());
        }

        // Profile Page - Personal Info Heading
        [Test]
        public void TestProfilePage_PersonalInfoHeading()
        {
            Assert.AreEqual("Personal Info", profilePage.GetPersonalInfoHeading());
        }

        // Profile Page - First Name
        [Test]
        public void TestProfilePageFirstName()
        {
            Assert.AreEqual("First Name: Polar", profilePage.GetFirstName());
        }

        // Profile Page - Last Name
        [Test]
        public void TestProfilePageLastName()
        {
            Assert.AreEqual("Last Name: Bear", profilePage.GetLastName());
        }

        // Profile Page - Id
        [Test]
        public void TestProfilePageId()
        {
            Assert.AreEqual("ID No.: RADKHW", profilePage.GetId());
        }

        // Profile Page - Contact Info Heading
        [Test]
        public void TestProfilePage_ContactInfoHeading()
        {
            Assert.AreEqual("Contact Info", profilePage.GetContactInfoHeading());
        }

        // Profile Page - Email
        [Test]
        public void TestProfilePageEmail()
        {
            Assert.AreEqual("Email: khwijayawardana@gmail.com", profilePage.GetEmail());
        }

        // Profile Page - Phone
        [Test]
        public void TestProfilePagePhone()
        {
            Assert.AreEqual("Tel No.: 1231241414", profilePage.GetPhone());
        }

        // Profile Page - Address
        [Test]
        public void TestProfileAddress()
        {
            Assert.AreEqual("Address/city: Casuarina", profilePage.GetAddress());
        }

        // Profile Page - ImportantDates Heading
        [Test]
        public void TestProfilePage_ImportantDatesHeading()
        {
            Assert.AreEqual("Important Dates", profilePage.GetImportantDatesHeading());
        }

        // Profile Page - Last login Date
        [Test]
        public void TestProfilePageLastLoginDateAndTime()
        {
            Assert.That("Last login:", Does.Contain(profilePage.GetLastLoginDateAndTime()));
        }

        // Profile Page - Registered Date
        [Test]
        public void TestProfilePageRegisteredDate()
        {
            Assert.AreEqual("Registered Date: April 2, 2024", profilePage.GetRegisteredDate());
        }

        // Profile Page - Edit Profile
        [Test]
        public void TestProfilePageEditProfileButton()
        {
            Assert.AreEqual("Account Setting | Learning management system", accountSettingPage.GetTitle());
        }

        // Profile Page - Change Password
        [Test]
        public void TestProfilePageChangePasswordButton()
        {
            Assert.AreEqual("Change Password | Learning management system", changePasswordPage.GetTitle());
        }



        [TearDown]
        public void Teardown()
        {
            // Clean up the WebDriver
            driver.Quit();
        }
        
    }
}
