using BaigiamasisDarbas.BaigiamasisProjektas.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.BaigiamasisProjektas.Test
{
    class Login : BaseTests
    {
        private LoginPage loginPage;


        [SetUp]
        public void Beforetest()
        {
            loginPage = new LoginPage(driver);
        }

        [Test]
        public void IncorrectUserName()
        {
            loginPage
                .NavigateToLoginPage()
                .UsernameInput("indre@gmail.com")
                .PasswordInput("slaptazodis123")
                .AssertIncorrectUsername("KLAIDA: Neteisingas vartotojo vardas arba slaptažodis.");
        }

        [Test]
        public void IncorrectPassword()
        {
            loginPage
                .NavigateToLoginPage()
                .UsernameInput("indre.smilgaityte@gmail.com")
                .PasswordInput("slaptazodis")
                .AssertIncorrectPassword("KLAIDA: Neteisingas vartotojo vardas arba slaptažodis.");
        }
        [Test]
        public void UsernameKeyInsensitive()
        {
            loginPage
                .NavigateToLoginPage()
                .UsernameInput("INDRE.SMILGAITYTE@gmail.com")
                .PasswordInput("slaptazodis123")
                .AssertLogoutButtonVisible();
        }

        [Test]
        public void PasswordKeySensitive()
        {
            loginPage
                .NavigateToLoginPage()
                .UsernameInput("indre.smilgaityte@gmail.com")
                .PasswordInput("SLAPTAZODIS123")
                .AssertIncorrectPassword("KLAIDA: Neteisingas vartotojo vardas arba slaptažodis.");
        }

        [Test]
        public void UserLogin()
        {
            loginPage
                .NavigateToLoginPage()
                .UsernameInput("indre.smilgaityte@gmail.com")
                .PasswordInput("slaptazodis123")
                .AssertLogoutButtonVisible();
        }
    }
}


