using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_LMS.Source.Pages
{
    public class AccountSettingPage
    {
        private IWebDriver driver;

        //IWebElement
        private IWebElement pageHeading => driver.FindElement(By.XPath("//div[@id='main']/div[2]/div/h1")); 

        private IWebElement emailLabel => driver.FindElement(By.XPath("//label[@for='id_email']"));

        private IWebElement firstNameLabel => driver.FindElement(By.XPath("//label[@for='id_first_name']"));

        private IWebElement lastNameLabel => driver.FindElement(By.XPath("//label[@for='id_last_name']"));

        private IWebElement genderLabel => driver.FindElement(By.XPath("//label[@for='id_gender']"));

        private IWebElement phoneLabel => driver.FindElement(By.XPath("//label[@for='id_phone']"));

        private IWebElement addressLabel => driver.FindElement(By.XPath("//label[@for='id_address']"));

        private IWebElement emailText => driver.FindElement(By.XPath("//input[@type='text' and @name='email']"));

        private IWebElement firstNameText => driver.FindElement(By.XPath("//input[@type='text' and @name='first_name']"));

        private IWebElement lastNameText => driver.FindElement(By.XPath("//input[@type='text' and @name='last_name']"));

        private IWebElement genderDropdowwn => driver.FindElement(By.XPath("//input[@id='id_gender' and @name='gender']"));

        private IWebElement phoneText => driver.FindElement(By.XPath("//input[@type='text' and @name='phone']"));

        private IWebElement addressText => driver.FindElement(By.XPath("//input[@type='text' and @name='address']"));

        private IWebElement updateProfileButton => driver.FindElement(By.XPath("//button[@class='btn btn-primary' and @type='submit']"));


        public AccountSettingPage(IWebDriver driver)
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

        public string GetFirstNameLabel()
        {
            return firstNameLabel.Text;
        }

        public string GetFirstNameText()
        {
            return firstNameText.Text;
        }

        public void EnterFirstName(string firstName)
        {
            firstNameText.SendKeys(firstName);
        }

        public string GetLastNameLabel()
        {
            return lastNameLabel.Text;
        }

        public string GetLastNameText()
        {
            return lastNameText.Text;
        }

        public void EnterLastName(string lastName)
        {
            lastNameText.SendKeys(lastName);
        }

        public string GetEmailLabel()
        {
            return emailLabel.Text;
        }

        public string GetEmailText()
        {
            return emailText.Text;
        }

        public void EnterEmail(string email)
        {
            emailText.SendKeys(email);
        }

        public string GetPhoneLabel()
        {
            return phoneLabel.Text;
        }

        public string GetPhoneText()
        {
            return phoneText.Text;
        }

        public void EnterPhone(string phone)
        {
            phoneText.SendKeys(phone);
        }

        public string GetAddressLabel()
        {
            return addressLabel.Text;
        }

        public string GetAddressText()
        {
            return addressText.Text;
        }

        public void EnterAddress(string address)
        {
            addressText.SendKeys(address);
        }

        public string GetGenderLabel()
        {
            return genderLabel.Text;
        }

        public void ClickGenderDropdown()
        {
            genderDropdowwn.Click();
        }

        public void SelectMale()
        {
            SelectElement dropDown = new SelectElement(genderDropdowwn);
            dropDown.SelectByText("Male");
        }

        public void SelectFemale()
        {
            SelectElement dropDown = new SelectElement(genderDropdowwn);
            dropDown.SelectByText("Female");
        }

        public void ClickUpdateProfileButton()
        {
            updateProfileButton.Click();
        }

    }
}
