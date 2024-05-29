using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_LMS.Source.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        // WebElements
        private IWebElement usernameInput => driver.FindElement(By.Id("username_id"));
        private IWebElement passwordInput => driver.FindElement(By.Id("password_id"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//button[@type='submit']"));

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToLoginPage()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:8000/");
        }

        public string GetTitle()
        {
            return driver.Title;
        }

        public void EnterUsername(string username)
        {
            usernameInput.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            passwordInput.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            loginButton.Click();
        }
    }
}
