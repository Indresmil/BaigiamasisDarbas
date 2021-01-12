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
            loginPage.IncorrectUsernameInput();
            loginPage.PasswordInput();
            loginPage.AssertIncorrectUsername();
        }

        [Test]
        public void IncorrectPassword()
        {
            loginPage.NavigateToLoginPage();
            loginPage.UsernameInput();
            loginPage.IncorrectPasswordInput();
            loginPage.AssertIncorrectPassword();
        }

        [Test]
        public void UserLogin()
        {
            loginPage.NavigateToLoginPage();
            loginPage.UsernameInput();
            loginPage.PasswordInput();
            loginPage.AssertLogoutButtonVisible();   
        }
    }

}
