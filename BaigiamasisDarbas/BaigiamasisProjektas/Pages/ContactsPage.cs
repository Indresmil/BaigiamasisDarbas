﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.BaigiamasisProjektas.Pages
{
    class ContactsPage : BasePage
    {
        public ContactsPage(IWebDriver driver) : base(driver) { }

        private IWebElement contacts => driver.FindElement(By.Id("menu-item-2167"));
        private IWebElement contactsPageInfo => driver.FindElement(By.CssSelector("#wpforms-form-12231 > div.wpforms-head-container > div"));
        private IWebElement enterEmail => driver.FindElement(By.Id("wpforms-12231-field_1"));
        private IWebElement enterIncorrectEmail => driver.FindElement(By.Id("wpforms-12231-field_1-error"));
        private IWebElement nameField => driver.FindElement(By.Id("wpforms-12231-field_0"));
        private IWebElement nameFieldError => driver.FindElement(By.Id("wpforms-12231-field_0-error"));
        public ContactsPage GoToContacts()
        {
            contacts.Click();
            return this;
        }
        public ContactsPage AssertContactsPageWorking()
        {
            Assert.AreEqual("SUSISIEKITE SU MUMIS", contactsPageInfo.Text);
            return this;
        }
        public ContactsPage AddToEmailLine(string email)
        {
            enterEmail.SendKeys(email + Keys.Enter);
            return this;
        }
        public ContactsPage AssertIncorectEmail(string emailMessage) 
        {
            Assert.AreEqual(emailMessage, enterIncorrectEmail.Text);
            return this;
        }
        public ContactsPage AssertFillInNameField(string nameFieldMessage)
        {
            Assert.AreEqual(nameFieldMessage, nameFieldError.Text);
            return this;
        }
    }    
}
