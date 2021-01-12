using OpenQA.Selenium;
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

        public void NavigateToSearch()
        {
            searchIcon.Click();
        }
        public void SearchFail()
        {
            search.SendKeys("$" + Keys.Enter);
        }
    }
}
