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
        private IWebElement navigateToChart => driver.FindElement(By.CssSelector("#menu-main-menu > li.woo-menu-icon.wcmenucart-toggle-drop_down.toggle-cart-widget"));
        private IWebElement productAdded => driver.FindElement(By.CssSelector("#content > article > div.woocommerce-notices-wrapper > div"));
        private IWebElement increaseProductInCart => driver.FindElement(By.ClassName("plus"));
        private IWebElement billingButtonVisible => driver.FindElement(By.CssSelector("#content > article > div > div:nth-child(1) > div.wpb_column.vc_column_container.vc_col-sm-10 > div > div > div > div.cart-collaterals > div > div > a"));
        private IWebElement cartUpdate => driver.FindElement(By.Name("update_cart"));
       // private IWebElement popUpMessage => driver.FindElement(By.XPath("//*[@id='content']/article/div/div[1]/div[1]/div/div/div/div[1]/div"));
        public void AddToCart()
        {
            searchIcon.Click();
            search.SendKeys("Alpha Spirit tik su žuvimi" + Keys.Enter);
            findItem.Click();
            addToCart.Click();
        }
        public void AssertAddedToCart(string productInTheCart)
        {
            Assert.AreEqual(productInTheCart, productAdded.Text);
        }

        public void CartPreview()
        {
            searchIcon.Click();
            search.SendKeys("Alpha Spirit tik su žuvimi" + Keys.Enter);
            findItem.Click();
            addToCart.Click();
            navigateToChart.Click();
        }
        public void AssertContinueBillingButtonVisible(string buttonMessage)
        {
            Assert.AreEqual(buttonMessage, billingButtonVisible.Text);
        }
        /*public void IncreaseProductUpdate()
        {
            increaseProductInCart.Click();
            cartUpdate.Click();
        }
        public void AssertMessagePopUp()
        {
            Assert.IsTrue(popUpMessage.Displayed);
        } */
    }
}
