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
    public class LoginPageTest
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private NewsAndEventsPage newsAndEventsPage;

        [SetUp]
        public void Setup()
        {
            // Set up the WebDriver
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            newsAndEventsPage = new NewsAndEventsPage(driver);
        }

        public void SucessfulLogin()
        {
            loginPage.GoToLoginPage();
            loginPage.EnterUsername("RADKHW");
            loginPage.EnterPassword("Saranga!890");
            loginPage.ClickLoginButton();
            Thread.Sleep(1000);
        }

        // Login Page Title
        [Test]
        public void TestHomePageTitle()
        {
            loginPage.GoToLoginPage();
            Assert.AreEqual("Dj Learning Management System - Login", loginPage.GetTitle());
        }

        // Login Negative - Incorrect Username
        [Test]
        public void TestLogin_IncorrectUsername()
        {
            loginPage.GoToLoginPage();
            loginPage.EnterUsername("asde");
            loginPage.EnterPassword("Saranga!890");
            loginPage.ClickLoginButton();
            Thread.Sleep(1000);
            //Assert.AreEqual("News & Events | Learning management system", newsAndEventsPage.GetTitle());
        }

        // Login Negative - Incorrect Password
        public void TestLogin_IncorrectPassword()
        {
            loginPage.GoToLoginPage();
            loginPage.EnterUsername("RADKHW");
            loginPage.EnterPassword("Sss!890");
            loginPage.ClickLoginButton();
            Thread.Sleep(1000);
            //Assert.AreEqual("News & Events | Learning management system", newsAndEventsPage.GetTitle());
        }

        // Login Negative - Null Username
        [Test]
        public void TestLogin_NullUsername()
        {
            loginPage.GoToLoginPage();
            loginPage.EnterUsername("");
            loginPage.EnterPassword("Saranga!890");
            loginPage.ClickLoginButton();
            Thread.Sleep(1000);
            //Assert.AreEqual("News & Events | Learning management system", newsAndEventsPage.GetTitle());
        }

        // Login Negative - Null Password
        [Test]
        public void TestLogin_NullPassword()
        {
            loginPage.GoToLoginPage();
            loginPage.EnterUsername("RADKHW");
            loginPage.EnterPassword("");
            loginPage.ClickLoginButton();
            Thread.Sleep(1000);
            //Assert.AreEqual("News & Events | Learning management system", newsAndEventsPage.GetTitle());
        }

        // Login Negative - Null Username and Password
        [Test]
        public void TestLogin_NullUsernameAndPassword()
        {
            loginPage.GoToLoginPage();
            loginPage.EnterUsername("");
            loginPage.EnterPassword("");
            loginPage.ClickLoginButton();
            Thread.Sleep(1000);
            //Assert.AreEqual("News & Events | Learning management system", newsAndEventsPage.GetTitle());
        }

        // Login Sucessful Login
        [Test]
        public void TestSucessfulLogin()
        {
            loginPage.GoToLoginPage();
            loginPage.EnterUsername("RADKHW");
            loginPage.EnterPassword("Saranga!890");
            loginPage.ClickLoginButton();
            Thread.Sleep(1000);
            Assert.AreEqual("News & Events | Learning management system", newsAndEventsPage.GetTitle());
        }


        // Add more test methods using the HomePage object

        
        [TearDown]
        public void Teardown()
        {
            // Clean up the WebDriver
            driver.Quit();
        }
        
    }
}
