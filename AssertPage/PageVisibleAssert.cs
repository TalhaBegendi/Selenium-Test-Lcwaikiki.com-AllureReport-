//TALHA BEĞENDİ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
//TALHA BEĞENDİ

namespace LCWaikikiTest
{
    public class LCWaikikiMethodsAssert
    {
        IWebDriver webDriver;
        IWebElement elementAssert;
        public LCWaikikiMethodsAssert(IWebDriver driver)
        {
            this.webDriver = driver;
        }
        public bool Assert_01_girisYap_01_giris(string girisText)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            elementAssert = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleriAssert.assert_01_girisYap_01_giris));
            return elementAssert.Text == girisText;
        }
        public bool Assert_02_urunArama_01_arama()
        {
            Thread.Sleep(300);
            elementAssert = webDriver.FindElement(kontrolOzellikleriAssert.assert_02_urunArama_01_arama);
            return elementAssert.Enabled;
        }
        public bool Assert_03_urunSecme_01_urunsec_01()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            elementAssert = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleriAssert.assert_03_urunSecme_01_urunsec_01));
            return elementAssert.Displayed;
        }
        public bool Assert_03_fotoSecme_02_foto1()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            elementAssert = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleriAssert.assert_03_fotoSecme_01_foto1));
            return elementAssert.Displayed;
        }
        public bool Assert_03_fotoSecme_02_foto2()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            elementAssert = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleriAssert.assert_03_fotoSecme_02_foto2));
            return elementAssert.Displayed;
        }
        public bool Assert_03_fotoSecme_02_foto3()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            elementAssert = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleriAssert.assert_03_fotoSecme_03_foto3));
            return elementAssert.Displayed;
        }
        public bool Assert_04_urunFavEkleSil_01_urunFavEkle_01()
        {
            Thread.Sleep(490);
            if (webDriver.FindElements(kontrolOzellikleriAssert.assert_04_urunFavEkleSil_01_urunFavEkle).Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Assert_04_urunFavEkleSil_01_urunFavSil_01()
        {
            Thread.Sleep(490);
            if (webDriver.FindElements(kontrolOzellikleriAssert.assert_04_urunFavEkleSil_01_urunFavSil).Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Assert_05_urunSepetEkle_01_urunSepetEkle(string urunSepetEkleText)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            elementAssert = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleriAssert.assert_05_urunSepetEkle_01_urunSepetEkle));
            return elementAssert.Text == urunSepetEkleText;
        }
    }
}
