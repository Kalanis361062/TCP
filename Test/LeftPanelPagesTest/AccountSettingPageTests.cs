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
    public class AccountSettingPageTests
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;
        private AccountSettingPage accountSettingPage;
        private ProfilePage profilePage;

        [SetUp]
        public void Setup()
        {
            // Set up the WebDriver
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            accountSettingPage = new AccountSettingPage(driver);
            profilePage = new ProfilePage(driver);
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
            homePage.ClickAccountSetting();
        }

        // Account Setting Page Title
        [Test]
        public void TestAccountSettingPageTitle()
        {            
            Assert.AreEqual("Account Settings | Learning management system", accountSettingPage.GetTitle());
        }

        // Account Setting Page Heading
        [Test]
        public void TestAccountSettingPageHeading()
        {
            Assert.AreEqual("Account Settings", accountSettingPage.GetHeading());
        }


        // Account Setting Page First Name Label
        [Test]
        public void TestAccountSettingPageFirstNameLabel()
        {
            Assert.AreEqual("First Name*", accountSettingPage.GetFirstNameLabel());
        }

        // Account Setting Page Last Name Label
        [Test]
        public void TestAccountSettingPageLastNameLabel()
        {
            Assert.AreEqual("Last Name*", accountSettingPage.GetLastNameLabel());
        }

        // Account Setting Page Email Label
        [Test]
        public void TestAccountSettingPageEmailLabel()
        {
            Assert.AreEqual("Email Address*", accountSettingPage.GetEmailLabel());
        }

        // Account Setting Page Gender Label
        [Test]
        public void TestAccountSettingPageGenderLabel()
        {
            Assert.AreEqual("Gender*", accountSettingPage.GetGenderLabel());
        }

        // Account Setting Page Phone Label
        [Test]
        public void TestAccountSettingPagePhoneLabel()
        {
            Assert.AreEqual("Phone No.*", accountSettingPage.GetPhoneLabel());
        }

        // Account Setting Page Address Label
        [Test]
        public void TestAccountSettingPageAddressLabel()
        {
            Assert.AreEqual("Address / city*", accountSettingPage.GetAddressLabel());
        }

        // Account Setting Page Update First Name
        [Test]
        public void TestAccountSettingPageUpdateFirstName()
        {
            accountSettingPage.EnterFirstName("Polar");
            accountSettingPage.ClickUpdateProfileButton();
            Thread.Sleep(100);
            Assert.AreEqual("First Name: Polar", profilePage.GetFirstName());
        }

        // Account Setting Page Update Last Name
        [Test]
        public void TestAccountSettingPageUpdateLastName()
        {
            accountSettingPage.EnterLastName("Bear");
            accountSettingPage.ClickUpdateProfileButton();
            Thread.Sleep(100);
            Assert.AreEqual("Last Name: Bear", profilePage.GetLastName());
        }

        // Account Setting Page Update Email
        [Test]
        public void TestAccountSettingPageUpdateEmail()
        {
            accountSettingPage.EnterEmail("khwijayawardana@gmail.com");
            accountSettingPage.ClickUpdateProfileButton();
            Thread.Sleep(100);
            Assert.AreEqual("Email: khwijayawardana@gmail.com", profilePage.GetEmail());
        }

        // Account Setting Page Update Phone
        [Test]
        public void TestAccountSettingPageUpdatePhone()
        {
            accountSettingPage.EnterPhone("1231241414");
            accountSettingPage.ClickUpdateProfileButton();
            Thread.Sleep(100);
            Assert.AreEqual("Tel No.: 1231241414", profilePage.GetPhone());
        }

        // Account Setting Page Update Address
        [Test]
        public void TestAccountSettingPageUpdateAddress()
        {
            accountSettingPage.EnterAddress("1231241414");
            accountSettingPage.ClickUpdateProfileButton();
            Thread.Sleep(100);
            Assert.AreEqual("Address/city: Casuarina", profilePage.GetAddress());
        }

        // Account Setting Page Update Full Name
        [Test]
        public void TestAccountSettingPageUpdateFullName()
        {
            accountSettingPage.EnterFirstName("Polar");
            accountSettingPage.EnterLastName("Bear");
            accountSettingPage.ClickUpdateProfileButton();
            Thread.Sleep(100);
            Assert.AreEqual("Polar Bear", profilePage.GetFullName());
        }

        // Account Setting Page Update - Verify Successful Update Notification in Profile 
        [Test]
        public void TestAccountSettingPageUpdateNotification()
        {
            accountSettingPage.EnterFirstName("Polar");
            accountSettingPage.ClickUpdateProfileButton();
            Thread.Sleep(100);
            Assert.AreEqual("Your profile has been updated successfully.", profilePage.GetAlert());
        }

        //// 
        [Test]
        public void TestAccountSettingPageFirstNameMandatory()
        {
            accountSettingPage.EnterFirstName("Polar");
            accountSettingPage.ClickUpdateProfileButton();
            Thread.Sleep(100);
            Assert.AreEqual("MandatoryField missing", profilePage.GetAlert());
        }

        // Account Setting Page Update - Verify Successful Update Notification in Profile 
        [Test]
        public void TestAccountSettingPageLastNameMandatory()
        {
            accountSettingPage.EnterLastName("");
            accountSettingPage.ClickUpdateProfileButton();
            Thread.Sleep(100);
            Assert.AreEqual("MandatoryField missing", profilePage.GetAlert());
        }

        // Account Setting Page Update - Verify Successful Update Notification in Profile 
        [Test]
        public void TestAccountSettingPageEmailMandatory()
        {
            accountSettingPage.EnterEmail("");
            accountSettingPage.ClickUpdateProfileButton();
            Thread.Sleep(100);
            Assert.AreEqual("MandatoryField missing", profilePage.GetAlert());
        }

        [TearDown]
        public void Teardown()
        {
            // Clean up the WebDriver
            driver.Quit();
        }
        
    }
}
