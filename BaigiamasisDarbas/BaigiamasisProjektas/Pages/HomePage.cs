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

        public void NavigateToSearch()
        {
            searchIcon.Click();
        }
        public void CorrectSearch()
        {
            search.SendKeys("petnešos" + Keys.Enter);
        }
        public void CorrectSearhClick()
        {
            item.Click();
        }
        public void AssertCorrectSearch()
        {
            Assert.AreEqual("DOG Copenhagen petnešos Comfort walk Pro NAUJAS MODELIS", driver.FindElement(By.LinkText("DOG Copenhagen petnešos Comfort walk Pro NAUJAS MODELIS")).Text);
        }
        public void SelectColor()
        {
            colorSelect.Click();
        }
        public void AssertColorSelect()
        {
            Assert.AreEqual("Mėlyna", driver.FindElement(By.CssSelector("#pa_spalva > option:nth-child(7)")).Text);
        }
        public void SelectSize()
        {
            sizeSelect.Click();
        }
        public void AssertSizeSelect()
        {
            Assert.AreEqual("L", driver.FindElement(By.CssSelector("#pa_dydis > option:nth-child(2)")).Text);
        }
        public void SearchFail()
        {
            search.SendKeys("$" + Keys.Enter);
        }
    }
}
