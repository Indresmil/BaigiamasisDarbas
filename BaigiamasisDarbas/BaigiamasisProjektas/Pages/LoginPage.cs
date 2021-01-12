using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.BaigiamasisProjektas.Pages
{
    class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        private IWebElement navigate => driver.FindElement(By.LinkText("MANO UŽSAKYMAI"));
        private IWebElement username => driver.FindElement(By.Name("username"));
        private IWebElement password => driver.FindElement(By.Name("password"));
        private IWebElement logoutButton => driver.FindElement(By.CssSelector("#content > article > div > div > div.woocommerce-MyAccount-content > p:nth-child(2) > a"));

        public void NavigateToLoginPage()
        {
            navigate.Click();
        }
        public void IncorrectUsernameInput()
        {
            username.SendKeys("indre@gmail.com");
        }
        public void UsernameInput()
        {
            username.SendKeys("indre.smilgaityte@gmail.com");
        }
        public void PasswordInput()
        {
            password.SendKeys("slaptazodis123" + Keys.Enter);
        }
        public void IncorrectPasswordInput()
        {
            password.SendKeys("slaptazodis" + Keys.Enter);
        }
        public void AssertLogoutButtonVisible()
        {
            Assert.IsTrue(logoutButton.Displayed);
        }
        public void AssertIncorrectPassword()
        {
            Assert.AreEqual("KLAIDA: Neteisingas vartotojo vardas arba slaptažodis.", driver.FindElement(By.CssSelector("#content > article > div > div > div.woocommerce-notices-wrapper > ul > li")).Text);
        }
        public void AssertIncorrectUsername()
        {
            Assert.AreEqual("KLAIDA: Neteisingas vartotojo vardas arba slaptažodis.", driver.FindElement(By.CssSelector("#content > article > div > div > div.woocommerce-notices-wrapper > ul > li")).Text);
        }
    }

}
