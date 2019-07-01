using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TesteSelenium.Core;
using TesteSelenium.Pages;

namespace TesteSelenium.UI_Tests
{
    [TestClass]
    public class Main
    {
        MainPage mainPage;

        [TestInitialize]
        public void StartBrowser()
        {
            Driver.StartBrowser(Driver.BrowserTypes.Chrome);

            mainPage = new MainPage(Driver.driver);

            Driver.NavigateTo("http://www.google.com.br");
           
        }

        [TestMethod]
        public void VerificarBotaoLogin()
        {
            mainPage.ValidaBotaoLoginNaTela();
        }

        [TestMethod]
        public void VerificaGmailLink()
        {
            mainPage.ValidaGmailLinkNaTela();
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            Driver.StopBrowser();
        }

    }
}
