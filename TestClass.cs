//TALHA BEĞENDİ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Assert = NUnit.Framework.Assert;
using Allure.Commons;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
//TALHA BEĞENDİ

namespace LCWaikikiTest
{
    [AllureNUnit]
    public class ChromeAcilisLCW
    {
        IWebDriver Webdriver;
        [OneTimeSetUp]
        public void LCWlGiris()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
            Webdriver = new ChromeDriver();
            Webdriver.Manage().Window.Maximize();
            Webdriver.Navigate().GoToUrl("https://www.lcwaikiki.com/");
            Webdriver.Manage().Cookies.DeleteAllCookies();
        }
        [Test]
        [Category("01_Giris_Test")]
        [AllureTag("NUnit", "01_Giris_Test")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void Test_01_Senaryo_01_Giris()
        {
            LCWaikikiMethods girisYap = new LCWaikikiMethods(Webdriver);
            LCWaikikiMethodsAssert girisYapAssert = new LCWaikikiMethodsAssert(Webdriver);
            girisYap.GirisYap();
            girisYap.Email("asd123@gmail.com");
            girisYap.Sifre("123456");
            girisYap.GirisYapButton();
            Assert.IsTrue(girisYapAssert.Assert_01_girisYap_01_giris("Hesabım"), "Başarıyla Giris Yapildi");
        }
        [Test]
        [Category("02_Urun_Arama_Test")]
        [AllureTag("NUnit", "02_Urun_Arama_Test")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void Test_02_Senaryo_01_UrunArama()
        {
            LCWaikikiMethods urunArama = new LCWaikikiMethods(Webdriver);
            LCWaikikiMethodsAssert urunAramaAssert = new LCWaikikiMethodsAssert(Webdriver);
            urunArama.UrunAramaTikla();
            urunArama.UrunArama("Erkek Pantolon");
            urunArama.AramaButton();
            Assert.IsTrue(urunAramaAssert.Assert_02_urunArama_01_arama(), "Aranılan Arama Başarıyla Yapildi");
        }
        [Test]
        [Category("03_Urun_Secme_Test")]
        [AllureTag("NUnit", "03_Urun_Secme_Test")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void Test_03_Senaryo_01_UrunSecme()
        {
            LCWaikikiMethods urunSecme = new LCWaikikiMethods(Webdriver);
            LCWaikikiMethodsAssert urunSecmeAssert = new LCWaikikiMethodsAssert(Webdriver);
            urunSecme.UrunSec_01();
            Assert.IsTrue(urunSecmeAssert.Assert_03_urunSecme_01_urunsec_01(), "Urun Başarıyla Seçildi.");
            urunSecme.UrunFoto_01();
            Assert.IsTrue(urunSecmeAssert.Assert_03_fotoSecme_02_foto1(), "1. Fotoğraf Başarıyla Görüldü");
            urunSecme.UrunFotoDegis_Sag_Button();
            Assert.IsTrue(urunSecmeAssert.Assert_03_fotoSecme_02_foto2(), "2. Fotoğraf Başarıyla Görüldü");
            urunSecme.UrunFotoDegis_Sag_Button();
            Assert.IsTrue(urunSecmeAssert.Assert_03_fotoSecme_02_foto3(), "3. Fotoğraf Başarıyla Görüldü");
            urunSecme.UrunFotoDegis_Sol_Button();
            Assert.IsTrue(urunSecmeAssert.Assert_03_fotoSecme_02_foto2(), "2. Fotoğraf Başarıyla Görüldü");
            urunSecme.UrunFotoDegis_Sol_Button();
            Assert.IsTrue(urunSecmeAssert.Assert_03_fotoSecme_02_foto1(), "1. Fotoğraf Başarıyla Görüldü");
            urunSecme.UrunFotoKapatButton();
        }
        [Test]
        [Category("04_Urun_Favori_Ekle_Sil_Test")]
        [AllureTag("NUnit", "04_Urun_Favori_Ekle_Sil_Test")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void Test_04_Senaryo_01_UrunFav_Ekle_Sil()
        {
            LCWaikikiMethods urunFavEkleSil = new LCWaikikiMethods(Webdriver);
            LCWaikikiMethodsAssert urunFavEkleSilAssert = new LCWaikikiMethodsAssert(Webdriver);
            urunFavEkleSil.UrunFavEkle();
            urunFavEkleSil.UrunFavorilerimButton();
            Assert.IsTrue(urunFavEkleSilAssert.Assert_04_urunFavEkleSil_01_urunFavEkle_01(), "Urun Başarıyla Başarıyla Favorilere Eklendi.");
            urunFavEkleSil.UrunFavSil();
            Assert.IsTrue(urunFavEkleSilAssert.Assert_04_urunFavEkleSil_01_urunFavSil_01(), "Urun Başarıyla Başarıyla Favorilerden Cikarildi.");
        }
        [Test]
        [Category("05_Urun_Sepet_Ekle_Test")]
        [AllureTag("NUnit", "05_Urun_Sepet_Ekle_Test")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void Test_05_Senaryo_01_UrunSepet_Ekle()
        {
            LCWaikikiMethods urunSepetEkle = new LCWaikikiMethods(Webdriver);
            LCWaikikiMethodsAssert urunSepetEkleAssert = new LCWaikikiMethodsAssert(Webdriver);
            Test_02_Senaryo_01_UrunArama();
            urunSepetEkle.UrunSec_02();
            urunSepetEkle.UrunRenk_kirliMavi();
            urunSepetEkle.UrunRenk_bej();
            urunSepetEkle.UrunBeden_34();
            urunSepetEkle.UrunBoy_Kontrol();
            urunSepetEkle.UrunSepetEkle();
            urunSepetEkle.UrunSepetim();
            urunSepetEkle.UrunSiparisTamamlaButton();
            Assert.IsTrue(urunSepetEkleAssert.Assert_05_urunSepetEkle_01_urunSepetEkle("Fatura Adresi ve Teslimat Adresi"), "Urun Başarıyla Odeme İşlemine Geçildi");
        }
    }
}
