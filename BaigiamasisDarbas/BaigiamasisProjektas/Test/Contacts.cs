using BaigiamasisDarbas.BaigiamasisProjektas.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.BaigiamasisProjektas.Test
{
    class Contacts : BaseTests
    {
        private ContactsPage contactsPage;

        [SetUp]
        public void BeforeTest()
        {
            contactsPage = new ContactsPage(driver);
        }

        [Test]
        public void AddToCart()
        {
            contactsPage.GoToContacts();
            contactsPage.AssertContactsPageWorking();
        }

        [Test]
        public void IncorrectEmailMessageShow()
        {
            contactsPage.GoToContacts();
            contactsPage.AddToEmailLine("a");
            contactsPage.AssertIncorectEmail("Please enter a valid email address.");
        }
        [Test]
        public void FillNameFieldMessageShow()
        {
            contactsPage.GoToContacts();
            contactsPage.AddToEmailLine("a@gmail.com");
            contactsPage.AssertFillInNameField("Šis laukas privalomas.");
        }
    }
}

