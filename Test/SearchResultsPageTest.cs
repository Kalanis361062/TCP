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
    public class SearchResultsPageTest
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;
        private SearchResultsPage searchResultsPage;
        private NewsAndEventsPage newsAndEventsPage;

        [SetUp]
        public void Setup()
        {
            // Set up the WebDriver
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            newsAndEventsPage = new NewsAndEventsPage(driver);
            searchResultsPage = new SearchResultsPage(driver);
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

        // Search Results Page Title
        [Test]
        public void TestSearchResultsPageTitle()
        {
            homePage.EnterKeyword("TT");
            homePage.ClickSearchButton();
            Assert.AreEqual("Search result for TT | Learning management system", searchResultsPage.GetTitle());
        }

        // Search Key Word
        [Test]
        public void TestSearchFullKeyword()
        {
            // Add new post
            newsAndEventsPage.ClickAddNewPostButton();
            newsAndEventsPage.EnterTitle("KW");
            newsAndEventsPage.EnterSummary("Sumsum");
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectNews();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("KW has been uploaded.", newsAndEventsPage.getAlert().ToString());

            // Search added post
            homePage.EnterKeyword("KW");
            homePage.ClickSearchButton();
            Assert.AreEqual("1 result for KW", searchResultsPage.getResultsCount());
        }

        // Search Key Word
        [Test]
        public void TestSearchKeywordWithMultipleResults()
        {
            // Add new post
            newsAndEventsPage.ClickAddNewPostButton();
            newsAndEventsPage.EnterTitle("PRT1234");
            newsAndEventsPage.EnterSummary("Sumsum");
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectNews();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);

            newsAndEventsPage.ClickAddNewPostButton();
            newsAndEventsPage.EnterTitle("PRT1235");
            newsAndEventsPage.EnterSummary("Sumsum");
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectNews();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);

            newsAndEventsPage.ClickAddNewPostButton();
            newsAndEventsPage.EnterTitle("PRT1236");
            newsAndEventsPage.EnterSummary("Sumsum");
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectNews();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);

            // Search added post
            homePage.EnterKeyword("PRT123");
            homePage.ClickSearchButton();
            Assert.AreEqual("3 results for PRT123", searchResultsPage.getResultsCount());
        }

        // Search Key Word with zero results
        [Test]
        public void TestZeroSearchResults()
        {
            homePage.EnterKeyword("CAT");
            homePage.ClickSearchButton();
            Assert.AreEqual("0 results for CAT", searchResultsPage.getResultsCount());
        }


        [TearDown]
        public void Teardown()
        {
            // Clean up the WebDriver
            driver.Quit();
        }

    }
}
