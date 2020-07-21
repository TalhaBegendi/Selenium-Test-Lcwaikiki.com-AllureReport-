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
    public class LCWaikikiMethods
    {
        IWebDriver webDriver;
        IWebElement element;
        public LCWaikikiMethods(IWebDriver driver)
        {
            this.webDriver = driver;
        }
        public void GirisYap()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.girisYap));
            element.Click();
        }
        public void Email(string email)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.email));
            element.SendKeys(email);
        }
        public void Sifre(string sifre)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.sifre));
            element.SendKeys(sifre);
        }
        public void GirisYapButton()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.girisYapButton));
            element.Click();
        }
        public void UrunAramaTikla()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunAramaTikla));
            element.Click();
        }
        public void UrunArama(string urunArama)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunArama));
            element.SendKeys(urunArama);
        }
        public void AramaButton()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.aramaButton));
            element.Click();
        }
        public void UrunSec_01()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunSec_01));
            element.Click();
        }

        public void UrunFoto_01()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunFoto_01));
            element.Click();
        }
        public void UrunFotoDegis_Sag_Button()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunFotoDegis_Sag_Button));
            element.Click();
        }
        public void UrunFotoDegis_Sol_Button()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunFotoDegis_Sol_Button));
            element.Click();
        }
        public void UrunFotoKapatButton()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunFotoKapatButton));
            element.Click();
        }
        public void UrunFavorilerimButton()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunFavorilerimButton));
            element.Click();
        }
        public void UrunFavEkle()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunFavEkle));
            element.Click();
        }
        public void UrunFavSil()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunFavSil));
            element.Click();
        }

        public void UrunSepetim()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunSepetim));
            element.Click();
        }
        public void UrunSepetEkle()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunSepetEkle));
            element.Click();
        }
        public void UrunSiparisTamamlaButton()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunSiparisTamamlaButton));
            element.Click();
        }
        public void UrunSec_02()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunSec_02));
            element.Click();
        }
        public void UrunRenk_kirliMavi()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunRenk_kirliMavi));
            element.Click();
        }
        public void UrunRenk_bej()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunRenk_bej));
            element.Click();
        }
        public void UrunBeden_34()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunBeden_34));
            element.Click();
        }
        public void UrunBoy_29()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunBoy_29));
            element.Click();
        }
        public void UrunBoy_Kontrol()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            IWebElement urunBoy_29 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunBoy_29));
            IWebElement urunBoy_31 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunBoy_31));
            IWebElement urunBoy_32 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunBoy_32));
            IWebElement urunBoy_33 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunBoy_33));
            IWebElement urunBoy_35 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(kontrolOzellikleri.urunBoy_35));
            for (int i = 0; i < 5; i++)
            {
                if (webDriver.FindElements(kontrolOzellikleri.urunBoy_29_kontrol).Count == 0)
                {
                    urunBoy_29.Click();
                }
                else if (webDriver.FindElements(kontrolOzellikleri.urunBoy_31_kontrol).Count == 0)
                {
                    urunBoy_31.Click();
                }
                else if (webDriver.FindElements(kontrolOzellikleri.urunBoy_32_kontrol).Count == 0)
                {
                    urunBoy_32.Click();
                }
                else if (webDriver.FindElements(kontrolOzellikleri.urunBoy_33_kontrol).Count == 0)
                {
                    urunBoy_33.Click();
                }
                else if (webDriver.FindElements(kontrolOzellikleri.urunBoy_35_kontrol).Count == 0)
                {
                    urunBoy_35.Click();
                }
                else
                {
                    Thread.Sleep(1500);
                }
            }
        }
    }
}
