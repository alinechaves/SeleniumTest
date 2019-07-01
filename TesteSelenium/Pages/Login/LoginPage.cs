using System;
using System.Threading;
using OpenQA.Selenium;

namespace TesteSelenium.Pages
                       
{
    public partial class LoginPage
    {
        
        IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void FazerLogin(string email, string senha)
        {
            Email.SendKeys(email);
            ProximoEmailBtn.Click();
            Thread.Sleep(1000);
            Senha.SendKeys(senha);
            ProximoSenhaBtn.Click();
            Thread.Sleep(3000);
        }


    }

}
