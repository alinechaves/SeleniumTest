using System;
using OpenQA.Selenium;

namespace TesteSelenium.Pages
{
    public partial class LoginPage
    {
        private IWebElement Email => _driver.FindElement(By.Name("identifier"));
        private IWebElement ProximoEmailBtn => _driver.FindElement(By.XPath("//*[@id='identifierNext']/span/span"));

        private IWebElement Senha => _driver.FindElement(By.Name("password"));
        private IWebElement ProximoSenhaBtn => _driver.FindElement(By.XPath("//*[@id='passwordNext']/span/span"));

    }
}
