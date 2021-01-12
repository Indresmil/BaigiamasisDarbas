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
        private IWebElement errrorMessage => driver.FindElement(By.CssSelector("#content > article > div > div > div.woocommerce-notices-wrapper > ul > li"));
        public void NavigateToLoginPage()
        {
            navigate.Click();
        }
        public void UsernameInput(string vardas)
        {
            username.SendKeys(vardas);
        }
        public void PasswordInput(string slaptazodis)
        {
            password.SendKeys(slaptazodis + Keys.Enter);
        }
        public void AssertLogoutButtonVisible()
        {
            Assert.IsTrue(logoutButton.Displayed);
        }
        public void AssertIncorrectPassword()
        {
            Assert.AreEqual("KLAIDA: Neteisingas vartotojo vardas arba slaptažodis.", errrorMessage.Text);
        }
        public void AssertIncorrectUsername()
        {
            Assert.AreEqual("KLAIDA: Neteisingas vartotojo vardas arba slaptažodis.", errrorMessage.Text);
        }
    }

}
