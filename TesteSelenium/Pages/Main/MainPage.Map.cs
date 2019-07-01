using System;
using OpenQA.Selenium;

namespace TesteSelenium.Pages
{
    public partial class MainPage
	{
        private IWebElement FazerLoginBtn => _driver.FindElement(By.Id("gb_70"));
        private IWebElement GmailLink => _driver.FindElement(By.XPath("//*[@id='gbw']/div/div/div[1]/div[1]/a"));

        private IWebElement NomaConta => _driver.FindElement(By.XPath("//*[@id='gbw']/div/div/div[2]/div[2]/div[2]/div[1]/div/div[1]"));
        private IWebElement ContaLink => _driver.FindElement(By.XPath("//*[@id='gbw']/div/div/div[2]/div[2]/div[1]/a"));
    }
}
