using BaigiamasisDarbas.BaigiamasisProjektas.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.BaigiamasisProjektas.Test
{
    class Home : BaseTests
    {
        private HomePage homePage;


        [SetUp]
        public void Beforetest()
        {
            homePage = new HomePage(driver);
        }

        [Test]
        public void CorrectSearch()
        {
            homePage.NavigateToSearch();
            homePage.CorrectSearch();
            homePage.AssertCorrectSearch();   
        }

        [Test]
        public void SelectItemColorAndSize()
        {
            homePage.NavigateToSearch();
            homePage.CorrectSearch();
            homePage.CorrectSearhClick();
            homePage.SelectColor();
            homePage.SelectSize();
            homePage.AssertColorSelect();
            homePage.AssertSizeSelect();
        }

    }
}
