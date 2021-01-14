using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.BaigiamasisProjektas.Test
{
    class BaseTests
    {
        public IWebDriver driver;

        [SetUp]
        public void BeforeTest()
        {
            ChangeDriver("chrome");
            driver.Url = "https://letenos.lt/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);   
        }
        public void ChangeDriver(string driverName)
        {
            if (driverName == "chrome")
            {
                driver = new ChromeDriver(GetChromeConfigurations());
            }
        }
        public ChromeOptions GetChromeConfigurations()
        {
            ChromeOptions configurations = new ChromeOptions();
            configurations.AddArguments("start-maximized", "incognito");
            return configurations;
        }
        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }

    }
}
