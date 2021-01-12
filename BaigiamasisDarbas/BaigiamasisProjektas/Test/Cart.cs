using BaigiamasisDarbas.BaigiamasisProjektas.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.BaigiamasisProjektas.Test
{
    class Cart : BaseTests
    {
        private CartPage cartPage;

        [SetUp]

        public void Beforetest()
        {
            cartPage = new CartPage (driver);
        }

        [Test]
        public void AddToCart()
        {
            cartPage.AddToCart();
            cartPage.AssertAddedToCart();
        }

        [Test]
        public void CartPreview()
        {
            cartPage.CartPreview();
            cartPage.AssertContinueBillingButtonVisible();
        }
    }
}
