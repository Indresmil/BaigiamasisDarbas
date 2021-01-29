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
        public void ContactPageWorking()
        {
            contactsPage
                .GoToContacts()
                .AssertContactsPageWorking();
        }

        [Test]
        public void IncorrectEmailMessageShow()
        {
            contactsPage
                .GoToContacts()
                .AddToEmailLine("a")
                .AssertIncorectEmail("Please enter a valid email address.");
        }
        [Test]
        public void FillNameFieldMessageShow()
        {
            contactsPage
                .GoToContacts()
                .AddToEmailLine("a@gmail.com")
                .AssertFillInNameField("Šis laukas privalomas.");
        }
    }
}

