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
    public static class kontrolOzellikleriAssert
    {
    //XPATH
    //[CacheLookup] public static By girisAssert_01_giris = By.Id("header-user-section");
    [CacheLookup] public static By assert_01_girisYap_01_giris = By.XPath("//div[@class='header-icon-label'][text()[contains(.,'Hesabım')]]");
    [CacheLookup] public static By assert_02_urunArama_01_arama = By.XPath("//meta[@content='Erkek Pantolon - LC Waikiki']");
    [CacheLookup] public static By assert_03_urunSecme_01_urunsec_01 = By.XPath("//div[@class='product-detail' and @modelid='4153925']");
    [CacheLookup] public static By assert_03_fotoSecme_01_foto1 = By.Id("0");
    [CacheLookup] public static By assert_03_fotoSecme_02_foto2 = By.Id("1");
    [CacheLookup] public static By assert_03_fotoSecme_03_foto3 = By.Id("2");
    [CacheLookup] public static By assert_04_urunFavEkleSil_01_urunFavEkle = By.XPath("//div[@class='emi-icons-wrapper']//a[@data-tracking-lastoptionid='1004707']");
    [CacheLookup] public static By assert_04_urunFavEkleSil_01_urunFavSil = By.XPath("//div[@class='emi-icons-wrapper']//a[@data-tracking-lastoptionid='1004707']");
    [CacheLookup] public static By assert_05_urunSepetEkle_01_urunSepetEkle= By.XPath("//p[@class='invoice-address-title'][text()[contains(.,'Fatura Adresi ve Teslimat Adresi')]]");
    }
}
