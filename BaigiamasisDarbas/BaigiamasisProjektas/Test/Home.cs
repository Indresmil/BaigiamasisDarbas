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
            homePage
                .NavigateToSearch()
                .CorrectSearch("petnešos")
                .AssertCorrectSearch("DOG Copenhagen petnešos Comfort walk Pro NAUJAS MODELIS");   
        }

        [Test]
        public void SelectItemColorAndSize()
        {
            homePage
                .NavigateToSearch()
                .CorrectSearch("petnešos")
                .CorrectSearhClick()
                .SelectColor()
                .SelectSize()
                .AssertColorSelect("Mėlyna")
                .AssertSizeSelect("L");
        }

        [Test]
        public void FacebookWorking()
        {
            homePage
                .FacebookClick()
                .AssertFacebookWorking();
            TakeScreenshot();
        }

        [Test]
        public void InstagramWorking()
        {
            homePage
                .InstagramClick()
                .AssertInstagramWorking();
            TakeScreenshot();
        }

        [Test]
        public void TermsAndConditionsInfoPageWorking()
        {

            homePage
                .TermsAndConditionsInfo()
                .AssertTermsAndConditionsInfoPageWorking();
        }
    }
}

