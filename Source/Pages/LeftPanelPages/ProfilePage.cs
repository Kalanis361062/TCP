using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_LMS.Source.Pages
{
    public class ProfilePage
    {
        private IWebDriver driver;

        //IWebElement
        private IWebElement pageHeading => driver.FindElement(By.XPath("//div[@id='main']/div[2]/div/h1"));

        private IWebElement fullName => driver.FindElement(By.XPath("//ul[@class='px-2 list-unstyled']/li[1]"));

        private IWebElement lastLogin => driver.FindElement(By.XPath("//ul[@class='px-2 list-unstyled']/li[2]"));

        private IWebElement role => driver.FindElement(By.XPath("//ul[@class='px-2 list-unstyled']/li[3]"));

        private IWebElement personalInfo => driver.FindElement(By.XPath("//div[@class='card-body']/p[1]"));

        private IWebElement firstName => driver.FindElement(By.XPath("//div[@class='card-body']/p[1]/../div[1]/p[1]"));

        private IWebElement lastName => driver.FindElement(By.XPath("//div[@class='card-body']/p[1]/../div[1]/p[2]"));

        private IWebElement idNo => driver.FindElement(By.XPath("//div[@class='card-body']/p[1]/../div[1]/p[3]"));

        private IWebElement contactInfo => driver.FindElement(By.XPath("//div[@class='card-body']/p[2]"));

        private IWebElement email => driver.FindElement(By.XPath("//div[@class='card-body']/p[2]/../div[2]/p[1]"));

        private IWebElement phone => driver.FindElement(By.XPath("//div[@class='card-body']/p[2]/../div[2]/p[2]"));

        private IWebElement address => driver.FindElement(By.XPath("//div[@class='card-body']/p[2]/../div[2]/p[3]"));

        private IWebElement importantDates => driver.FindElement(By.XPath("//div[@class='card-body']/p[3]"));

        private IWebElement lastLoginDateAndTime => driver.FindElement(By.XPath("//div[@class='card-body']/p[3]/../div[3]/p[1]"));

        private IWebElement registeredDate => driver.FindElement(By.XPath("//div[@class='card-body']/p[3]/../div[3]/p[2]"));

        private IWebElement editProfileButton => driver.FindElement(By.XPath("//*[contains(text(),'Edit Profile')]"));

        private IWebElement changePasswordButton => driver.FindElement(By.XPath("//*[contains(text(),'Change password')]"));

        private IWebElement updateSuccessAlert => driver.FindElement(By.XPath("//div[@class='alert py-2 alert-success']"));

        public ProfilePage(IWebDriver driver)
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

        public string GetFullName()
        {
            return fullName.Text;
        }

        public string GetLastLogin()
        {
            return lastLogin.Text;
        }

        public string GetRole()
        {
            return role.Text;
        }

        public string GetPersonalInfoHeading()
        {
            return personalInfo.Text;
        }

        public string GetFirstName()
        {
            return firstName.Text;
        }

        public string GetLastName()
        {
            return lastName.Text;
        }

        public string GetId()
        {
            return idNo.Text;
        }

        public string GetContactInfoHeading()
        {
            return contactInfo.Text;
        }

        public string GetEmail()
        {
            return email.Text;
        }

        public string GetPhone()
        {
            return phone.Text;
        }

        public string GetAddress()
        {
            return address.Text;
        }

        public string GetImportantDatesHeading()
        {
            return importantDates.Text;
        }

        public string GetRegisteredDate()
        {
            return registeredDate.Text;
        }

        public string GetLastLoginDateAndTime()
        {
            return lastLoginDateAndTime.Text;
        }

        public void ClickEditProfileButton()
        {
            editProfileButton.Click();
        }

        public void ClickChangePasswordButton()
        {
            changePasswordButton.Click();
        }

        public string GetAlert()
        {
            return updateSuccessAlert.Text;
        }
    }
}
