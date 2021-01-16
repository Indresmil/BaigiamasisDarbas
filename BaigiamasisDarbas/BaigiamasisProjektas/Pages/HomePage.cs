using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
        private IWebElement instagram => driver.FindElement(By.CssSelector("#social-icons > a:nth-child(2) > i"));
        private IWebElement termsAndConditions => driver.FindElement(By.CssSelector("#text-9 > div > p > a:nth-child(1)"));
        private IWebElement commentButton => driver.FindElement(By.Id("comment-submit"));
        public HomePage NavigateToSearch()
        {
            searchIcon.Click();
            return this;
        }
        public HomePage CorrectSearch(string product)
        {
            search.SendKeys(product + Keys.Enter);
            return this;
        }
        public HomePage CorrectSearhClick()
        {
            item.Click();
            return this;
        }
        public HomePage AssertCorrectSearch(string pickProduct)
        {
            Assert.AreEqual(pickProduct, item.Text);
            return this;
        }
        public HomePage SelectColor()
        {
            colorSelect.Click();
            return this;
        }
        public HomePage AssertColorSelect(string pickColor)
        {
            Assert.AreEqual(pickColor, colorSelect.Text);
            return this;
        }
        public HomePage SelectSize()
        {
            sizeSelect.Click();
            return this;
        }
        public HomePage AssertSizeSelect(string pickSize)
        {
            Assert.AreEqual(pickSize, sizeSelect.Text);
            return this;
        }
        public HomePage FacebookClick()
        {
            facebook.Click();
            return this;
        }
        public HomePage AssertFacebookWorking()
        {
            Assert.AreEqual("https://www.facebook.com/letenos/", driver.Url);
            return this;
        }
        public HomePage InstagramClick()
        {
            instagram.Click();
            return this;
        }
        public HomePage AssertInstagramWorking()
        {
            Assert.AreEqual("https://www.instagram.com/letenos.lt/", driver.Url);
            return this;
        }
        public HomePage TermsAndConditionsInfo()
        {
            termsAndConditions.Click();
            return this;
        }
        public HomePage AssertTermsAndConditionsInfoPageWorking()
        {
            //((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 1000)");
            Assert.IsTrue(commentButton.Displayed);
            return this;
        }
    }
}
