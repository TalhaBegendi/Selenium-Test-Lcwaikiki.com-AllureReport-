//TALHA BEĞENDİ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
//TALHA BEĞENDİ

namespace LCWaikikiTest
{
    public static class kontrolOzellikleri
    {
        //XPATH
        [CacheLookup] public static By girisYap = By.Id("header-user-section");
        [CacheLookup] public static By email = By.Id("LoginEmail");
        [CacheLookup] public static By sifre = By.Id("Password");
        [CacheLookup] public static By girisYapButton = By.Id("loginLink");
        [CacheLookup] public static By urunAramaTikla = By.Name("search");
        [CacheLookup] public static By urunArama = By.XPath("//div[@class='search-area']/input");
        [CacheLookup] public static By aramaButton = By.XPath("//div[@class='search-area']/a[@class='search-button']");
        [CacheLookup] public static By urunFavorilerimButton = By.XPath("//div[@class='col-sm-4 visible-md visible-lg']/a");
        [CacheLookup] public static By urunSepetEkle = By.Id("pd_add_to_cart");
        [CacheLookup] public static By urunSepetim = By.XPath("//div[@class='col-sm-4 col-xs-4 header-cart-section padding-r-0']/a");
        [CacheLookup] public static By urunSiparisTamamlaButton = By.Id("Cart_CompleteOrder");

        [CacheLookup] public static By urunFotoDegis_Sag_Button = By.Id("NextImageButton");
        [CacheLookup] public static By urunFotoDegis_Sol_Button = By.Id("PreviousImageButton");
        [CacheLookup] public static By urunFotoKapatButton = By.Id("CloseModalButton");

        [CacheLookup] public static By urunSec_01 = By.Id("model_1004707_4153925");
        [CacheLookup] public static By urunFoto_01 = By.Id("OptionImage0");

        [CacheLookup] public static By urunFavEkle = By.XPath("//a[@class='interaction-button interaction-like add-to-favorite-detail']");
        [CacheLookup] public static By urunFavSil = By.XPath("//div[@class='emi-item fav']");

        [CacheLookup] public static By urunSec_02 = By.Id("model_674123_3887627");
        [CacheLookup] public static By urunRenk_kirliMavi = By.XPath("//div[@title='Kirli Mavi']");
        [CacheLookup] public static By urunRenk_bej = By.XPath("//div[@title='Bej']");

        [CacheLookup] public static By urunBeden_33 = By.XPath("//div[@class='mobile-size-and-cart-container']//a[@size='33']");
        [CacheLookup] public static By urunBeden_34 = By.XPath("//div[@class='mobile-size-and-cart-container']//a[@size='34']");

        [CacheLookup] public static By urunBoy_29_kontrol = By.XPath("//div[@class='mobile-size-and-cart-container']//a[@height='29' and @class='disabled']");
        [CacheLookup] public static By urunBoy_29 = By.XPath("//div[@class='mobile-size-and-cart-container']//a[@height='29']");

        [CacheLookup] public static By urunBoy_31_kontrol = By.XPath("//div[@class='mobile-size-and-cart-container']//a[@height='31' and @class='disabled']");
        [CacheLookup] public static By urunBoy_31 = By.XPath("//div[@class='mobile-size-and-cart-container']//a[@height='31']");

        [CacheLookup] public static By urunBoy_32_kontrol = By.XPath("//div[@class='mobile-size-and-cart-container']//a[@height='32' and @class='disabled']");
        [CacheLookup] public static By urunBoy_32 = By.XPath("//div[@class='mobile-size-and-cart-container']//a[@height='32']");

        [CacheLookup] public static By urunBoy_33_kontrol = By.XPath("//div[@class='mobile-size-and-cart-container']//a[@height='33' and @class='disabled']");
        [CacheLookup] public static By urunBoy_33 = By.XPath("//div[@class='mobile-size-and-cart-container']//a[@height='33']");

        [CacheLookup] public static By urunBoy_35_kontrol = By.XPath("//div[@class='mobile-size-and-cart-container']//a[@height='35' and @class='disabled']");
        [CacheLookup] public static By urunBoy_35 = By.XPath("//div[@class='mobile-size-and-cart-container']//a[@height='35']");

    }
}
