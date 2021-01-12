using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.BaigiamasisProjektas.Pages
{
    class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver) { }

        private IWebElement searchIcon => driver.FindElement(By.ClassName("icon-magnifier"));
        private IWebElement search => driver.FindElement(By.Name("s"));
        private IWebElement findItem => driver.FindElement(By.LinkText("Alpha Spirit tik su žuvimi, 200 gr"));
        private IWebElement addToCart => driver.FindElement(By.CssSelector("#product-4292 > div.summary.entry-summary > form > button"));


        public void AddToCart()
        {
            searchIcon.Click();
            search.SendKeys("Alpha Spirit tik su žuvimi" + Keys.Enter);
            findItem.Click();
            addToCart.Click();
        }

        public void AssertAddedToCart()
        {
            Assert.AreEqual("“Alpha Spirit tik su žuvimi, 200 gr” - įdėtas į krepšelį", driver.FindElement(By.CssSelector("#content > article > div.woocommerce-notices-wrapper > div")).Text);
        }
    
    }
}
