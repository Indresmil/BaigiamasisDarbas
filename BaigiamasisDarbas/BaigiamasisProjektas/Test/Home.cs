﻿using BaigiamasisDarbas.BaigiamasisProjektas.Pages;
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
            homePage.CorrectSearch("petnešos");
            homePage.AssertCorrectSearch("DOG Copenhagen petnešos Comfort walk Pro NAUJAS MODELIS");   
        }

        [Test]
        public void SelectItemColorAndSize()
        {
            homePage.NavigateToSearch();
            homePage.CorrectSearch("petnešos");
            homePage.CorrectSearhClick();
            homePage.SelectColor();
            homePage.SelectSize();
            homePage.AssertColorSelect("Mėlyna");
            homePage.AssertSizeSelect("L");
        }

        [Test]
        public void FacebookWorking()
        {
            homePage.FacebookClick();
            homePage.AssertFacebookWorking();    
        }

        [Test]
        public void InstagramWorking()
        {
            homePage.InstagramClick();
            homePage.AssertInstagramWorking();
        }
    }
}

