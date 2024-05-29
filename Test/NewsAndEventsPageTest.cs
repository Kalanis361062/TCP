using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium_LMS.Source.Pages;
using OpenQA.Selenium.Support.UI;

namespace Selenium_LMS.Test
{
    [TestFixture]
    public class NewsAndEventsPageTest
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

        // News And Events Page Title
        [Test]
        public void TestNewsAndEventsPage_Title()
        {
            Assert.AreEqual("News & Events | Learning management system", newsAndEventsPage.GetTitle());
        }

        // News And Events Page Add New Post - News - sucess alert
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_News_SuccessAlert()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            newsAndEventsPage.EnterTitle("News Post 001");
            newsAndEventsPage.EnterSummary("News Test Summary 001");
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectNews();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("News Post 001 has been uploaded.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - News - Title
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_News_Title()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            newsAndEventsPage.EnterTitle("News Post 002");
            newsAndEventsPage.EnterSummary("News Test Summary 002");
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectNews();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("News Post 002", newsAndEventsPage.getNewsPostTitle());
        }

        // News And Events Page Add New Post - News - Summary
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_News_Summary()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            newsAndEventsPage.EnterTitle("News Post 003");
            newsAndEventsPage.EnterSummary("News Test Summary 003");
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectNews();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("News Test Summary 003", newsAndEventsPage.getNewsPostSummary());
        }

        // News And Events Page Add New Post - Event - success Alert
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_Event_SuccessAlert()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            newsAndEventsPage.EnterTitle("Event Post 001");
            newsAndEventsPage.EnterSummary("Event Test Summary");
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectEvent();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("Event Post 001 has been uploaded.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - Event - Title
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_Event_Title()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            newsAndEventsPage.EnterTitle("Event Post 002");
            newsAndEventsPage.EnterSummary("Event Test Summary 002");
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectEvent();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("Event Post 002", newsAndEventsPage.getEventPostTitle());
        }

        // News And Events Page Add New Post - Event - Summary
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_Event_Summary()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            newsAndEventsPage.EnterTitle("Event Post 003");
            newsAndEventsPage.EnterSummary("Event Test Summary 003");
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectEvent();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("Event Test Summary 003", newsAndEventsPage.getEventPostSummary());
        }

        // News And Events Page Add New Post - News - Edit Page
        [Test]
        public void TestNewsAndEventsPage_Edit_PageTitle()
        {
            newsAndEventsPage.ClickNewsPostDropdown();
            newsAndEventsPage.SelectEdit();
            Thread.Sleep(500);
            Assert.AreEqual("Edit Post | Learning management system", newsAndEventsPage.GetTitle());
        }

        // News And Events Page Add New Post - News - Edit - Cancel
        [Test]
        public void TestNewsAndEventsPage_EditPost_Cancel()
        {
            newsAndEventsPage.ClickNewsPostDropdown();
            newsAndEventsPage.SelectEdit();
            newsAndEventsPage.EnterTitle("Edited Title XXX");
            newsAndEventsPage.EnterSummary("Edited Summary XXX");
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectEvent();
            newsAndEventsPage.ClickAddNewPost_CancelButton();
            Thread.Sleep(500);
            Assert.AreEqual("News & Events | Learning management system", newsAndEventsPage.GetTitle());
        }


        // News And Events Page Add New Post - News - Edit
        [Test]
        public void TestNewsAndEventsPage_EditPost_Alert()
        {
            newsAndEventsPage.ClickNewsPostDropdown();
            newsAndEventsPage.SelectEdit();
            newsAndEventsPage.EnterTitle("Edited Title");
            newsAndEventsPage.EnterSummary("Edited Summary");
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectEvent();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("News Post 002Edited Title has been updated.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - Event - Delete
        [Test]
        public void TestNewsAndEventsPage_DeletePost_Alert()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            newsAndEventsPage.EnterTitle("Event Post 004");
            newsAndEventsPage.EnterSummary("Event Test Summary 004");
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectEvent();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            newsAndEventsPage.ClickPostToDelete();
            newsAndEventsPage.SelectDelete();
            Thread.Sleep(500);
            Assert.AreEqual("Event Post 004 has been deleted.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - Event - Title - Character Count - Greater than 201
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_Event_Title_MaxCharCount_Negative201()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            string title201 = "201TestCharacterCountMaxLBHgth200TestCharacterCountMaxLength200TestChara" +
                "cterCountMaxLength200TestCharacterCountMaxLength200TestCharacterCountMaxLength200Test" +
                "CharacterCountMaxLength200TestCharacterCount";
            newsAndEventsPage.EnterTitle(title201);
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectEvent();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("Maximum Characters Exeeded.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - Event -  Title - Character Count - Max 200
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_Event_Title_MaxCharCount_Positive200()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            string title200 = "200TestCharacterCountMaxLenKOh200TestCharacterCountMaxLength200TestChar" +
                "acterCountMaxLength200TestCharacterCountMaxLength200TestCharacterCountMaxLength200" +
                "TestCharacterCountMaxLength200TestCharacterCoun";
            newsAndEventsPage.EnterTitle(title200);
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectEvent();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual(title200+" has been uploaded.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - Event - Title - Character Count - Less than 200
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_Event_Title_MaxCharCount_Positive199()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            string title199 = "199TestCharacterCountMaxLenLDh200TtCharacterCountMaxLength200TestCha" +
                "racterCountMaxLength200TestCharacterCountMaxLength200TestCharacterCountMaxLength" +
                "200TestCharacterCountMaxLength200TestCharacterCount";
            newsAndEventsPage.EnterTitle(title199);
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectEvent();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual(title199 + " has been uploaded.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - News - Title - Character Count - Greater than 201
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_News_Title_MaxCharCount_Negative201()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            string title201 = "201TestCharacterCountMaxLKKgth200TestCharacterCountMaxLength200TestCha" +
                "racterCountMaxLength200TestCharacterCountMaxLength200TestCharacterCountMaxLength" +
                "200TestCharacterCountMaxLength200TestCharacterCount";
            newsAndEventsPage.EnterTitle(title201);
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectNews();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("Maximum Characters Exeeded.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - News -  Title - Character Count - Max 200
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_News_Title_MaxCharCount_Positive200()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            string title200 = "200TestCharacterCountMaJUength200TestCharacterCountMaxLength200Tes" +
                "tCharacterCountMaxLength200TestCharacterCountMaxLength200TestCharacterCountMaxL" +
                "ength200TestCharacterCountMaxLength200TestCharacterCoun";
            newsAndEventsPage.EnterTitle(title200);
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectNews();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual(title200 + " has been uploaded.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - News - Title - Character Count - Less than 200
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_News_Title_MaxCharCount_Positive199()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            string title199 = "199TestCharacterCouNYMaxLength200TtCharacterCountMaxLength200TestC" +
                "haracterCountMaxLength200TestCharacterCountMaxLength200TestCharacterCountMaxLeng" +
                "th200TestCharacterCountMaxLength200TestCharacterCount";
            newsAndEventsPage.EnterTitle(title199);
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectNews();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual(title199 + " has been uploaded.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - News - Summary - Character Count - Greater than 201
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_News_Summary_MaxCharCount_Negative201()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            string summary201 = "201VFstCharacterCountMaxLength200TestCharacterCountMaxLength200TestCh" +
                "aracterCountMaxLength200TestCharacterCountMaxLength200TestCharacterCountMaxLength200T" +
                "estCharacterCountMaxLength200TestCharacterCount";
            newsAndEventsPage.EnterTitle("Character Summary 201");
            newsAndEventsPage.EnterSummary(summary201);
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectNews();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("Maximum Characters Exeeded.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - News - Summary - Character Count - Max 200
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_News_Summary_MaxCharCount_Positive200()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            string summary200 = "200XCstCharacterCountMaxLength200TestCharacterCountMaxLength200TestCh" +
                "aracterCountMaxLength200TestCharacterCountMaxLength200TestCharacterCountMaxLength200T" +
                "estCharacterCountMaxLength200TestCharacterCoun";
            newsAndEventsPage.EnterTitle("Character Summary 201");
            newsAndEventsPage.EnterSummary(summary200);
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectNews();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("Character Summary 201 has been uploaded.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - News - Summary - Character Count - Less than 200
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_News_Summary_MaxCharCount_Positive199()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            string summary199 = "199NSstCharacterCountMaxLength200TtCharacterCountMaxLength200TestCharacterCo" +
                "untMaxLength200TestCharacterCountMaxLength200TestCharacterCountMaxLength200TestCharacterCo" +
                "untMaxLength200TestCharacterCount";
            newsAndEventsPage.EnterTitle("Character Summary 199");
            newsAndEventsPage.EnterSummary(summary199);
            newsAndEventsPage.SelectNews();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("Character Summary 199 has been uploaded.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - Event - Summary - Character Count - Greater than 201
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_Event_Summary_MaxCharCount_Negative201()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            string summary201 = "201EventSummaryrCountMaxLjjength200TtCharacterCountMaxLength200TestCharacterCount" +
                "MaxLength200TestCharacterCountMaxLength200TestCharacterCountMaxLength200TestCharacterCountM" +
                "axLength200TestCharacterCount";
            newsAndEventsPage.EnterTitle("Character Summary 201");
            newsAndEventsPage.EnterSummary(summary201);
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectEvent();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("Maximum Characters Exeeded.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - Event - Summary - Character Count - Max 200
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_Event_Summary_MaxCharCount_Positive200()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            string summary200 = "200EventSummaryryCountMaxLength200TtCharacterCountMaxLength200TestCharacterCou" +
                "ntMaxLength200TestCharacterCountMaxLength200TestCharacterCountMaxLength200TestCharacterCount" +
                "MaxLength200TestCharacterCount";
            newsAndEventsPage.EnterTitle("Character Summary 201");
            newsAndEventsPage.EnterSummary(summary200);
            newsAndEventsPage.ClickPostedasDropdown();
            newsAndEventsPage.SelectEvent();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("Character Summary 201 has been uploaded.", newsAndEventsPage.getAlert().ToString());
        }

        // News And Events Page Add New Post - Event - Summary - Character Count - Less than 200
        [Test]
        public void TestNewsAndEventsPage_AddNewPost_Event_Summary_MaxCharCount_Positive199()
        {
            newsAndEventsPage.ClickAddNewPostButton();
            string summary199 = "199EventSummaryrCountMaxLength200TtCharacterCountMaxLength200TestCharacterCount" +
                "MaxLength200TestCharacterCountMaxLength200TestCharacterCountMaxLength200TestCharacterCountMaxL" +
                "ength200TestCharacterCount";
            newsAndEventsPage.EnterTitle("Character Summary 199");
            newsAndEventsPage.EnterSummary(summary199);
            newsAndEventsPage.SelectEvent();
            newsAndEventsPage.ClickAddNewPost_SaveButton();
            Thread.Sleep(500);
            Assert.AreEqual("Character Summary 199 has been uploaded.", newsAndEventsPage.getAlert().ToString());
        }


        [TearDown]
        public void Teardown()
        {
            // Clean up the WebDriver
            driver.Quit();
        }


    }
}
