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
            loginPage.NavigateToLoginPage();
            loginPage.UsernameInput("indre@gmail.com");
            loginPage.PasswordInput("slaptazodis123");
            loginPage.AssertIncorrectUsername("KLAIDA: Neteisingas vartotojo vardas arba slaptažodis.");
        }

        [Test]
        public void IncorrectPassword()
        {
            loginPage.NavigateToLoginPage();
            loginPage.UsernameInput("indre.smilgaityte@gmail.com");
            loginPage.PasswordInput("slaptazodis");
            loginPage.AssertIncorrectPassword("KLAIDA: Neteisingas vartotojo vardas arba slaptažodis.");
        }

        [Test]
        public void PasswordKeySensitive()
        {
            loginPage.NavigateToLoginPage();
            loginPage.UsernameInput("indre.smilgaityte@gmail.com");
            loginPage.PasswordInput("SLAPTAZODIS123");
            loginPage.AssertIncorrectPassword("KLAIDA: Neteisingas vartotojo vardas arba slaptažodis.");
        }

        [Test]
        public void UsernameKeyInsensitive()
        {
            loginPage.NavigateToLoginPage();
            loginPage.UsernameInput("INDRE.SMILGAITYTE@gmail.com");
            loginPage.PasswordInput("slaptazodis123");
            loginPage.AssertLogoutButtonVisible();
        }

        [Test]
        public void UserLogin()
        {
            loginPage.NavigateToLoginPage();
            loginPage.UsernameInput("indre.smilgaityte@gmail.com");
            loginPage.PasswordInput("slaptazodis123");
            loginPage.AssertLogoutButtonVisible();
        }
    }
}


