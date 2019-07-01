using System;
using OpenQA.Selenium;

namespace TesteSelenium.Pages
{
    public partial class MainPage
    {
        IWebDriver _driver;

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void PressionaFazerLoginBtn()
        {
            FazerLoginBtn.Click();
        }

        public void PressionaGmailLink()
        {
            GmailLink.Click();
        }

        public void PressionaContaLink()
        {
            ContaLink.Click();
        }
    
    }
}
