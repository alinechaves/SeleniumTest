using System;
using System.IO;
using System.Reflection;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TesteSelenium.Core;
using TesteSelenium.Pages;

namespace TesteSelenium.UI_Tests

{   
    [TestClass]
    public class Login
    {
        //IWebDriver driver;
        LoginPage loginPage;
        MainPage mainPage;


        [TestInitialize]
        public void StartBrowser()
        {
            Driver.StartBrowser(Driver.BrowserTypes.Chrome,3000,false);

            mainPage = new MainPage(Driver.driver);
            loginPage = new LoginPage(Driver.driver);
        }

        [TestMethod]
        public void FazerLogin()
        {
            Driver.NavigateTo("http://www.google.com.br");

            mainPage.ValidaBotaoLoginNaTela();
            mainPage.PressionaFazerLoginBtn();

            //mock
            loginPage.FazerLogin("alineqateste@gmail.com","maeestrela");

            mainPage.PressionaContaLink();
            mainPage.ValidaContaLinkNaTela();

        }



        [TestCleanup]
        public void CloseBrowser()
        {
            Driver.StopBrowser();
        }
    }
}
