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
        public void BeforeTest()
        {
            cartPage = new CartPage(driver);
        }

        [Test]
        public void AddToCart()
        {
            cartPage.AddToCart();
            cartPage.AssertAddedToCart("“Alpha Spirit tik su žuvimi, 200 gr” - įdėtas į krepšelį");
        }

        [Test]
        public void CartPreview()
        {
            cartPage.CartPreview();
            cartPage.AssertContinueBillingButtonVisible("TĘSTI ATSISKAITYMĄ");
        }

       /* [Test]

         public void ProductInCartIntrease()
         {
             cartPage.CartPreview();
             cartPage.IncreaseProductUpdate();
             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
             cartPage.AssertMessagePopUp();
         } */
    }
}
