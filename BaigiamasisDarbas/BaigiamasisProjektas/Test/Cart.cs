using BaigiamasisDarbas.BaigiamasisProjektas.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.BaigiamasisProjektas.Test
{
    class Cart : BaseTests
    {
        private CartPage basketPage;

        [SetUp]

        public void Beforetest()
        {
            basketPage = new CartPage (driver);
        }

        [Test]
        public void AddToCart()
        {
            basketPage.AddToCart();
            basketPage.AssertAddedToCart();
        }
    }
}
