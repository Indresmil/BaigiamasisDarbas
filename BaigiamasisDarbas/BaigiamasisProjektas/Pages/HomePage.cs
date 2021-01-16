using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.BaigiamasisProjektas.Pages
{
    class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        private IWebElement searchIcon => driver.FindElement(By.ClassName("icon-magnifier"));
        private IWebElement search => driver.FindElement(By.Name("s"));
        private IWebElement item => driver.FindElement(By.LinkText("DOG Copenhagen petnešos Comfort walk Pro NAUJAS MODELIS"));
        private IWebElement color => driver.FindElement(By.CssSelector("#pa_dydis"));
        private IWebElement colorSelect => driver.FindElement(By.CssSelector("#pa_spalva > option:nth-child(7)"));
        private IWebElement size => driver.FindElement(By.CssSelector("#pa_dydis"));
        private IWebElement sizeSelect => driver.FindElement(By.CssSelector("#pa_dydis > option:nth-child(2)"));
        private IWebElement facebook => driver.FindElement(By.CssSelector("#social-icons > a:nth-child(1) > i"));
        private IWebElement facebookText => driver.FindElement(By.Id("u_0_h"));
        private IWebElement instagram => driver.FindElement(By.CssSelector("#social-icons > a:nth-child(2) > i"));
        private IWebElement instagramText => driver.FindElement(By.CssSelector("body > div.RnEpo.Yx5HN > div > div > div > div.mt3GC > button.aOOlW.bIiDR"));

        public void NavigateToSearch()
        {
            searchIcon.Click();
        }
        public void CorrectSearch(string product)
        {
            search.SendKeys(product + Keys.Enter);
        }
        public void CorrectSearhClick()
        {
            item.Click();
        }
        public void AssertCorrectSearch(string pickProduct)
        {
            Assert.AreEqual(pickProduct, item.Text);
        }
        public void SelectColor()
        {
            colorSelect.Click();
        }
        public void AssertColorSelect(string pickColor)
        {
            Assert.AreEqual(pickColor, colorSelect.Text);
        }
        public void SelectSize()
        {
            sizeSelect.Click();
        }
        public void AssertSizeSelect(string pickSize)
        {
            Assert.AreEqual(pickSize, sizeSelect.Text);
        }
        public void FacebookClick()
        {
            facebook.Click();
        }
        public void AssertFacebookWorking()
        {
            Assert.IsTrue(facebookText.Displayed);
        }
        public void InstagramClick()
        {
            instagram.Click();
        }
        public void AssertInstagramWorking()
        {
            Assert.IsTrue(instagramText.Displayed);
        }
    }
}
